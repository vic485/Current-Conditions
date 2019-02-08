using Newtonsoft.Json;

namespace WeatherSystem.ResultModels.Entities
{
    public class Rain
    {
        [JsonProperty("1h")] public int Volume1H { get; set; }
        [JsonProperty("3h")] public int Volume3H { get; set; }
    }
}