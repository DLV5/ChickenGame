using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChickenManager : MonoBehaviour
{
    public static Dictionary<ChickenTypes, int> totalPlayerChickens  = new Dictionary<ChickenTypes, int>();

    public enum ChickenTypes 
    {
        SheetChicken,
        AnotherChicken,
        NumberOfTypes
    }

    private void OnLevelWasLoaded(int level)
    {
        for (int i = 0; i <= ((int)ChickenTypes.NumberOfTypes); i++)
        {
            totalPlayerChickens[(ChickenTypes)i] = PlayerPrefs.GetInt(((ChickenTypes)i).ToString());
        }
    }
    [SerializeField]
    public void AddChicken(ChickenTypes chickenType)
    {
        switch (chickenType) {
            case ChickenTypes.SheetChicken:
                PlayerPrefs.SetInt(ChickenTypes.SheetChicken.ToString(), totalPlayerChickens[ChickenTypes.SheetChicken] + 1);
                break;
            default: 
                break;
        }
    }
}
