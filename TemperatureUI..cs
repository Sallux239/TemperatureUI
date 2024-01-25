using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temperature:MonoBehaviour
{
   public Temperature playerTemperature;
   public TextMeshProUGUI temperaturaText;
   public void UpdateTemperaturaText()
    {

      float roundTemperature = Mathf.Round(playerTemperature.CurrentTemperature * 10.0f) * 0.1f;
        temperaturaText.text = roundTemperature.ToString();
    }
}
