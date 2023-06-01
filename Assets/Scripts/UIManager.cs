using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static ChickenManager;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> chickenBoxes = new List<GameObject>();


    [SerializeField]
    TMP_Text _eggsText;
    public TMP_Text EggsText { get; set; }

    [SerializeField]
    TMP_Text _energyText;

    public TMP_Text EnergyText { get; set; }

    [SerializeField]
    TMP_Text _maxEnergyText;

    public TMP_Text MaxEnegryText { get; set; }


    [SerializeField]
    TMP_Text _timeField;

    public TMP_Text TimeField { get; set; }

    private void OnLevelWasLoaded(int level)
    {
        for (int i = 0; i <= ((int)ChickenTypes.NumberOfTypes); i++)
        {
            for (int j = 0; j < chickenBoxes.Count - totalPlayerChickens[(ChickenTypes)i]; j++)
            {
                InstantiateChickenOfType((ChickenTypes)i);
            }
        }
    }

    private void InstantiateChickenOfType(ChickenTypes chickenType)
    {
        switch (chickenType)
        {
            case ChickenTypes.SheetChicken:
                Instantiate(chickenBoxes[(int)ChickenTypes.SheetChicken]);
                break;
                default:
                break;
        }
    }

    private void Start()
    {
        UpdateEggsText(GameManager.TotalEggs);
        UpdateEnergyText(PlayerStats.CurrentEnergy);
        SetMaximumEnergyUI(PlayerStats.MaxEnergy);
    }
    public void UpdateEggsText(int value)
    {
        _eggsText.text = value.ToString();
    }
    
    public void UpdateEnergyText(int value)
    {
        _energyText.text = value.ToString();
    }

    public void SetMaximumEnergyUI(int value)
    {
        _maxEnergyText.text = PlayerStats.MaxEnergy.ToString();
    }

    public void SetTime(DateTime time)
    {
        _timeField.text = time.ToString();
    }
}
