using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public static float currentTime = 0f;
    private float startingTime = 60f;

    public Transform LoadingBar;
    public TextMeshProUGUI TimerText;


    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        
    }

    // Update is called once per frame
    void Update()
    {

        CountdownTimer.currentTime -= 1f * Time.deltaTime;
        if(CountdownTimer.currentTime < 0f)
        {
            CountdownTimer.currentTime = 0f;
 
        }
        LoadingBar.GetComponent<Image>().fillAmount = (startingTime - CountdownTimer.currentTime) / startingTime;
        TimerText.SetText(CountdownTimer.currentTime.ToString("0"));


    
    }
}
