using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenManager : MonoBehaviour
{
    public static Dictionary<ChickenTypes, int> totalPlayerChickens  = new Dictionary<ChickenTypes, int>();

    public GameObject chickenPrefab;

    private static int cost = 1;

    public enum ChickenTypes 
    {
        SheetChicken,
        NumberOfTypes
    }


    private void Start()
    {               
        for (int i = 0; i <= ((int)ChickenTypes.NumberOfTypes); i++)
        {        
                totalPlayerChickens[(ChickenTypes)i] = PlayerPrefs.GetInt(((ChickenTypes)i).ToString());                    
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

    public void BuyChicken() {
                //Debug.Log(UIManager.instance.chickenBoxes[0]);
        if(cost > GameManager.TotalEggs)
        {
            return;
        }
        AddChicken();
        GameManager.TotalEggs -= cost;
        UIManager.instance.UpdateEggsText(GameManager.TotalEggs);
        cost += Convert.ToInt32(cost * 0.1) + 10;
        UIManager.instance.UpdatePriceText(cost);
    }
}
