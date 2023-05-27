using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static BigInteger TotalEggs = 0;
    static PlayerStats playerStats;
    public static GameManager instance;
    public static UIManager manager;
    public GameManager() { 
        instance = this;
    }
    static GameManager()
    {
        playerStats = new PlayerStats();
    }
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();       
    }



    public void AddEgg()
    {
        TotalEggs += 1;
        manager.UpdateEggsText(TotalEggs);
    }
}
