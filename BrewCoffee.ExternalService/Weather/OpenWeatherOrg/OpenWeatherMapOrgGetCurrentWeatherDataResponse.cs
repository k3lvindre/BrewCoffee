using System.Text.Json.Serialization;

namespace BrewCoffee.ExternalService.Weather.OpenWeatherOrg
{
    public class OpenWeatherMapOrgGetCurrentWeatherDataResponse
    {
        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("lon")]
        public double Longtitude { get; set; }

        [JsonPropertyName("timezone")]
        public string TimeZone { get; set; } = string.Empty;

        [JsonPropertyName("timezone_offset")]
        public int TimezoneOffset { get; set; }

        [JsonPropertyName("data")]
        public List<Data> Data { get; set; } = new List<Data>();
    }
    public class Data
    {
        [JsonPropertyName("temp")]
        public double Temperature { get; set; }
    }
}
