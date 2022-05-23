using Core.EntityTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.EntityConfigs
{
    internal class TAppUserApplicationConfig : IEntityTypeConfiguration<TAppUserApplication>
    {
        public virtual void Configure(EntityTypeBuilder<TAppUserApplication> builder)
        {
            builder.ToTable("App_UserApplication");

            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.IsActive).IsRequired();
            builder.Property(e => e.CreatedBy).IsRequired();
            builder.Property(e => e.CreatedAt).IsRequired();

            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.ApplicationId).IsRequired();
        }
    }
}
