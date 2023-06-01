using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats
{
    public static int MaxEnergy {get; set;} = 10;
    private static int currentEnergy = 10;
    public static int CurrentEnergy { get => currentEnergy; set { if (currentEnergy + value > 0) currentEnergy = value; } }
    public static int CurrentLevel {get; set;} = 10;
}
