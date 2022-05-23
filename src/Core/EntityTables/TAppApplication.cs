namespace Core.EntityTables
{
    public class TAppApplication : BaseEntity
    {
        public string AppName { get; set; }
        public string Url { get; set; }
        public string? Description { get; set; }

        public IEnumerable<TAppUserApplication> UserApplications { get; set; }
    }
}
