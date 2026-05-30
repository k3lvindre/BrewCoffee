using BrewCoffee.Core.Services.Weather;

namespace BrewCoffee.UnitTests.Coffees
{
    public class WeatherServiceMoq : IWeatherService
    {
        private readonly int _temperature;
        public WeatherServiceMoq(int temperature) => _temperature = temperature;
        public Task<int> GetCurrentWeatherTemparatureAsync() => Task.FromResult(_temperature);
    }
}
