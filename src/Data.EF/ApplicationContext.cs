using Core.EntityTables;
using Data.EF.EntityConfigs;
using Microsoft.EntityFrameworkCore;

namespace Data.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<TAppLog> AppLogs { get; set; }
        public DbSet<TAppApplication> AppUsers { get; set; }
        public DbSet<TAppApplication> AppApplications { get; set; }
        public DbSet<TAppUserApplication> AppUserApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region Main App
            builder.ApplyConfiguration(new TAppLogConfig());
            builder.ApplyConfiguration(new TAppUserConfig());
            builder.ApplyConfiguration(new TAppApplicationConfig());
            builder.ApplyConfiguration(new TAppUserApplicationConfig());
            #endregion
        }
    }
}
