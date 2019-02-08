using UnityEngine;
using UnityEngine.UI;
using WeatherSystem.ResultModels;

namespace UiHelpers
{
    public class CurrentConditionsHelper : MonoBehaviour
    {
        [SerializeField] private Text cityName;
        
        public void ChangeData(CurrentWeatherResult data)
        {
            cityName.text = data.Name;
        }
    }

}
