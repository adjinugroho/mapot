using Core;
using Core.IRepositories;
using Data.EF;
using Data.EF.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class AppRepositorySetup
    {
        public static IServiceCollection AddAppRepositories(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            services.AddScoped<ITAppLogRepository, TAppLogRepository>();
            services.AddScoped<ITAppUserRepository, TAppUserRepository>();
            services.AddScoped<ITAppApplicationRepository, TAppApplicationRepository>();
            services.AddScoped<ITAppUserApplicationRepository, TAppUserApplicationRepository>();

            return services;
        }
    }
}
