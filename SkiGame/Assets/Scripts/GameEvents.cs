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
}
