using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public bool timerIsActive = true;

    private float initialTime;
    public float remainingTime;
    public float stoppingTime = 0;


    void Start()
    {
        
    }
    
    public void BeginCountdown()
    {
        timerIsActive = true;
        while (remainingTime >= stoppingTime && timerIsActive)
        {
            remainingTime -= Time.deltaTime;
        }

    }

    public void ResetTimer()
    {
        timerIsActive = false;
        remainingTime = initialTime;
    }
}
