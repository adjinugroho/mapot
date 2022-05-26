using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Helpers;
using WebApp.Models;

namespace WebApp.Controllers
{
    [Authorize]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var ret = new VMIndex()
            {
                ThisController = "Dashboard",
                PageTitle = "Dashboard",
                HeaderName = "Dashboard",
                HeaderIcon = ViewIcon.DashboardIcon
            };

            return View(ret);
        }
    }
}
