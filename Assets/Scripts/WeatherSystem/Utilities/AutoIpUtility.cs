using System;

namespace WeatherSystem.Utilities
{
    internal static class AutoIpUtility
    {
        private static Uri _uri = new Uri("https://ipinfo.now.sh");
        
        internal static (double, double) FindLocation()
        {
            
            return (0.0, 0.0);
        }
    }

}
