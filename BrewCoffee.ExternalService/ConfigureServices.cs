using BrewCoffee.ExternalService.Weather.OpenWeatherOrg;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Refit;

namespace BrewCoffee.ExternalService
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddExternalServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddHttpClient();
           
            services.AddRefitClient<IOpenWeatherOrgWeatherService>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(configuration["ExternalService:Weather:OpenWeatherMapOrg:BaseUrl"]!));

            return services;
        }
    }
}
