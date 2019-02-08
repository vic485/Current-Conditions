using Newtonsoft.Json;

namespace WeatherSystem.ResultModels.Entities
{
    public class IpLocationData
    {
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("metro_code")]
        public int MetroCode { get; set; }
        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }
    }

}
