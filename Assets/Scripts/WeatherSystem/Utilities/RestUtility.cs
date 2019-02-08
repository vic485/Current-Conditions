using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherSystem.Utilities
{
    internal static class RestUtility
    {
        internal static T Execute<T>(Uri uri) where T : new()
            => Task.Run(async () => await ExecuteAsync<T>(uri).ConfigureAwait(false)).Result;

        internal static async Task<T> ExecuteAsync<T>(Uri uri) where T : new()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(uri).ConfigureAwait(false);
            var content = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            
            if (content.Contains("401")) throw new ArgumentException("Invalid API key");
            
            // TODO: Better flow control
            if (response.IsSuccessStatusCode)
            {
                if (content.Length > 0)
                    return JsonConvert.DeserializeObject<T>(content);
                
                throw new HttpRequestException("No data returned");
            }
            
            throw new HttpRequestException(response.ReasonPhrase);
        }
    }
}