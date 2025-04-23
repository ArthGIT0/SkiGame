using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTimer : MonoBehaviour
{
    [SerializeField] private float penaltyTime = 1;
    
    private bool timerRunning = false;
    private float raceTime = 0;

    private void OnEnable()
    {
        GameEvents.raceStart += startRace;
        GameEvents.raceEnd += FinishRace;
        GameEvents.racePenalty += Penalty;
    }

    private void Penalty()
    {
        raceTime += penaltyTime;
        Debug.Log("penalty recieved");
    }

    public void OnDisable()
    {
        GameEvents.raceStart -= startRace;
        GameEvents.raceEnd -= FinishRace;
        GameEvents.racePenalty -= Penalty;
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
        Debug.Log("race time: " + raceTime);
    }
}