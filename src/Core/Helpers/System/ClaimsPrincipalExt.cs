using System.Security.Claims;

namespace Core.Helpers.System
{
    public static class ClaimsPrincipalExt
    {
        public static string GetName(this ClaimsPrincipal principal)
        {
            var name = principal.FindFirst(ClaimTypes.Name);

            if (name == null)
                return "";

            return name.Value;
        }

        public static string GetRole(this ClaimsPrincipal principal)
        {
            var role = principal.FindFirst(ClaimTypes.Role);

            if (role == null)
                return "";

            return role.Value;
        }

        public static string GetUserId(this ClaimsPrincipal principal)
        {
            var userId = principal.FindFirst(ClaimTypes.NameIdentifier);

            if (userId == null)
                return "";

            return userId.Value;
        }

        public static Guid GetUserSid(this ClaimsPrincipal principal)
        {
            var userSid = principal.FindFirst(ClaimTypes.Sid);

            if (userSid == null)
                return Guid.Empty;

            return Guid.Parse(userSid.Value);
        }
    }
}
