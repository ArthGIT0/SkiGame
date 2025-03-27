using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public delegate void RaceEvents();

    public static event RaceEvents raceStart;
    public static event RaceEvents raceEnd;
    public static event RaceEvents racePenalty;

    public static void CallRaceStart()
    {
        if (raceStart != null)
            raceStart();
    }

    public static void CallRaceFinish()
    {
        if (raceEnd != null)
            raceEnd();
    }
    
    public static void CallRacePenalty()
    {
        if (racePenalty != null)
            racePenalty();
    }
}
