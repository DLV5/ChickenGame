using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
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

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateEggsText(BigInteger value)
    {
            if (_eggsText != null)
        {
            _eggsText.text = value.ToString();
        }
    }
    
    public void UpdateEnergyText(BigInteger value)
    {
            if (_energyText != null)
        {
            _energyText.text = value.ToString();
        }
    }

    public void SetMaximumEnergyUI(BigInteger value)
    {
        if (_energyText != null)
        {
            _maxEnergyText.text = PlayerStats.MaxEnergy.ToString();
        }

    }
}
