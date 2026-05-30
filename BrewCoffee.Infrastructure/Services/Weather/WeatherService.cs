using BrewCoffee.Core.Common.Exceptions;
using BrewCoffee.Core.Services.Weather;
using BrewCoffee.ExternalService.Weather.OpenWeatherOrg;
using Microsoft.Extensions.Configuration;

namespace BrewCoffee.Infrastructure.Services.Weather
{
    public class WeatherService(IOpenWeatherOrgWeatherService openWeatherOrgWeather,
        IConfiguration configuration) : IWeatherService
    {
        private readonly IOpenWeatherOrgWeatherService _openWeatherOrgWeather = openWeatherOrgWeather;
        private readonly IConfiguration _configuration = configuration;

        public async Task<int> GetCurrentWeatherTemparatureAsync()
        {
            var currentWeatherData = await _openWeatherOrgWeather.GetCurrentWeatherDataAsync(52.2297, 
                21.0122,
                _configuration["ExternalService:Weather:OpenWeatherMapOrg:ApiKey"]!);

            var currentTemparature = currentWeatherData?.Content?.Data.FirstOrDefault()?.Temperature ?? 
                throw new BusinessException();

            return Convert.ToInt32(currentTemparature);
        }
    }
}
