using Newtonsoft.Json;

namespace WeatherSystem.ResultModels.Entities
{
    public class Main
    {
        [JsonProperty("temp")] public double Temperature { get; set; }
        [JsonProperty("pressure")] public int Pressure { get; set; }
        [JsonProperty("humidity")] public int Humidity { get; set; }
        [JsonProperty("temp_min")] public double MinTemperature { get; set; }
        [JsonProperty("temp_max")] public double MaxTemperature { get; set; }
        [JsonProperty("sea_level")] public int SeaLevelPressure { get; set; }
        [JsonProperty("grnd_level")] public int GroundLevelPressure { get; set; }
    }
}