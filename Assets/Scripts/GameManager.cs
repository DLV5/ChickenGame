using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static BigInteger TotalEggs = 0;
    public static GameManager instance;
    public static UIManager manager;
    public GameManager() { 
        instance = this;
    }
    static GameManager()
    {
    }
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();       
    }



    public void AddEgg(int eggValue)
    {
        if (eggValue < 0) { throw new System.ArgumentOutOfRangeException("value"); }

        TotalEggs += eggValue;
        RemoveEnergy(1);
        manager.UpdateEggsText(TotalEggs);
    }

    public void RemoveEgg(int value)
    {
        if (value < 0) { throw new System.ArgumentOutOfRangeException("value"); }
        TotalEggs -= value;
        manager.UpdateEggsText(TotalEggs);
    }
    public void AddEnergy(int value)
    {
        if(value < 0) { throw new System.ArgumentOutOfRangeException("value"); }
        PlayerStats.CurrentEnergy += value;
        manager.UpdateEnergyText(PlayerStats.CurrentEnergy);
    }

    public void RemoveEnergy(int value)
    {
        if (value < 0) { throw new System.ArgumentOutOfRangeException("value"); }
        PlayerStats.CurrentEnergy -= value;
        manager.UpdateEnergyText(PlayerStats.CurrentEnergy);
    }


}
