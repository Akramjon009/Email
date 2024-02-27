using LoginChecker.Application.Service.Check2;
using LoginChecker.Application.Service.Logins;
using LoginChecker.Application.Service.Registers;
using Microsoft.Extensions.DependencyInjection;


namespace LoginChecker.Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddAplication(this IServiceCollection services)
        {
            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<ICheckService, CheckService>();
            services.AddScoped<IRegisterService, RegisterService>();
            return services;
        }
    }
}
