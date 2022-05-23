using Core.EntityTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.EntityConfigs
{
    internal class TAppLogConfig : IEntityTypeConfiguration<TAppLog>
    {
        public virtual void Configure(EntityTypeBuilder<TAppLog> builder)
        {
            builder.ToTable("App_Log");

            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.LogDate).IsRequired();
            builder.Property(e => e.Action).IsRequired();
        }
    }
}
