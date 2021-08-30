using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool timerIsActive = true;

    private float startTime;
    public float remainingTime;
    public float stoppingTime = 0;

    public Text timerText;

    void Start()
    {
        
    }
    public void SetTimerLength(float timerLength)
    {
        startTime = timerLength;
    }

    public void BeginCountdown()
    {
        remainingTime = startTime;
        timerIsActive = true;

        while (remainingTime >= stoppingTime && timerIsActive)
        {
            remainingTime -= Time.deltaTime;
        }
    }

    public void ResetTimer()
    {
        timerIsActive = false;
        remainingTime = startTime;
    }

    public void DisplayTime(float displayedTime)
    {
        float minutes = Mathf.FloorToInt(displayedTime / 60); // these two lines came
        float seconds = Mathf.FloorToInt(displayedTime % 60); // courtesy of Game Dev Beginner ;p

        timerText.text = minutes + ":" + seconds ;
    }
}
