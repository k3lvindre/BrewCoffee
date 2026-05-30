using Refit;

namespace BrewCoffee.ExternalService.Weather.OpenWeatherOrg
{
    public interface IOpenWeatherOrgWeatherService
    {
        [Get("?lat={lat}&lon={lon}&units=metric&appid={apikey}")]
        Task<ApiResponse<OpenWeatherMapOrgGetCurrentWeatherDataResponse>> GetCurrentWeatherDataAsync([AliasAs("lat")] double latitude,
            [AliasAs("lon")] double longtitude, 
            [AliasAs("apikey")] string apiKey);

    }
}
