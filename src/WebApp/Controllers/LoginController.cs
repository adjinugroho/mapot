using Domain.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApp.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _userSvc;

        public LoginController(
            IUserService userSvc)
        {
            _userSvc = userSvc;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Authenticate(UserDto user)
        {
            var ret = _userSvc.Login(user);

            if (ret.IsSuccess)
            {
                var userData = ret.Value;

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Sid, userData.Id.ToString()),
                    new Claim(ClaimTypes.NameIdentifier, userData.UserId),
                    new Claim(ClaimTypes.Name, userData.Name),
                    new Claim(ClaimTypes.Role, userData.Role)
                };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = false
                };

                await HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return Content(Url.Action("Index", "Dashboard").ToString());
            }
            else
            {
                return Content("Error: " + ret.Reasons.First().Message);
            }
        }
    }
}
