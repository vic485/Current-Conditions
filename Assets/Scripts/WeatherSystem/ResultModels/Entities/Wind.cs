using Newtonsoft.Json;

namespace WeatherSystem.ResultModels.Entities
{
    public class Wind
    {
        [JsonProperty("speed")] public double Speed { get; set; }
        [JsonProperty("deg")] public int Degrees { get; set; }
    }
}