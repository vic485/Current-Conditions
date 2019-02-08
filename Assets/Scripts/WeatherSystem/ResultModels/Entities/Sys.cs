using Newtonsoft.Json;

namespace WeatherSystem.ResultModels.Entities
{
    public class Sys
    {
        [JsonProperty("type")] public int Type { get; set; }
        [JsonProperty("id")] public int Id { get; set; }
        [JsonProperty("message")] public double Message { get; set; }
        [JsonProperty("country")] public string Country { get; set; }
        [JsonProperty("sunrise")] public long TimestampSunrise { get; set; }
        [JsonProperty("sunset")] public long TimestampSunset { get; set; }
        
        // TODO: DateTime return for sunrise/sunset
    }
}