using Newtonsoft.Json;
using WeatherSystem.ResultModels.Entities;

namespace WeatherSystem.ResultModels
{
    public class AutoIpModel
    {
        [JsonProperty("api_version")]
        public string ApiVersion { get; set; }
        [JsonProperty("geo")]
        public IpLocationData GeoData { get; set; }
        [JsonProperty("ip")]
        public string IpAddress { get; set; }
        [JsonProperty("time")]
        public long Timestamp { get; set; }
    }

}
