using System;

namespace WeatherSystem.Utilities
{
    public static class UnixTime
    {
        public static DateTime ConvertFrom(long seconds)
            => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(seconds);
    }

}
