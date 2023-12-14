using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cliking_system : MonoBehaviour
{

public string language;

// деньги
public float money;
public Text money_text;

public float bonus_money;

// анимация
public Animator anim;

// эффект энергетика
public int energy_effect;

// система подсчета кликов
public float clicksPerSecond;
float splif_timer;


// основная кнопка (нажатие на чмоню)
public void main_button (float value)
{
    // ограничение на количество кликов
    if(Input.touchCount < 7) {

    money += bonus_money;

    if (energy_effect == 0){
    clicksPerSecond += 1;
    anim.SetBool("Click_Normal", true);
    }

    if (energy_effect == 1){
    clicksPerSecond += 1;
    anim.SetBool("Click_Energetik", true);
    }

    PlayerPrefs.SetFloat("money", money);
    PlayerPrefs.SetFloat("bonus_money", bonus_money);

    }
}

public void DeletSave ()
{
    PlayerPrefs.DeleteAll();
}

public void plus_mnoho_deneh ()
{
   money += 100000000; 
   PlayerPrefs.SetFloat("money", money);
}

// ---------------UPDATE------------------- 

void Update ()
{
    language = PlayerPrefs.GetString("Lang");
        
    money = PlayerPrefs.GetFloat("money");
    bonus_money = PlayerPrefs.GetFloat("bonus_money"); 

    energy_effect = PlayerPrefs.GetInt("energy_effect");

    if (bonus_money <= 0){
        bonus_money = 10;
        PlayerPrefs.SetFloat("bonus_money", bonus_money);
    }

    // СИСТЕМА КЛИКОВ
    splif_timer += Time.deltaTime; 
    if (clicksPerSecond >= 1){ 
    if (splif_timer >= 0.3)
    {
        clicksPerSecond -= 1;
        splif_timer = 0;
    }
    }

    if (clicksPerSecond >= 2)
    {
        clicksPerSecond = 2;
    }

    if (clicksPerSecond == 0)
    {
        anim.SetBool("Click_Normal", false);
        anim.SetBool("Click_Energetik", false);
    }

    // СИСТЕМА ДЕНЕГ
    if(language == "" || language == "eng")
    {
        if (money < 1000){
        money_text.text =  money.ToString () + " hryvnia";
        }
        if (money >= 1000){  
        money_text.text =  (money / 1000).ToString ("f3") + "k hryvnia";
        }
        if (money >= 1000000){  
        money_text.text =  (money / 1000000).ToString ("f3") + "m hryvnia";
        }
        if (money >= 1000000000){  
        money_text.text =  (money / 1000000000).ToString ("f3") + "b hryvnia";
        }
    }
    if (language == "Rus")
    {
        if (money < 1000){
        money_text.text =  money.ToString () + " гривен";
        }
        if (money >= 1000){  
        money_text.text =  (money / 1000).ToString ("f3") + "к гривен";
        }
        if (money >= 1000000){  
        money_text.text =  (money / 1000000).ToString ("f3") + "м гривен";
        }
        if (money >= 1000000000){  
        money_text.text =  (money / 1000000000).ToString ("f3") + "млрд. гривен";
        }
    }
    if (language == "UA")
    {
        if (money < 1000){
        money_text.text =  money.ToString () + " гривень";
        }
        if (money >= 1000){  
        money_text.text =  (money / 1000).ToString ("f3") + "к гривень";
        }
        if (money >= 1000000){  
        money_text.text =  (money / 1000000).ToString ("f3") + "м гривень";
        }
        if (money >= 1000000000){  
        money_text.text =  (money / 1000000000).ToString ("f3") + "млрд. гривень";
        }
    } 
    if(language == "De")
    {
        if (money < 1000){
        money_text.text =  money.ToString () + " hryvnia";
        }
        if (money >= 1000){  
        money_text.text =  (money / 1000).ToString ("f3") + "k hryvnia";
        }
        if (money >= 1000000){  
        money_text.text =  (money / 1000000).ToString ("f3") + "m hryvnia";
        }
        if (money >= 1000000000){  
        money_text.text =  (money / 1000000000).ToString ("f3") + "b hryvnia";
        }
    }
    if(language == "Pl")
    {
        if (money < 1000){
        money_text.text =  money.ToString () + " hryvnia";
        }
        if (money >= 1000){  
        money_text.text =  (money / 1000).ToString ("f3") + "k hryvnia";
        }
        if (money >= 1000000){  
        money_text.text =  (money / 1000000).ToString ("f3") + "m hryvnia";
        }
        if (money >= 1000000000){  
        money_text.text =  (money / 1000000000).ToString ("f3") + "b hryvnia";
        }
    }

// конец Update
}
}
