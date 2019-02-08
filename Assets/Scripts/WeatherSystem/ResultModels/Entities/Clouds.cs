using Newtonsoft.Json;

namespace WeatherSystem.ResultModels.Entities
{
    public class Clouds
    {
        [JsonProperty("all")] public int Cloudiness { get; set; }
    }
}