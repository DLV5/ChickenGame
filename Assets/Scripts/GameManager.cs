using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int TotalEggs = 0;
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
}
