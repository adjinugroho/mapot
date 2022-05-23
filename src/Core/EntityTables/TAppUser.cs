namespace Core.EntityTables
{
    public class TAppUser : BaseEntity
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Name { get; set; }
        public int LoginAttempt { get; set; }

        public IEnumerable<TAppLog> AppLogs { get; set; }
        public IEnumerable<TAppUserApplication> UserApplications { get; set; }
    }
}
