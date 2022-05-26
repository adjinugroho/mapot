using Core;
using Data.EF;
using Domain.Application;
using Domain.User;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class AppServiceSetup
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            services.AddTransient<IUserService, UserService>();

            return services;
        }
    }
}
