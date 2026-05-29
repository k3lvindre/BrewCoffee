using BrewCoffee.ExternalService.Weather;
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
           
            services.AddRefitClient<IWeatherService>()
                .ConfigureHttpClient(c => c.BaseAddress = new Uri(configuration["ExternalService:Weather:BaseUrl"]!));

            return services;
        }
    }
}
