using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LawsScript : MonoBehaviour{

[Header("Закон")]
public TextMeshProUGUI NumberText;
public TextMeshProUGUI LawsText;

public Animation Book_Animation;
public bool Book_Bool = false;

[Header("Подтвердить документ")]
public Sprite SelectionAgree;
public Button ButtonAgree;
public Animation Agree_Animation;
public bool Agree_Bool = false;

[Header("Запрепить документ")]
public Sprite SelectionDisable;
public Button ButtonDisable;
public Animation Disable_Animation;
public bool Disable_Bool = false;

[Header("Печать")]
public GameObject SelectionObject;
public bool Laws_Bool = false;

private float Timer;
private int SelectionInt;

private void Start ()
{
    Laws_Changes();
}

public void Agree_Document ()
{
    Agree_Animation.Play();
    ButtonAgree.enabled = false;
    ButtonDisable.enabled = false;

    Agree_Bool = true;
    Laws_Bool = true;
}

public void Disable_Document ()
{
    Disable_Animation.Play();
    ButtonAgree.enabled = false;
    ButtonDisable.enabled = false;

    Disable_Bool = true;
    Laws_Bool = true;
}

private void Laws_Changes ()
{
    if (SelectionInt == 0){
    NumberText.text = "*234*";
    LawsText.text = "On raising MPs' salaries";
    }

    if (SelectionInt == 1){
    NumberText.text = "*134*";
    LawsText.text = "Про підвищені податкив";
    }
}

    private void Update ()
    {
        // Поставка печати, и включение анимации смены книги
        if (Laws_Bool == true)
        {
            Timer += Time.deltaTime;
            if (Timer >= 0.40)
            {
                if (Agree_Bool == true){
                SelectionObject.GetComponent<Image>().sprite = SelectionAgree;
                SelectionObject.SetActive(true);
                }

                if (Disable_Bool == true){
                SelectionObject.GetComponent<Image>().sprite = SelectionDisable;
                SelectionObject.SetActive(true);
                }

            }

            if (Timer >= 1.25)
            {
                Laws_Bool = false;
                Agree_Bool = false;
                Disable_Bool = false;
                Timer = 0;

                Book_Animation.Play();
                Book_Bool = true;

                SelectionInt += 1;
            }
        }

        // Изменение надписи, и предоставление новой книги
        if (Book_Bool == true)
        {
            Timer += Time.deltaTime;
            if (Timer >= 0.30)
            {
                SelectionObject.SetActive(false);
                Laws_Changes();
            }

            if (Timer >= 1)
            {
                Book_Bool = false;
                Timer = 0;

                ButtonAgree.enabled = true;
                ButtonDisable.enabled = true;
            }
        }
    }
}
