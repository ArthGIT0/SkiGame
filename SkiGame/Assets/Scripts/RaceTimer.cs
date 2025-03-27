using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTimer : MonoBehaviour
{
    private bool timerRunning = false;

    private void OnEnable()
    {
        GameEvents.raceStart += startRace;
        GameEvents.raceEnd += FinishRace;
    }

    public void OnDisable()
    {
        GameEvents.raceStart -= startRace;
        GameEvents.raceEnd -= FinishRace;
    }


    public void startRace()
    {
        timerRunning = true;
        Debug.Log("Race Start");
    }

    public void FinishRace()
    {
        timerRunning = false;
        Debug.Log("Race end");
    }
}
