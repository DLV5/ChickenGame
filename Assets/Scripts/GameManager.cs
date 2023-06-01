using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Numerics;
using UnityEngine;
using UnityEngine.Networking;

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

    public IEnumerator GetInternetTime()
    {
        UnityWebRequest myHttpWebRequest = UnityWebRequest.Get("http://www.microsoft.com");
        yield return myHttpWebRequest.Send();

        string netTime = myHttpWebRequest.GetResponseHeader("date");
        Debug.Log(netTime + " was response");
    }
}
