namespace WebApp.Helpers
{
    public static class UserRole
    {
        public const string ADMIN = "Admin";
        public const string USER = "User";
    }

    public class SharedView
    {
        public const string Index = "~/Views/Shared/_Index.cshtml";
        public const string Delete = "~/Views/Shared/_Delete.cshtml";
    }

    public class ActionMethod
    {
        public const string CREATE = "Create";
        public const string EDIT = "Edit";
        public const string DELETE = "Delete";
    }

    public class ViewIcon
    {
        public const string DashboardIcon = "fas fa-tachometer-alt";
        public const string AppIcon = "far fa-window-maximize";
        public const string UserIcon = "fas fa-user-cog";
    }
}
