using System.Collections;
using System.IO;
using DataModels;
using Newtonsoft.Json;
using UiHelpers;
using UnityEngine;
using WeatherSystem;

namespace Management
{
    public class SystemManager : MonoBehaviour
    {
        [SerializeField] private CurrentConditionsHelper currentConditions;

        private float _timer = 0f;
        private int _waitTime;
        private WeatherClient _weatherClient;

        private void Start()
        {
            LoadOrCreateSettings();
            UpdateUi();
        }

        private void Update()
        {
            _timer += Time.deltaTime;

            if (!(_timer >= _waitTime))
                return;

            UpdateUi();
        }

        private void UpdateUi()
        {
            _timer = 0f;
            currentConditions.ChangeData(_weatherClient.GetWeather());
        }

        private void LoadOrCreateSettings()
        {
            var path = Path.Combine(Application.persistentDataPath, "config.json");
            
            if (!File.Exists(path))
                File.WriteAllText(path, JsonConvert.SerializeObject(new SettingsModel(), Formatting.Indented));

            var settings = JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText(path));
            
            _weatherClient = new WeatherClient(settings.ApiKey);
            _waitTime = settings.WaitMin * 60;
        }
    }

}
