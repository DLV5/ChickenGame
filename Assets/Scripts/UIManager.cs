using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    List<GameObject> chickenBoxes = new List<GameObject>();
    [SerializeField]
    TMP_Text _eggsText;
    
    [SerializeField]
    TMP_Text _energyText;
    
    [SerializeField]
    TMP_Text _maxEnergyText;

    void Start()
    {
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
}
