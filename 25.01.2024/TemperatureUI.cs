using TMPro;
using UnityEngine;

public class TemperatureUI : MonoBehaviour
{
    public TemperaturePlayer temperaturePlayer;
    public TextMeshProUGUI temperatureText;

    void Update()
    {
        float roundedTemperature = Mathf.Round(temperaturePlayer.GetCurrentTemperature() * 10.0f) * 0.1f;
        temperatureText.text = roundedTemperature.ToString();
    }
}
