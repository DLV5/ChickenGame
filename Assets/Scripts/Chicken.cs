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

    private void Start()
    {
        StartCoroutine(PassiveIncome());
    }
    public void ChangeEggValue()
    {
        if(PlayerStats.CurrentEnergy > 0) // CHANGE LATER
        {
            GameManager.TotalEggs += _eggActiveIncome;
            ChangeEnergyValue(-1);// THIS IS TOO
        }
        GameManager.manager.UpdateEggsText(GameManager.TotalEggs);
    }
    private void ChangeEnergyValue(int value)
    {
        PlayerStats.CurrentEnergy += value;
        GameManager.manager.UpdateEnergyText(PlayerStats.CurrentEnergy);
    }

    IEnumerator PassiveIncome()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            GameManager.TotalEggs += _eggActiveIncome;
            GameManager.manager.UpdateEggsText(GameManager.TotalEggs);
        }


    }

}
