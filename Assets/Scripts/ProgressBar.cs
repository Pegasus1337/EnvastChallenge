using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; 

public class ProgressBar : MonoBehaviour
{
    public TextMeshProUGUI ProgressText; 

    public Slider slider; 
    void Start()
    {
        slider.maxValue = 100;
        slider.value = Manager.RoundNumber * 10;
        ProgressText.SetText(slider.value.ToString() + " %");
    }
    
}
