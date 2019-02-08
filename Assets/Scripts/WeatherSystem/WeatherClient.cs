using System;
using Newtonsoft.Json;
using WeatherSystem.ResultModels;
using WeatherSystem.Utilities;

namespace WeatherSystem
{
    public class WeatherClient
    {
        private readonly string _apiKey;
        
        public WeatherClient(string appId)
        {
            _apiKey = appId;
        }

        public CurrentWeatherResult GetWeather()
        {
            var location = RestUtility.Execute<AutoIpModel>(new Uri("https://ipinfo.now.sh")).GeoData;
            return RestUtility.Execute<CurrentWeatherResult>(new Uri(
                $"https://api.openweathermap.org/data/2.5/weather?lat={location.Latitude}&lon={location.Longitude}&appid={_apiKey}"));
        }
    }

}
