using Newtonsoft.Json;
using WeatherSystem.ResultModels.Entities;

namespace WeatherSystem.ResultModels
{
    public class CurrentWeatherResult
    {
        [JsonProperty("coord")] public Location Coordinates { get; set; }
        [JsonProperty("weather")] public Weather[] CurrentWeather { get; set; }
        [JsonProperty("base")] public string Base { get; set; }
        [JsonProperty("main")] public Main Main { get; set; }
        [JsonProperty("visibility")] public int Visibility { get; set; }
        [JsonProperty("wind")] public Wind Wind { get; set; }
        [JsonProperty("clouds")] public Clouds Clouds { get; set; }
        [JsonProperty("rain")] public Rain Rain { get; set; } = new Rain();
        [JsonProperty("snow")] public Rain Snow { get; set; } = new Rain();
        [JsonProperty("dt")] public long Timestamp { get; set; }
        [JsonProperty("sys")]  public Sys Sys { get; set; }
        [JsonProperty("id")] public long Id { get; set; }
        [JsonProperty("name")] public string Name { get; set; }
        [JsonProperty("cod")] public int Cod { get; set; }
        
        // TODO: DateTime return for "dt"
    }
}
