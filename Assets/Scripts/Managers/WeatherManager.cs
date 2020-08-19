using System.Net;
using OpenWeatherAPI;
using UnityEngine;

public class WeatherManager : MonoBehaviour
{
    private API _apiClient;
    private float _timer;
    
    // Start is called before the first frame update
    private void Start()
    {
        _apiClient = new API(/*SettingsManager.Settings.ApiKey*/ "");

        try
        {
            var weather = _apiClient.Query("4780641");
            Debug.Log(weather.Name);
        }
        catch (WebException e)
        {
            if (e.Status == WebExceptionStatus.ProtocolError) 
            {
                if (((HttpWebResponse) e.Response).StatusCode == HttpStatusCode.Unauthorized)
                {
                    // TODO: Show pop-up to check api key
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;

        if (_timer < SettingsManager.Settings.TimeDelay)
            return;

        _timer = 0;
        // TODO: re-poll weather
    }
}
