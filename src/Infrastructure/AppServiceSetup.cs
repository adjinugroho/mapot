using Core;
using Data.EF;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class AppServiceSetup
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
