namespace BrewCoffee.Core.Services.Weather
{
    public interface IWeatherService
    {
        Task<int> GetCurrentWeatherTemparatureAsync();
    }
}
