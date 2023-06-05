using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenManager : MonoBehaviour
{
    public static Dictionary<ChickenTypes, int> totalPlayerChickens  = new Dictionary<ChickenTypes, int>();

    public GameObject chickenPrefab;

    public enum ChickenTypes 
    {
        SheetChicken,
        NumberOfTypes
    }


    private void Start()
    {               
        for (int i = 0; i <= ((int)ChickenTypes.NumberOfTypes); i++)
        {
            if (PlayerPrefs.GetInt(((ChickenTypes)i).ToString()) == null)
            {
                PlayerPrefs.SetInt(((ChickenTypes)i).ToString(), 1);
                totalPlayerChickens[(ChickenTypes)i] = PlayerPrefs.GetInt(((ChickenTypes)i).ToString());
                Debug.Log("Error was catched");
            } else
            {
                totalPlayerChickens[(ChickenTypes)i] = PlayerPrefs.GetInt(((ChickenTypes)i).ToString());
            }          
        }
    }
    public void AddChicken()
    {
        ChickenTypes chickenType = ChickenTypes.SheetChicken;
        switch (chickenType) {
            case ChickenTypes.SheetChicken:
                //if (PlayerPrefs.HasKey(ChickenTypes.SheetChicken.ToString())){
                //    PlayerPrefs.DeleteKey(ChickenTypes.SheetChicken.ToString());
                //}
                //PlayerPrefs.SetInt(ChickenTypes.SheetChicken.ToString(), totalPlayerChickens[ChickenTypes.SheetChicken] + 1);
                GameObject inst = Instantiate(chickenPrefab, transform.position, Quaternion.identity);
                inst.transform.SetParent(transform, false);
                break;
            default: 
                break;
        }
        PlayerPrefs.Save();
    }

    public void BuyChicken(int cost) {
                //Debug.Log(UIManager.instance.chickenBoxes[0]);
        if(cost > GameManager.TotalEggs)
        {
            return;
        }
        AddChicken();
        GameManager.TotalEggs -= cost;
        UIManager.instance.UpdateEggsText(GameManager.TotalEggs);
    }
}
