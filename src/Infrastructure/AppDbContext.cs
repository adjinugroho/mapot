using Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class AppDbContext
    {
        public static IServiceCollection AddAppDbContext(this IServiceCollection services, string connectionString)
        {
            services
                .AddDbContext<ApplicationContext>(options =>
                {
                    options.UseSqlServer(connectionString);
                });

            return services;
        }
    }
}
