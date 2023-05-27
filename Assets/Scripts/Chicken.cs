using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class Chicken : MonoBehaviour
{
   [SerializeField]
   private int _eggActiveIncome;
   public int EggActiveIncome { get { return _eggActiveIncome; } set { _eggActiveIncome = value; } }

   [SerializeField]
   private int _eggPassiveIncome;
   public int EggPassiveIncome { get { return _eggPassiveIncome;} set { _eggPassiveIncome = value;} }

    public void ChangeEggValue()
    {
        GameManager.TotalEggs += _eggActiveIncome;
        ChangeEnergyValue(-1);
        GameManager.manager.UpdateEggsText(GameManager.TotalEggs);
    }
    private void ChangeEnergyValue(int value)
    {
        PlayerStats.CurrentEnergy += value;
        GameManager.manager.UpdateEnergyText(PlayerStats.CurrentEnergy);
    }

}
