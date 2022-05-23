using Core.EntityTables;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.EF.EntityConfigs
{
    internal class TAppUserConfig : IEntityTypeConfiguration<TAppUser>
    {
        public virtual void Configure(EntityTypeBuilder<TAppUser> builder)
        {
            builder.ToTable("App_User");

            builder.Property(e => e.Id).IsRequired();
            builder.Property(e => e.IsActive).IsRequired();
            builder.Property(e => e.CreatedBy).IsRequired();
            builder.Property(e => e.CreatedAt).IsRequired();

            builder.Property(e => e.UserId).IsRequired();
            builder.Property(e => e.Password).IsRequired();
            builder.Property(e => e.Role).IsRequired();
            builder.Property(e => e.Name).IsRequired();
            builder.Property(e => e.LoginAttempt).IsRequired();

            builder.HasData(new TAppUser
            {
                Id = Guid.NewGuid(),
                UserId = "Superman",
                Password = BCrypt.Net.BCrypt.HashPassword("admin"),
                Role = "Admin",
                Name = "Superman",
                LoginAttempt = 0,
                CreatedBy = "DATA SEED",
                CreatedAt = DateTime.UtcNow
            });
        }
    }
}
