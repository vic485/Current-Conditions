#if UNITY_EDITOR
using System.IO;
using DataModels;
using Newtonsoft.Json;
using UnityEngine;

namespace Management
{
    /// <summary>
    /// Load settings directly while in editor so I don't have to start from startup scene
    /// </summary>
    public class EditorSettingLoader : MonoBehaviour
    {
        private void Awake()
        {
            SystemManager.Settings =
                JsonConvert.DeserializeObject<SettingsModel>(
                    File.ReadAllText(Path.Combine(Application.persistentDataPath, "settings.json")));
        }
    }
}
#endif
