using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CheatScript : MonoBehaviour
{
    public float Money;
    public TextMeshProUGUI MoneyText;

    public void DeletSave ()
    {
        PlayerPrefs.DeleteAll();
    }

    public void PlusMoney ()
    {
        Money += 100000000;
        PlayerPrefs.SetFloat("Money",Money);
    }

    public void ChangeScene ()
    {

    }

    private void Update ()
    {
        Money = PlayerPrefs.GetFloat("Money");  

        if (Money < 1000){
        MoneyText.text = "Military Funds " + Money.ToString () + "$";
        }
        if (Money >= 1000){  
        MoneyText.text = "Military Funds " + (Money / 1000).ToString ("f3") + " Thoushand $";
        }
        if (Money >= 1000000){  
        MoneyText.text = "Military Funds " + (Money / 1000000).ToString ("f3") + " Million $";
        } 
        if (Money >= 1000000000){  
        MoneyText.text = "Military Funds " + (Money / 1000000000).ToString ("f3") + " Milliard $";
        }
    }
}



