using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public float WaitingTime;
    float Timer;
    void Start()
    {

        WaitingTime = 3.0f;
       // WaitngTime(WaitingTime);
    }

    public void WaitngTime(float waitingtime)
    {
        for (Timer =0.0f; Timer <= WaitingTime; Timer += Time.deltaTime)
        {
            Debug.Log(Timer + "ÃÊ");
        }
        if (Timer >= waitingtime)
        {
            Timer = 0;
        }

    }
    void Update()
    {

    }
}
