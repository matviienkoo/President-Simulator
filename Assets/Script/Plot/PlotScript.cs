using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlotScript : MonoBehaviour
{
    public GameObject Transtion_Object;
    public Animation Transtion_Animation;

    public string NumPlot;
    public int Int_Reputation;
    public int Int_Promotion;

    public void FirstChoise ()
    {
        // Переход на сцену последствий
        Transtion_Object.SetActive(true);
        Transtion_Animation.Play("transtion");

        if (NumPlot == "Начало Войны")
        {
            Int_Promotion = 1;
            Int_Reputation += 1;
        }
    }

    


}