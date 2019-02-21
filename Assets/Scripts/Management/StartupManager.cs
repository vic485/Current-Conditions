using System.Collections;
using System.IO;
using DataModels;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Management
{
    public class StartupManager : MonoBehaviour
    {
        [SerializeField] private float startupDelay = 1.5f;

        [Header("Settings")] [SerializeField] private GameObject settingsPanel;
        [SerializeField] private InputField apiKeyField;
        [SerializeField] private Toggle locationToggle;
        [SerializeField] private InputField cityField;
        [SerializeField] private Text fileInfo;

        private string _settingsFilePath;
        private bool _blocked;

        private IEnumerator Start()
        {
            _settingsFilePath = Path.Combine(Application.persistentDataPath, "settings.json");

            if (!File.Exists(_settingsFilePath))
            {
                OpenSettingsPanel();
                yield break;
            }

            LoadSettings();
            yield return new WaitForSeconds(startupDelay);
            if (!_blocked)
                SceneManager.LoadScene("MainRunner");
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.LeftAlt))
                _blocked = true;
        }

        private void LoadSettings()
            => SystemManager.Settings =
                JsonConvert.DeserializeObject<SettingsModel>(File.ReadAllText(_settingsFilePath));

        public void SaveSettings()
        {
            SystemManager.Settings = new SettingsModel
            {
                // TODO: Get from settings window
                ApiKey = apiKeyField.text,
                AutoLocation = locationToggle.isOn,
                City = cityField.text,
                WaitMin = 15
            };

            File.WriteAllText(_settingsFilePath,
                JsonConvert.SerializeObject(SystemManager.Settings, Formatting.Indented));

            SceneManager.LoadScene("MainRunner");
        }

        private void OpenSettingsPanel()
        {
            settingsPanel.SetActive(true);

            fileInfo.text = $"To edit later, hold 'Left Alt' key during startup, or edit the file\n{_settingsFilePath}";
        }
    }
}
