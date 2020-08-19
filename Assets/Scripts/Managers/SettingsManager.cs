using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;

internal static class SettingsManager
{
    private static readonly string FilePath = Path.Combine(Application.persistentDataPath, "settings.json");

    internal static Settings Settings;

    static SettingsManager()
    {
        if (!File.Exists(FilePath))
            File.WriteAllText(FilePath, JsonConvert.SerializeObject(new Settings(), Formatting.Indented));

        Settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(FilePath));
    }
}

internal class Settings
{
    /// <summary>
    /// OpenWeatherMap api key
    /// </summary>
    public string ApiKey { get; set; }
    
    /// <summary>
    /// Time to wait (in seconds) before re-checking weather
    /// </summary>
    public int TimeDelay { get; set; } = 600;
}
