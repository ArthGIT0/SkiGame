using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTimer : MonoBehaviour
{
    [SerializeField] private float penaltyTime = 1;
    
    private bool timerRunning = false;
    private float raceTime = 0;
    [SerializeField] private Leaderboard leaderboard;

    private void OnEnable()
    {
        GameManger.RaceStart += startRace;
        GameManger.RaceFinish += FinishRace;
        GameManger.RacePenalty += Penalty;
    }

    private void Penalty()
    {
        raceTime += penaltyTime;
        Debug.Log("penalty recieved");
    }

    public void OnDisable()
    {
        GameManger.RaceStart -= startRace;
        GameManger.RaceFinish -= FinishRace;
        GameManger.RacePenalty -= Penalty;
    }


    public void startRace()
    {
        raceTime = 0;
        timerRunning = true;
        Debug.Log("Race Start");
    }

    public void FinishRace()
    {
        timerRunning = false;
        leaderboard.AddTime(raceTime);
        GameData.Instance.racesCompleted++;
        Debug.Log("Race end" + GameData.Instance.racesCompleted);
        Debug.Log("race time: " + raceTime);
    }

    private void Update()
    {
        if (timerRunning)
            raceTime += Time.deltaTime;
    }
}