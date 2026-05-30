using BrewCoffee.Core.Services.Weather;
using BrewCoffee.Infrastructure.Services.Weather;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BrewCoffee.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddScoped<IWeatherService, WeatherService>();

            return services;
        }
    }
}
