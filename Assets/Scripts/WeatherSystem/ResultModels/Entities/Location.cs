using Newtonsoft.Json;

namespace WeatherSystem.ResultModels.Entities
{
    public class Location
    {
        [JsonProperty("lon")] public double Longitude { get; set; }
        [JsonProperty("lat")] public double Latitude { get; set; }
    }
}