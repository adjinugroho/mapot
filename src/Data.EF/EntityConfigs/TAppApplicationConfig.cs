using Core.EntityTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.EntityConfigs
{
    internal class TAppApplicationConfig : IEntityTypeConfiguration<TAppApplication>
    {
        public virtual void Configure(EntityTypeBuilder<TAppApplication> builder)
        {
            builder.ToTable("App_Application");

            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.IsActive).IsRequired();
            builder.Property(e => e.CreatedBy).IsRequired();
            builder.Property(e => e.CreatedAt).IsRequired();

            builder.Property(e => e.AppName).IsRequired();
            builder.Property(e => e.Url).IsRequired();
        }
    }
}
