namespace Core.EntityTables
{
    public class TAppLog
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public DateTime LogDate { get; set; }
        public string Action { get; set; }
        public string? Description { get; set; }
        public string? Remark { get; set; }

        public TAppUser User { get; set; }
    }
}
