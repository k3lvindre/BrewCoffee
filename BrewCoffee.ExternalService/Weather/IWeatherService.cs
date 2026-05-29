using Refit;

namespace BrewCoffee.ExternalService.Weather
{
    public interface IWeatherService
    {
        [Get("lat={lat}&lon={lon}&appid={apikey}")]
        Task<ApiResponse<GetCurrentWeatherDataResponse>> GetCurrentWeatherDataAsync([AliasAs("lat")] string latitude,
            [AliasAs("lon")] string longtitude, 
            [AliasAs("apikey")] string apiKey);

    }
}
