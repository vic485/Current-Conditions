using DataModels;
using UnityEngine;
using WeatherSystem;

namespace Management
{
    public class SystemManager : MonoBehaviour
    {
        internal static SettingsModel Settings;

        private float _timer;
        private WeatherClient _client;

        private void Start()
        {
            _client = new WeatherClient(Settings.ApiKey);
            // TODO: Initial weather pull
            _timer = 0f;
        }

        private void Update()
        {
            _timer += Time.deltaTime / 60f;

            if (_timer >= Settings.WaitMin)
            {
                _timer = 0f;
                // TODO: Pull weather update
            }
        }
    }

}
