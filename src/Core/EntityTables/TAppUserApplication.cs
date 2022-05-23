namespace Core.EntityTables
{
    public class TAppUserApplication : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid ApplicationId { get; set; }

        public TAppUser User { get; set; }
        public TAppApplication Application { get; set; }
    }
}
