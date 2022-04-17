using CleanArchitecture.Application.Contracts.Shared;
using Microsoft.Extensions.DependencyInjection;
namespace CleanArchitecture.Resources
{
    public static class ResourceServicesRegistration
    {
        public static IServiceCollection ConfigureResourceServices(this IServiceCollection services)
        {
            services.AddScoped<ILocalizationService, LocalizationService>();
            return services;
        }
    }
}
