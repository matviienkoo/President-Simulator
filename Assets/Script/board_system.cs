using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class board_system : MonoBehaviour {

public string language;

// деньги
public float money;
public float bonus_money;
public Text money_text;

// цена
public float price_bottle;
public Text price_bottle_text;

public float price_metalolom;
public Text price_metalolom_text;

public float price_nafta;
public Text price_nafta_text;

public float price_sklad;
public Text price_sklad_text;

public float price_airdrom;
public Text price_airdrom_text;

public float price_war;
public Text price_war_text;

// прогресс для прокачки
public GameObject img_progress_1_bottle;
public GameObject img_progress_2_bottle;
public GameObject img_progress_3_bottle;
public GameObject img_progress_4_bottle;
public GameObject img_progress_5_bottle;
public GameObject img_progress_6_bottle;
public GameObject img_progress_7_bottle;
public GameObject img_progress_8_bottle;

public GameObject img_progress_1_metalolom;
public GameObject img_progress_2_metalolom;
public GameObject img_progress_3_metalolom;
public GameObject img_progress_4_metalolom;
public GameObject img_progress_5_metalolom;
public GameObject img_progress_6_metalolom;
public GameObject img_progress_7_metalolom;
public GameObject img_progress_8_metalolom;

public GameObject img_progress_1_nafta;
public GameObject img_progress_2_nafta;
public GameObject img_progress_3_nafta;
public GameObject img_progress_4_nafta;
public GameObject img_progress_5_nafta;
public GameObject img_progress_6_nafta;
public GameObject img_progress_7_nafta;
public GameObject img_progress_8_nafta;

public GameObject img_progress_1_sklad;
public GameObject img_progress_2_sklad;
public GameObject img_progress_3_sklad;
public GameObject img_progress_4_sklad;
public GameObject img_progress_5_sklad;
public GameObject img_progress_6_sklad;
public GameObject img_progress_7_sklad;
public GameObject img_progress_8_sklad;

public GameObject img_progress_1_airdrom;
public GameObject img_progress_2_airdrom;
public GameObject img_progress_3_airdrom;
public GameObject img_progress_4_airdrom;
public GameObject img_progress_5_airdrom;
public GameObject img_progress_6_airdrom;
public GameObject img_progress_7_airdrom;
public GameObject img_progress_8_airdrom;

public GameObject img_progress_1_war;
public GameObject img_progress_2_war;
public GameObject img_progress_3_war;
public GameObject img_progress_4_war;
public GameObject img_progress_5_war;
public GameObject img_progress_6_war;
public GameObject img_progress_7_war;
public GameObject img_progress_8_war;

public int int_progress_bottle;
public int int_progress_metalolom;
public int int_progress_nafta;
public int int_progress_sklad;
public int int_progress_airdrom;
public int int_progress_war;

// анимация при отсутствие денег
public Animation Dont_have_money_anim;

// ПЕРВАЯ ДОСКА
public void board_bottle ()
{
	if (int_progress_bottle < 8){
	if (price_bottle > money){
        Dont_have_money_anim.Play();
    }
	}

	if (int_progress_bottle < 8){
	if (money >= price_bottle) 
	{
		money -= price_bottle;
		int_progress_bottle += 1;
		bonus_money += 10;

		PlayerPrefs.SetFloat("price_bottle", price_bottle);
		PlayerPrefs.SetFloat("money", money);
		PlayerPrefs.SetFloat("bonus_money", bonus_money);
		PlayerPrefs.SetInt ("int_progress_bottle", int_progress_bottle);
	}
	}
}

// ВТОРАЯ ДОСКА
public void board_metalolom ()
{
	if (int_progress_metalolom < 8){
	if (price_metalolom > money){
        Dont_have_money_anim.Play();
    }
	}

	if (int_progress_metalolom < 8){
	if (money >= price_metalolom) 
	{
		money -= price_metalolom;
		int_progress_metalolom += 1;
		bonus_money += 50;

		PlayerPrefs.SetFloat("price_metalolom", price_metalolom);
		PlayerPrefs.SetFloat("money", money);
		PlayerPrefs.SetFloat("bonus_money", bonus_money);
		PlayerPrefs.SetInt ("int_progress_metalolom", int_progress_metalolom);
	}
	}
}

// ТРЕТЬЯ ДОСКА
public void board_nafta ()
{
	if (int_progress_nafta < 8){
	if (price_nafta > money){
        Dont_have_money_anim.Play();
    }
	}

	if (int_progress_nafta < 8){
	if (money >= price_nafta) 
	{
		money -= price_nafta;
		int_progress_nafta += 1;
		bonus_money += 200;

		PlayerPrefs.SetFloat("price_nafta", price_nafta);
		PlayerPrefs.SetFloat("money", money);
		PlayerPrefs.SetFloat("bonus_money", bonus_money);
		PlayerPrefs.SetInt ("int_progress_nafta", int_progress_nafta);
	}
	}
}

// ЧЕТВЕРТАЯ ДОСКА
public void board_sklad ()
{
	if (int_progress_sklad < 8){
	if (price_sklad > money){
        Dont_have_money_anim.Play();
    }
	}

	if (int_progress_sklad < 8){
	if (money >= price_sklad) 
	{
		money -= price_sklad;
		int_progress_sklad += 1;
		bonus_money += 650;

		PlayerPrefs.SetFloat("price_sklad", price_sklad);
		PlayerPrefs.SetFloat("money", money);
		PlayerPrefs.SetFloat("bonus_money", bonus_money);
		PlayerPrefs.SetInt ("int_progress_sklad", int_progress_sklad);
	}
	}
}

// ПЬЯТАЯ ДОСКА
public void board_airdrom ()
{
	if (int_progress_airdrom < 8){
	if (price_airdrom > money){
        Dont_have_money_anim.Play();
    }
	}

	if (int_progress_airdrom < 8){
	if (money >= price_airdrom) 
	{
		money -= price_airdrom;
		int_progress_airdrom += 1;
		bonus_money += 2500;

		PlayerPrefs.SetFloat("price_airdrom", price_airdrom);
		PlayerPrefs.SetFloat("money", money);
		PlayerPrefs.SetFloat("bonus_money", bonus_money);
		PlayerPrefs.SetInt ("int_progress_airdrom", int_progress_airdrom);
	}
	}
}

// ШЕСТАЯ ДОСКА
public void board_war ()
{
	if (int_progress_war < 8){
	if (price_war > money){
        Dont_have_money_anim.Play();
    }
	}
	
	if (int_progress_war < 8){
	if (money >= price_war) 
	{
		money -= price_war;
		int_progress_war += 1;
		bonus_money += 8500;

		PlayerPrefs.SetFloat("price_war", price_war);
		PlayerPrefs.SetFloat("money", money);
		PlayerPrefs.SetFloat("bonus_money", bonus_money);
		PlayerPrefs.SetInt ("int_progress_war", int_progress_war);
	}
	}
}

//  --- UPDATE ---
void Update ()
{
	language = PlayerPrefs.GetString("Lang");
	money = PlayerPrefs.GetFloat("money");  
	bonus_money = PlayerPrefs.GetFloat("bonus_money"); 

	int_progress_bottle = PlayerPrefs.GetInt("int_progress_bottle");
	int_progress_metalolom = PlayerPrefs.GetInt("int_progress_metalolom");
	int_progress_nafta = PlayerPrefs.GetInt("int_progress_nafta");
	int_progress_sklad = PlayerPrefs.GetInt("int_progress_sklad");
	int_progress_airdrom = PlayerPrefs.GetInt("int_progress_airdrom");
	int_progress_war = PlayerPrefs.GetInt("int_progress_war");

	// ЦЕНА ПРОКАЧКИ
	if (int_progress_bottle < 8){

	price_bottle = PlayerPrefs.GetFloat("price_bottle"); 

		if(language == "" || language == "eng")
		{
			if (price_bottle < 1000){
    		price_bottle_text.text =  "price " + price_bottle.ToString () + " hryvnia";
    		}
    		if (price_bottle >= 1000){  
    		price_bottle_text.text =  "price " + (price_bottle / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_bottle >= 1000000){  
    		price_bottle_text.text =  "price " + (price_bottle / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if (language == "Rus")
		{
			if (price_bottle < 1000){
    		price_bottle_text.text =  "цена " + price_bottle.ToString () + " гривен";
    		}
    		if (price_bottle >= 1000){  
    		price_bottle_text.text =  "цена " + (price_bottle / 1000).ToString ("f3") + "к гривен";
    		}
    		if (price_bottle >= 1000000){  
    		price_bottle_text.text =  "цена " + (price_bottle / 1000000).ToString ("f3") + "м гривен";
    		} 
    	}
    	if (language == "UA")
    	{
    		if (price_bottle < 1000){
    		price_bottle_text.text =  "ціна " + price_bottle.ToString () + " гривень";
    		}
    		if (price_bottle >= 1000){  
    		price_bottle_text.text =  "ціна " + (price_bottle / 1000).ToString ("f3") + "к гривень";
    		}
    		if (price_bottle >= 1000000){  
    		price_bottle_text.text =  "ціна " + (price_bottle / 1000000).ToString ("f3") + "м гривень";
    		} 
    	}
    	if(language == "Pl")
		{
			if (price_bottle < 1000){
    		price_bottle_text.text =  "price " + price_bottle.ToString () + " hryvnia";
    		}
    		if (price_bottle >= 1000){  
    		price_bottle_text.text =  "price " + (price_bottle / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_bottle >= 1000000){  
    		price_bottle_text.text =  "price " + (price_bottle / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if(language == "De")
		{
			if (price_bottle < 1000){
    		price_bottle_text.text =  "price " + price_bottle.ToString () + " hryvnia";
    		}
    		if (price_bottle >= 1000){  
    		price_bottle_text.text =  "price " + (price_bottle / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_bottle >= 1000000){  
    		price_bottle_text.text =  "price " + (price_bottle / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}

	}
	if (int_progress_metalolom < 8){

	price_metalolom = PlayerPrefs.GetFloat("price_metalolom"); 

		if(language == "" || language == "eng")
		{
			if (price_metalolom < 1000){
    		price_metalolom_text.text =  "price " + price_metalolom.ToString () + " hryvnia";
    		}
    		if (price_metalolom >= 1000){  
    		price_metalolom_text.text =  "price " + (price_metalolom / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_metalolom >= 1000000){  
    		price_metalolom_text.text =  "price " + (price_metalolom / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if (language == "Rus")
		{
			if (price_metalolom < 1000){
    		price_metalolom_text.text =  "цена " + price_metalolom.ToString () + " гривен";
    		}
    		if (price_metalolom >= 1000){  
    		price_metalolom_text.text =  "цена " + (price_metalolom / 1000).ToString ("f3") + "к гривен";
    		}
    		if (price_metalolom >= 1000000){  
    		price_metalolom_text.text =  "цена " + (price_metalolom / 1000000).ToString ("f3") + "м гривен";
    		} 
    	}
    	if (language == "UA")
    	{
			if (price_metalolom < 1000){
    		price_metalolom_text.text =  "ціна " + price_metalolom.ToString () + " гривень";
    		}
    		if (price_metalolom >= 1000){  
    		price_metalolom_text.text =  "ціна " + (price_metalolom / 1000).ToString ("f3") + "к гривень";
    		}
    		if (price_metalolom >= 1000000){  
    		price_metalolom_text.text =  "ціна " + (price_metalolom / 1000000).ToString ("f3") + "м гривень";
    		} 
    	}
    	if(language == "Pl")
		{
			if (price_metalolom < 1000){
    		price_metalolom_text.text =  "price " + price_metalolom.ToString () + " hryvnia";
    		}
    		if (price_metalolom >= 1000){  
    		price_metalolom_text.text =  "price " + (price_metalolom / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_metalolom >= 1000000){  
    		price_metalolom_text.text =  "price " + (price_metalolom / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if(language == "De")
		{
			if (price_metalolom < 1000){
    		price_metalolom_text.text =  "price " + price_metalolom.ToString () + " hryvnia";
    		}
    		if (price_metalolom >= 1000){  
    		price_metalolom_text.text =  "price " + (price_metalolom / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_metalolom >= 1000000){  
    		price_metalolom_text.text =  "price " + (price_metalolom / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
	}

	if (int_progress_nafta < 8){

	price_nafta = PlayerPrefs.GetFloat("price_nafta");

		if(language == "" || language == "eng")
		{
			if (price_nafta < 1000){
    		price_nafta_text.text =  "price " + price_nafta.ToString () + " hryvnia";
    		}
    		if (price_nafta >= 1000){  
    		price_nafta_text.text =  "price " + (price_nafta / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_nafta >= 1000000){  
    		price_nafta_text.text =  "price " + (price_nafta / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if (language == "Rus")
		{
			if (price_nafta < 1000){
    		price_nafta_text.text =  "цена " + price_nafta.ToString () + " гривен";
    		}
    		if (price_nafta >= 1000){  
    		price_nafta_text.text =  "цена " + (price_nafta / 1000).ToString ("f3") + "к гривен";
    		}
    		if (price_nafta >= 1000000){  
    		price_nafta_text.text =  "цена " + (price_nafta / 1000000).ToString ("f3") + "м гривен";
    		} 
    	}
    	if (language == "UA")
    	{
    		if (price_nafta < 1000){
    		price_nafta_text.text =  "ціна " + price_nafta.ToString () + " гривень";
    		}
    		if (price_nafta >= 1000){  
    		price_nafta_text.text =  "ціна " + (price_nafta / 1000).ToString ("f3") + "к гривень";
    		}
    		if (price_nafta >= 1000000){  
    		price_nafta_text.text =  "ціна " + (price_nafta / 1000000).ToString ("f3") + "м гривень";
    		} 
    	}
    	if(language == "De")
		{
			if (price_nafta < 1000){
    		price_nafta_text.text =  "price " + price_nafta.ToString () + " hryvnia";
    		}
    		if (price_nafta >= 1000){  
    		price_nafta_text.text =  "price " + (price_nafta / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_nafta >= 1000000){  
    		price_nafta_text.text =  "price " + (price_nafta / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if(language == "Pl")
		{
			if (price_nafta < 1000){
    		price_nafta_text.text =  "price " + price_nafta.ToString () + " hryvnia";
    		}
    		if (price_nafta >= 1000){  
    		price_nafta_text.text =  "price " + (price_nafta / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_nafta >= 1000000){  
    		price_nafta_text.text =  "price " + (price_nafta / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
    } 

	if (int_progress_sklad < 8){

	price_sklad = PlayerPrefs.GetFloat("price_sklad");

		if(language == "" || language == "eng")
		{
			if (price_sklad < 1000){
   			price_sklad_text.text =  "price " + price_sklad.ToString () + " hryvnia";
    		}
    		if (price_sklad >= 1000){  
    		price_sklad_text.text =  "price " + (price_sklad / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_sklad >= 1000000){  
    		price_sklad_text.text =  "price " + (price_sklad / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if (language == "Rus")
		{
			if (price_sklad < 1000){
   			price_sklad_text.text =  "цена " + price_sklad.ToString () + " гривен";
    		}
    		if (price_sklad >= 1000){  
    		price_sklad_text.text =  "цена " + (price_sklad / 1000).ToString ("f3") + "к гривен";
    		}
    		if (price_sklad >= 1000000){  
    		price_sklad_text.text =  "цена " + (price_sklad / 1000000).ToString ("f3") + "м гривен";
    		} 
    	}
    	if (language == "UA")
    	{
			if (price_sklad < 1000){
   			price_sklad_text.text =  "ціна " + price_sklad.ToString () + " гривень";
    		}
    		if (price_sklad >= 1000){  
    		price_sklad_text.text =  "ціна " + (price_sklad / 1000).ToString ("f3") + "к гривень";
    		}
    		if (price_sklad >= 1000000){  
    		price_sklad_text.text =  "ціна " + (price_sklad / 1000000).ToString ("f3") + "м гривень";
    		} 
    	}
    	if(language == "Pl")
		{
			if (price_sklad < 1000){
   			price_sklad_text.text =  "price " + price_sklad.ToString () + " hryvnia";
    		}
    		if (price_sklad >= 1000){  
    		price_sklad_text.text =  "price " + (price_sklad / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_sklad >= 1000000){  
    		price_sklad_text.text =  "price " + (price_sklad / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if(language == "De")
		{
			if (price_sklad < 1000){
   			price_sklad_text.text =  "price " + price_sklad.ToString () + " hryvnia";
    		}
    		if (price_sklad >= 1000){  
    		price_sklad_text.text =  "price " + (price_sklad / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_sklad >= 1000000){  
    		price_sklad_text.text =  "price " + (price_sklad / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
	}

	if (int_progress_airdrom < 8){

	price_airdrom = PlayerPrefs.GetFloat("price_airdrom"); 

		if(language == "" || language == "eng")
		{
			if (price_airdrom < 1000){
    		price_airdrom_text.text =  "price " + price_airdrom.ToString () + " hryvnia";
    		}
    		if (price_airdrom >= 1000){  
    		price_airdrom_text.text =  "price " + (price_airdrom / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_airdrom >= 1000000){  
    		price_airdrom_text.text =  "price " + (price_airdrom / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if (language == "Rus")
		{
			if (price_airdrom < 1000){
    		price_airdrom_text.text =  "цена " + price_airdrom.ToString () + " гривен";
    		}
    		if (price_airdrom >= 1000){  
    		price_airdrom_text.text =  "цена " + (price_airdrom / 1000).ToString ("f3") + "к гривен";
    		}
    		if (price_airdrom >= 1000000){  
    		price_airdrom_text.text =  "цена " + (price_airdrom / 1000000).ToString ("f3") + "м гривен";
    		} 
    	}
    	if (language == "UA")
    	{
			if (price_airdrom < 1000){
    		price_airdrom_text.text =  "ціна " + price_airdrom.ToString () + " гривень";
    		}
    		if (price_airdrom >= 1000){  
    		price_airdrom_text.text =  "ціна " + (price_airdrom / 1000).ToString ("f3") + "к гривень";
    		}
    		if (price_airdrom >= 1000000){  
    		price_airdrom_text.text =  "ціна " + (price_airdrom / 1000000).ToString ("f3") + "м гривень";
    		} 
    	}
    	if(language == "De")
		{
			if (price_airdrom < 1000){
    		price_airdrom_text.text =  "price " + price_airdrom.ToString () + " hryvnia";
    		}
    		if (price_airdrom >= 1000){  
    		price_airdrom_text.text =  "price " + (price_airdrom / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_airdrom >= 1000000){  
    		price_airdrom_text.text =  "price " + (price_airdrom / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
		if(language == "Pl")
		{
			if (price_airdrom < 1000){
    		price_airdrom_text.text =  "price " + price_airdrom.ToString () + " hryvnia";
    		}
    		if (price_airdrom >= 1000){  
    		price_airdrom_text.text =  "price " + (price_airdrom / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_airdrom >= 1000000){  
    		price_airdrom_text.text =  "price " + (price_airdrom / 1000000).ToString ("f3") + "m hryvnia";
    		} 
		}
	}

	if (int_progress_war < 8){

	price_war = PlayerPrefs.GetFloat("price_war");

		if(language == "" || language == "eng")
		{
			if (price_war < 1000){
    		price_war_text.text =  "price " + price_war.ToString () + " hryvnia";
    		}
    		if (price_war >= 1000){  
    		price_war_text.text =  "price " + (price_war / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_war >= 1000000){  
    		price_war_text.text =  "price " + (price_war / 1000000).ToString ("f3") + "m hryvnia";
    		}  
		}
		if (language == "Rus")
		{
			if (price_war < 1000){
    		price_war_text.text =  "цена " + price_war.ToString () + " гривен";
    		}
    		if (price_war >= 1000){  
    		price_war_text.text =  "цена " + (price_war / 1000).ToString ("f3") + "к гривен";
    		}
    		if (price_war >= 1000000){  
    		price_war_text.text =  "цена " + (price_war / 1000000).ToString ("f3") + "м гривен";
    		} 
    	}
    	if (language == "UA")
    	{
			if (price_war < 1000){
    		price_war_text.text =  "ціна " + price_war.ToString () + " гривень";
    		}
    		if (price_war >= 1000){  
    		price_war_text.text =  "ціна " + (price_war / 1000).ToString ("f3") + "к гривень";
    		}
    		if (price_war >= 1000000){  
    		price_war_text.text =  "ціна " + (price_war / 1000000).ToString ("f3") + "м гривень";
    		} 
    	}
    	if(language == "Pl")
		{
			if (price_war < 1000){
    		price_war_text.text =  "price " + price_war.ToString () + " hryvnia";
    		}
    		if (price_war >= 1000){  
    		price_war_text.text =  "price " + (price_war / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_war >= 1000000){  
    		price_war_text.text =  "price " + (price_war / 1000000).ToString ("f3") + "m hryvnia";
    		}  
		}
		if(language == "De")
		{
			if (price_war < 1000){
    		price_war_text.text =  "price " + price_war.ToString () + " hryvnia";
    		}
    		if (price_war >= 1000){  
    		price_war_text.text =  "price " + (price_war / 1000).ToString ("f3") + "k hryvnia";
    		}
    		if (price_war >= 1000000){  
    		price_war_text.text =  "price " + (price_war / 1000000).ToString ("f3") + "m hryvnia";
    		}  
		} 
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

	// ПРОГРЕСС ПРОКАЧКИ

	// --------------------------------------- ПЕРВАЯ ПРОКАЧКА
	if (int_progress_bottle == 0)
	{
		if(img_progress_1_bottle != null){
        img_progress_1_bottle.SetActive(false);
        }
        if(img_progress_2_bottle != null){
        img_progress_2_bottle.SetActive(false);
        }
        if(img_progress_3_bottle != null){
        img_progress_3_bottle.SetActive(false);
        }
        if(img_progress_4_bottle != null){
        img_progress_4_bottle.SetActive(false);
        }
        if(img_progress_5_bottle != null){
        img_progress_5_bottle.SetActive(false);
        }
        if(img_progress_6_bottle != null){
        img_progress_6_bottle.SetActive(false);
        }
        if(img_progress_7_bottle != null){
        img_progress_7_bottle.SetActive(false);
        }
        if(img_progress_8_bottle != null){
        img_progress_8_bottle.SetActive(false);
        }

		price_bottle = 1000;
		PlayerPrefs.SetFloat("price_bottle", price_bottle);
	}

	if (int_progress_metalolom == 0)
	{
		if(img_progress_1_metalolom != null){
        img_progress_1_metalolom.SetActive(false);
        }
        if(img_progress_2_metalolom != null){
        img_progress_2_metalolom.SetActive(false);
        }
        if(img_progress_3_metalolom != null){
        img_progress_3_metalolom.SetActive(false);
        }
        if(img_progress_4_metalolom != null){
        img_progress_4_metalolom.SetActive(false);
        }
        if(img_progress_5_metalolom != null){
        img_progress_5_metalolom.SetActive(false);
        }
        if(img_progress_6_metalolom != null){
        img_progress_6_metalolom.SetActive(false);
        }
        if(img_progress_7_metalolom != null){
        img_progress_7_metalolom.SetActive(false);
        }
        if(img_progress_8_metalolom != null){
        img_progress_8_metalolom.SetActive(false);
        }

		price_metalolom = 75000;
		PlayerPrefs.SetFloat("price_metalolom", price_metalolom);
	}

	if (int_progress_nafta == 0)
	{
		if(img_progress_1_nafta != null){
        img_progress_1_nafta.SetActive(false);
        }
        if(img_progress_2_nafta != null){
        img_progress_2_nafta.SetActive(false);
        }
        if(img_progress_3_nafta != null){
        img_progress_3_nafta.SetActive(false);
        }
        if(img_progress_4_nafta != null){
        img_progress_4_nafta.SetActive(false);
        }
        if(img_progress_5_nafta != null){
        img_progress_5_nafta.SetActive(false);
        }
        if(img_progress_6_nafta != null){
        img_progress_6_nafta.SetActive(false);
        }
        if(img_progress_7_nafta != null){
        img_progress_7_nafta.SetActive(false);
        }
        if(img_progress_8_nafta != null){
        img_progress_8_nafta.SetActive(false);
        }

		price_nafta = 675000;
		PlayerPrefs.SetFloat("price_nafta", price_nafta);
	}

	if (int_progress_sklad == 0)
	{
		if(img_progress_1_sklad != null){
        img_progress_1_sklad.SetActive(false);
        }
        if(img_progress_2_sklad != null){
        img_progress_2_sklad.SetActive(false);
        }
        if(img_progress_3_sklad != null){
        img_progress_3_sklad.SetActive(false);
        }
        if(img_progress_4_sklad != null){
        img_progress_4_sklad.SetActive(false);
        }
        if(img_progress_5_sklad != null){
        img_progress_5_sklad.SetActive(false);
        }
        if(img_progress_6_sklad != null){
        img_progress_6_sklad.SetActive(false);
        }
        if(img_progress_7_sklad != null){
        img_progress_7_sklad.SetActive(false);
        }
        if(img_progress_8_sklad != null){
        img_progress_8_sklad.SetActive(false);
        }

		price_sklad = 1725000;
		PlayerPrefs.SetFloat("price_sklad", price_sklad);
	}

	if (int_progress_airdrom == 0)
	{
		if(img_progress_1_airdrom != null){
        img_progress_1_airdrom.SetActive(false);
        }
        if(img_progress_2_airdrom != null){
        img_progress_2_airdrom.SetActive(false);
        }
        if(img_progress_3_airdrom != null){
        img_progress_3_airdrom.SetActive(false);
        }
        if(img_progress_4_airdrom != null){
        img_progress_4_airdrom.SetActive(false);
        }
        if(img_progress_5_airdrom != null){
        img_progress_5_airdrom.SetActive(false);
        }
        if(img_progress_6_airdrom != null){
        img_progress_6_airdrom.SetActive(false);
        }
        if(img_progress_7_airdrom != null){
        img_progress_7_airdrom.SetActive(false);
        }
        if(img_progress_8_airdrom != null){
        img_progress_8_airdrom.SetActive(false);
        }

		price_airdrom = 6750000;
		PlayerPrefs.SetFloat("price_airdrom", price_airdrom);
	}

	if (int_progress_war == 0)
	{
		if(img_progress_1_war != null){
        img_progress_1_war.SetActive(false);
        }
        if(img_progress_2_war != null){
        img_progress_2_war.SetActive(false);
        }
        if(img_progress_3_war != null){
        img_progress_3_war.SetActive(false);
        }
        if(img_progress_4_war != null){
        img_progress_4_war.SetActive(false);
        }
        if(img_progress_5_war != null){
        img_progress_5_war.SetActive(false);
        }
        if(img_progress_6_war != null){
        img_progress_6_war.SetActive(false);
        }
        if(img_progress_7_war != null){
        img_progress_7_war.SetActive(false);
        }
        if(img_progress_8_war != null){
        img_progress_8_war.SetActive(false);
        }

		price_war = 30000000;
		PlayerPrefs.SetFloat("price_war", price_war);
	}

	// --------------------------------------- ВТОРАЯ ПРОКАЧКА
	if (int_progress_bottle == 1)
	{
		if(img_progress_1_bottle != null){
        img_progress_1_bottle.SetActive(true);
        }
        if(img_progress_2_bottle != null){
        img_progress_2_bottle.SetActive(false);
        }
        if(img_progress_3_bottle != null){
        img_progress_3_bottle.SetActive(false);
        }
        if(img_progress_4_bottle != null){
        img_progress_4_bottle.SetActive(false);
        }
        if(img_progress_5_bottle != null){
        img_progress_5_bottle.SetActive(false);
        }
        if(img_progress_6_bottle != null){
        img_progress_6_bottle.SetActive(false);
        }
        if(img_progress_7_bottle != null){
        img_progress_7_bottle.SetActive(false);
        }
        if(img_progress_8_bottle != null){
        img_progress_8_bottle.SetActive(false);
        }

		price_bottle = 3000;
		PlayerPrefs.SetFloat("price_bottle", price_bottle);
	}

	if (int_progress_metalolom == 1)
	{
		if(img_progress_1_metalolom != null){
        img_progress_1_metalolom.SetActive(true);
        }
        if(img_progress_2_metalolom != null){
        img_progress_2_metalolom.SetActive(false);
        }
        if(img_progress_3_metalolom != null){
        img_progress_3_metalolom.SetActive(false);
        }
        if(img_progress_4_metalolom != null){
        img_progress_4_metalolom.SetActive(false);
        }
        if(img_progress_5_metalolom != null){
        img_progress_5_metalolom.SetActive(false);
        }
        if(img_progress_6_metalolom != null){
        img_progress_6_metalolom.SetActive(false);
        }
        if(img_progress_7_metalolom != null){
        img_progress_7_metalolom.SetActive(false);
        }
        if(img_progress_8_metalolom != null){
        img_progress_8_metalolom.SetActive(false);
        }

		price_metalolom = 97500;
		PlayerPrefs.SetFloat("price_metalolom", price_metalolom);
	}

	if (int_progress_nafta == 1)
	{
		if(img_progress_1_nafta != null){
        img_progress_1_nafta.SetActive(true);
        }
        if(img_progress_2_nafta != null){
        img_progress_2_nafta.SetActive(false);
        }
        if(img_progress_3_nafta != null){
        img_progress_3_nafta.SetActive(false);
        }
        if(img_progress_4_nafta != null){
        img_progress_4_nafta.SetActive(false);
        }
        if(img_progress_5_nafta != null){
        img_progress_5_nafta.SetActive(false);
        }
        if(img_progress_6_nafta != null){
        img_progress_6_nafta.SetActive(false);
        }
        if(img_progress_7_nafta != null){
        img_progress_7_nafta.SetActive(false);
        }
        if(img_progress_8_nafta != null){
        img_progress_8_nafta.SetActive(false);
        }

		price_nafta = 750000;
		PlayerPrefs.SetFloat("price_nafta", price_nafta);
	}

	if (int_progress_sklad == 1)
	{
		if(img_progress_1_sklad != null){
        img_progress_1_sklad.SetActive(true);
        }
        if(img_progress_2_sklad != null){
        img_progress_2_sklad.SetActive(false);
        }
        if(img_progress_3_sklad != null){
        img_progress_3_sklad.SetActive(false);
        }
        if(img_progress_4_sklad != null){
        img_progress_4_sklad.SetActive(false);
        }
        if(img_progress_5_sklad != null){
        img_progress_5_sklad.SetActive(false);
        }
        if(img_progress_6_sklad != null){
        img_progress_6_sklad.SetActive(false);
        }
        if(img_progress_7_sklad != null){
        img_progress_7_sklad.SetActive(false);
        }
        if(img_progress_8_sklad != null){
        img_progress_8_sklad.SetActive(false);
        }

		price_sklad = 2250000;
		PlayerPrefs.SetFloat("price_sklad", price_sklad);
	}

	if (int_progress_airdrom == 1)
	{
		if(img_progress_1_airdrom != null){
        img_progress_1_airdrom.SetActive(true);
        }
        if(img_progress_2_airdrom != null){
        img_progress_2_airdrom.SetActive(false);
        }
        if(img_progress_3_airdrom != null){
        img_progress_3_airdrom.SetActive(false);
        }
        if(img_progress_4_airdrom != null){
        img_progress_4_airdrom.SetActive(false);
        }
        if(img_progress_5_airdrom != null){
        img_progress_5_airdrom.SetActive(false);
        }
        if(img_progress_6_airdrom != null){
        img_progress_6_airdrom.SetActive(false);
        }
        if(img_progress_7_airdrom != null){
        img_progress_7_airdrom.SetActive(false);
        }
        if(img_progress_8_airdrom != null){
        img_progress_8_airdrom.SetActive(false);
        }

		price_airdrom = 9000000;
		PlayerPrefs.SetFloat("price_airdrom", price_airdrom);
	}

	if (int_progress_war == 1)
	{
		if(img_progress_1_war != null){
        img_progress_1_war.SetActive(true);
        }
        if(img_progress_2_war != null){
        img_progress_2_war.SetActive(false);
        }
        if(img_progress_3_war != null){
        img_progress_3_war.SetActive(false);
        }
        if(img_progress_4_war != null){
        img_progress_4_war.SetActive(false);
        }
        if(img_progress_5_war != null){
        img_progress_5_war.SetActive(false);
        }
        if(img_progress_6_war != null){
        img_progress_6_war.SetActive(false);
        }
        if(img_progress_7_war != null){
        img_progress_7_war.SetActive(false);
        }
        if(img_progress_8_war != null){
        img_progress_8_war.SetActive(false);
        }

		price_war = 37500000;
		PlayerPrefs.SetFloat("price_war", price_war);
	}

	// --------------------------------------- ТРЕТЬЯ ПРОКАЧКА
	if (int_progress_bottle == 2)
	{
		if(img_progress_1_bottle != null){
        img_progress_1_bottle.SetActive(true);
        }
        if(img_progress_2_bottle != null){
        img_progress_2_bottle.SetActive(true);
        }
        if(img_progress_3_bottle != null){
        img_progress_3_bottle.SetActive(false);
        }
        if(img_progress_4_bottle != null){
        img_progress_4_bottle.SetActive(false);
        }
        if(img_progress_5_bottle != null){
        img_progress_5_bottle.SetActive(false);
        }
        if(img_progress_6_bottle != null){
        img_progress_6_bottle.SetActive(false);
        }
        if(img_progress_7_bottle != null){
        img_progress_7_bottle.SetActive(false);
        }
        if(img_progress_8_bottle != null){
        img_progress_8_bottle.SetActive(false);
        }

		price_bottle = 3750;
		PlayerPrefs.SetFloat("price_bottle", price_bottle);
	}

	if (int_progress_metalolom == 2)
	{
		if(img_progress_1_metalolom != null){
        img_progress_1_metalolom.SetActive(true);
        }
        if(img_progress_2_metalolom != null){
        img_progress_2_metalolom.SetActive(true);
        }
        if(img_progress_3_metalolom != null){
        img_progress_3_metalolom.SetActive(false);
        }
        if(img_progress_4_metalolom != null){
        img_progress_4_metalolom.SetActive(false);
        }
        if(img_progress_5_metalolom != null){
        img_progress_5_metalolom.SetActive(false);
        }
        if(img_progress_6_metalolom != null){
        img_progress_6_metalolom.SetActive(false);
        }
        if(img_progress_7_metalolom != null){
        img_progress_7_metalolom.SetActive(false);
        }
        if(img_progress_8_metalolom != null){
        img_progress_8_metalolom.SetActive(false);
        }

		price_metalolom = 150000;
		PlayerPrefs.SetFloat("price_metalolom", price_metalolom);
	}

	if (int_progress_nafta == 2)
	{
		if(img_progress_1_nafta != null){
        img_progress_1_nafta.SetActive(true);
        }
        if(img_progress_2_nafta != null){
        img_progress_2_nafta.SetActive(true);
        }
        if(img_progress_3_nafta != null){
        img_progress_3_nafta.SetActive(false);
        }
        if(img_progress_4_nafta != null){
        img_progress_4_nafta.SetActive(false);
        }
        if(img_progress_5_nafta != null){
        img_progress_5_nafta.SetActive(false);
        }
        if(img_progress_6_nafta != null){
        img_progress_6_nafta.SetActive(false);
        }
        if(img_progress_7_nafta != null){
        img_progress_7_nafta.SetActive(false);
        }
        if(img_progress_8_nafta != null){
        img_progress_8_nafta.SetActive(false);
        }

		price_nafta = 900000;
		PlayerPrefs.SetFloat("price_nafta", price_nafta);
	}

	if (int_progress_sklad == 2)
	{
		if(img_progress_1_sklad != null){
        img_progress_1_sklad.SetActive(true);
        }
        if(img_progress_2_sklad != null){
        img_progress_2_sklad.SetActive(true);
        }
        if(img_progress_3_sklad != null){
        img_progress_3_sklad.SetActive(false);
        }
        if(img_progress_4_sklad != null){
        img_progress_4_sklad.SetActive(false);
        }
        if(img_progress_5_sklad != null){
        img_progress_5_sklad.SetActive(false);
        }
        if(img_progress_6_sklad != null){
        img_progress_6_sklad.SetActive(false);
        }
        if(img_progress_7_sklad != null){
        img_progress_7_sklad.SetActive(false);
        }
        if(img_progress_8_sklad != null){
        img_progress_8_sklad.SetActive(false);
        }

		price_sklad = 2475000;
		PlayerPrefs.SetFloat("price_sklad", price_sklad);
	}

	if (int_progress_airdrom == 2)
	{
		if(img_progress_1_airdrom != null){
        img_progress_1_airdrom.SetActive(true);
        }
        if(img_progress_2_airdrom != null){
        img_progress_2_airdrom.SetActive(true);
        }
        if(img_progress_3_airdrom != null){
        img_progress_3_airdrom.SetActive(false);
        }
        if(img_progress_4_airdrom != null){
        img_progress_4_airdrom.SetActive(false);
        }
        if(img_progress_5_airdrom != null){
        img_progress_5_airdrom.SetActive(false);
        }
        if(img_progress_6_airdrom != null){
        img_progress_6_airdrom.SetActive(false);
        }
        if(img_progress_7_airdrom != null){
        img_progress_7_airdrom.SetActive(false);
        }
        if(img_progress_8_airdrom != null){
        img_progress_8_airdrom.SetActive(false);
        }

		price_airdrom = 11250000;
		PlayerPrefs.SetFloat("price_airdrom", price_airdrom);
	}

	if (int_progress_war == 2)
	{
		if(img_progress_1_war != null){
        img_progress_1_war.SetActive(true);
        }
        if(img_progress_2_war != null){
        img_progress_2_war.SetActive(true);
        }
        if(img_progress_3_war != null){
        img_progress_3_war.SetActive(false);
        }
        if(img_progress_4_war != null){
        img_progress_4_war.SetActive(false);
        }
        if(img_progress_5_war != null){
        img_progress_5_war.SetActive(false);
        }
        if(img_progress_6_war != null){
        img_progress_6_war.SetActive(false);
        }
        if(img_progress_7_war != null){
        img_progress_7_war.SetActive(false);
        }
        if(img_progress_8_war != null){
        img_progress_8_war.SetActive(false);
        }

		price_war = 41250000;
		PlayerPrefs.SetFloat("price_war", price_war);
	}

	// --------------------------------------- ЧЕТВЕРТАЯ ПРОКАЧКА
	if (int_progress_bottle == 3)
	{
		if(img_progress_1_bottle != null){
        img_progress_1_bottle.SetActive(true);
        }
        if(img_progress_2_bottle != null){
        img_progress_2_bottle.SetActive(true);
        }
        if(img_progress_3_bottle != null){
        img_progress_3_bottle.SetActive(true);
        }
        if(img_progress_4_bottle != null){
        img_progress_4_bottle.SetActive(false);
        }
        if(img_progress_5_bottle != null){
        img_progress_5_bottle.SetActive(false);
        }
        if(img_progress_6_bottle != null){
        img_progress_6_bottle.SetActive(false);
        }
        if(img_progress_7_bottle != null){
        img_progress_7_bottle.SetActive(false);
        }
        if(img_progress_8_bottle != null){
        img_progress_8_bottle.SetActive(false);
        }

		price_bottle = 15000;
		PlayerPrefs.SetFloat("price_bottle", price_bottle);
	}

	if (int_progress_metalolom == 3)
	{
		if(img_progress_1_metalolom != null){
        img_progress_1_metalolom.SetActive(true);
        }
        if(img_progress_2_metalolom != null){
        img_progress_2_metalolom.SetActive(true);
        }
        if(img_progress_3_metalolom != null){
        img_progress_3_metalolom.SetActive(true);
        }
        if(img_progress_4_metalolom != null){
        img_progress_4_metalolom.SetActive(false);
        }
        if(img_progress_5_metalolom != null){
        img_progress_5_metalolom.SetActive(false);
        }
        if(img_progress_6_metalolom != null){
        img_progress_6_metalolom.SetActive(false);
        }
        if(img_progress_7_metalolom != null){
        img_progress_7_metalolom.SetActive(false);
        }
        if(img_progress_8_metalolom != null){
        img_progress_8_metalolom.SetActive(false);
        }

		price_metalolom = 187500;
		PlayerPrefs.SetFloat("price_metalolom", price_metalolom);
	}

	if (int_progress_nafta == 3)
	{
		if(img_progress_1_nafta != null){
        img_progress_1_nafta.SetActive(true);
        }
        if(img_progress_2_nafta != null){
        img_progress_2_nafta.SetActive(true);
        }
        if(img_progress_3_nafta != null){
        img_progress_3_nafta.SetActive(true);
        }
        if(img_progress_4_nafta != null){
        img_progress_4_nafta.SetActive(false);
        }
        if(img_progress_5_nafta != null){
        img_progress_5_nafta.SetActive(false);
        }
        if(img_progress_6_nafta != null){
        img_progress_6_nafta.SetActive(false);
        }
        if(img_progress_7_nafta != null){
        img_progress_7_nafta.SetActive(false);
        }
        if(img_progress_8_nafta != null){
        img_progress_8_nafta.SetActive(false);
        }

		price_nafta = 1125000;
		PlayerPrefs.SetFloat("price_nafta", price_nafta);
	}

	if (int_progress_sklad == 3)
	{
		if(img_progress_1_sklad != null){
        img_progress_1_sklad.SetActive(true);
        }
        if(img_progress_2_sklad != null){
        img_progress_2_sklad.SetActive(true);
        }
        if(img_progress_3_sklad != null){
        img_progress_3_sklad.SetActive(true);
        }
        if(img_progress_4_sklad != null){
        img_progress_4_sklad.SetActive(false);
        }
        if(img_progress_5_sklad != null){
        img_progress_5_sklad.SetActive(false);
        }
        if(img_progress_6_sklad != null){
        img_progress_6_sklad.SetActive(false);
        }
        if(img_progress_7_sklad != null){
        img_progress_7_sklad.SetActive(false);
        }
        if(img_progress_8_sklad != null){
        img_progress_8_sklad.SetActive(false);
        }

		price_sklad = 3000000;
		PlayerPrefs.SetFloat("price_sklad", price_sklad);
	}

	if (int_progress_airdrom == 3)
	{
		if(img_progress_1_airdrom != null){
        img_progress_1_airdrom.SetActive(true);
        }
        if(img_progress_2_airdrom != null){
        img_progress_2_airdrom.SetActive(true);
        }
        if(img_progress_3_airdrom != null){
        img_progress_3_airdrom.SetActive(true);
        }
        if(img_progress_4_airdrom != null){
        img_progress_4_airdrom.SetActive(false);
        }
        if(img_progress_5_airdrom != null){
        img_progress_5_airdrom.SetActive(false);
        }
        if(img_progress_6_airdrom != null){
        img_progress_6_airdrom.SetActive(false);
        }
        if(img_progress_7_airdrom != null){
        img_progress_7_airdrom.SetActive(false);
        }
        if(img_progress_8_airdrom != null){
        img_progress_8_airdrom.SetActive(false);
        }

		price_airdrom = 12000000;
		PlayerPrefs.SetFloat("price_airdrom", price_airdrom);
	}

	if (int_progress_war == 3)
	{
		if(img_progress_1_war != null){
        img_progress_1_war.SetActive(true);
        }
        if(img_progress_2_war != null){
        img_progress_2_war.SetActive(true);
        }
        if(img_progress_3_war != null){
        img_progress_3_war.SetActive(true);
        }
        if(img_progress_4_war != null){
        img_progress_4_war.SetActive(false);
        }
        if(img_progress_5_war != null){
        img_progress_5_war.SetActive(false);
        }
        if(img_progress_6_war != null){
        img_progress_6_war.SetActive(false);
        }
        if(img_progress_7_war != null){
        img_progress_7_war.SetActive(false);
        }
        if(img_progress_8_war != null){
        img_progress_8_war.SetActive(false);
        }

		price_war = 52500000;
		PlayerPrefs.SetFloat("price_war", price_war);
	}

	// --------------------------------------- ПЬЯТАЯ ПРОКАЧКА
	if (int_progress_bottle == 4)
	{
		if(img_progress_1_bottle != null){
        img_progress_1_bottle.SetActive(true);
        }
        if(img_progress_2_bottle != null){
        img_progress_2_bottle.SetActive(true);
        }
        if(img_progress_3_bottle != null){
        img_progress_3_bottle.SetActive(true);
        }
        if(img_progress_4_bottle != null){
        img_progress_4_bottle.SetActive(true);
        }
        if(img_progress_5_bottle != null){
        img_progress_5_bottle.SetActive(false);
        }
        if(img_progress_6_bottle != null){
        img_progress_6_bottle.SetActive(false);
        }
        if(img_progress_7_bottle != null){
        img_progress_7_bottle.SetActive(false);
        }
        if(img_progress_8_bottle != null){
        img_progress_8_bottle.SetActive(false);
        }

		price_bottle = 22500;
		PlayerPrefs.SetFloat("price_bottle", price_bottle);
	}

	if (int_progress_metalolom == 4)
	{
		if(img_progress_1_metalolom != null){
        img_progress_1_metalolom.SetActive(true);
        }
        if(img_progress_2_metalolom != null){
        img_progress_2_metalolom.SetActive(true);
        }
        if(img_progress_3_metalolom != null){
        img_progress_3_metalolom.SetActive(true);
        }
        if(img_progress_4_metalolom != null){
        img_progress_4_metalolom.SetActive(true);
        }
        if(img_progress_5_metalolom != null){
        img_progress_5_metalolom.SetActive(false);
        }
        if(img_progress_6_metalolom != null){
        img_progress_6_metalolom.SetActive(false);
        }
        if(img_progress_7_metalolom != null){
        img_progress_7_metalolom.SetActive(false);
        }
        if(img_progress_8_metalolom != null){
        img_progress_8_metalolom.SetActive(false);
        }

		price_metalolom = 375000;
		PlayerPrefs.SetFloat("price_metalolom", price_metalolom);
	}

	if (int_progress_nafta == 4)
	{
		if(img_progress_1_nafta != null){
        img_progress_1_nafta.SetActive(true);
        }
        if(img_progress_2_nafta != null){
        img_progress_2_nafta.SetActive(true);
        }
        if(img_progress_3_nafta != null){
        img_progress_3_nafta.SetActive(true);
        }
        if(img_progress_4_nafta != null){
        img_progress_4_nafta.SetActive(true);
        }
        if(img_progress_5_nafta != null){
        img_progress_5_nafta.SetActive(false);
        }
        if(img_progress_6_nafta != null){
        img_progress_6_nafta.SetActive(false);
        }
        if(img_progress_7_nafta != null){
        img_progress_7_nafta.SetActive(false);
        }
        if(img_progress_8_nafta != null){
        img_progress_8_nafta.SetActive(false);
        }

		price_nafta = 1162500;
		PlayerPrefs.SetFloat("price_nafta", price_nafta);
	}

	if (int_progress_sklad == 4)
	{
		if(img_progress_1_sklad != null){
        img_progress_1_sklad.SetActive(true);
        }
        if(img_progress_2_sklad != null){
        img_progress_2_sklad.SetActive(true);
        }
        if(img_progress_3_sklad != null){
        img_progress_3_sklad.SetActive(true);
        }
        if(img_progress_4_sklad != null){
        img_progress_4_sklad.SetActive(true);
        }
        if(img_progress_5_sklad != null){
        img_progress_5_sklad.SetActive(false);
        }
        if(img_progress_6_sklad != null){
        img_progress_6_sklad.SetActive(false);
        }
        if(img_progress_7_sklad != null){
        img_progress_7_sklad.SetActive(false);
        }
        if(img_progress_8_sklad != null){
        img_progress_8_sklad.SetActive(false);
        }

		price_sklad = 3750000;
		PlayerPrefs.SetFloat("price_sklad", price_sklad);
	}

	if (int_progress_airdrom == 4)
	{
		if(img_progress_1_airdrom != null){
        img_progress_1_airdrom.SetActive(true);
        }
        if(img_progress_2_airdrom != null){
        img_progress_2_airdrom.SetActive(true);
        }
        if(img_progress_3_airdrom != null){
        img_progress_3_airdrom.SetActive(true);
        }
        if(img_progress_4_airdrom != null){
        img_progress_4_airdrom.SetActive(true);
        }
        if(img_progress_5_airdrom != null){
        img_progress_5_airdrom.SetActive(false);
        }
        if(img_progress_6_airdrom != null){
        img_progress_6_airdrom.SetActive(false);
        }
        if(img_progress_7_airdrom != null){
        img_progress_7_airdrom.SetActive(false);
        }
        if(img_progress_8_airdrom != null){
        img_progress_8_airdrom.SetActive(false);
        }

		price_airdrom = 15000000;
		PlayerPrefs.SetFloat("price_airdrom", price_airdrom);
	}

	if (int_progress_war == 4)
	{
		if(img_progress_1_war != null){
        img_progress_1_war.SetActive(true);
        }
        if(img_progress_2_war != null){
        img_progress_2_war.SetActive(true);
        }
        if(img_progress_3_war != null){
        img_progress_3_war.SetActive(true);
        }
        if(img_progress_4_war != null){
        img_progress_4_war.SetActive(true);
        }
        if(img_progress_5_war != null){
        img_progress_5_war.SetActive(false);
        }
        if(img_progress_6_war != null){
        img_progress_6_war.SetActive(false);
        }
        if(img_progress_7_war != null){
        img_progress_7_war.SetActive(false);
        }
        if(img_progress_8_war != null){
        img_progress_8_war.SetActive(false);
        }

		price_war = 75000000;
		PlayerPrefs.SetFloat("price_war", price_war);
	}

	// --------------------------------------- ШЕСТАЯ ПРОКАЧКА
	if (int_progress_bottle == 5)
	{
		if(img_progress_1_bottle != null){
        img_progress_1_bottle.SetActive(true);
        }
        if(img_progress_2_bottle != null){
        img_progress_2_bottle.SetActive(true);
        }
        if(img_progress_3_bottle != null){
        img_progress_3_bottle.SetActive(true);
        }
        if(img_progress_4_bottle != null){
        img_progress_4_bottle.SetActive(true);
        }
        if(img_progress_5_bottle != null){
        img_progress_5_bottle.SetActive(true);
        }
        if(img_progress_6_bottle != null){
        img_progress_6_bottle.SetActive(false);
        }
        if(img_progress_7_bottle != null){
        img_progress_7_bottle.SetActive(false);
        }
        if(img_progress_8_bottle != null){
        img_progress_8_bottle.SetActive(false);
        }

		price_bottle = 60000;
		PlayerPrefs.SetFloat("price_bottle", price_bottle);
	}

	if (int_progress_metalolom == 5)
	{
		if(img_progress_1_metalolom != null){
        img_progress_1_metalolom.SetActive(true);
        }
        if(img_progress_2_metalolom != null){
        img_progress_2_metalolom.SetActive(true);
        }
        if(img_progress_3_metalolom != null){
        img_progress_3_metalolom.SetActive(true);
        }
        if(img_progress_4_metalolom != null){
        img_progress_4_metalolom.SetActive(true);
        }
        if(img_progress_5_metalolom != null){
        img_progress_5_metalolom.SetActive(true);
        }
        if(img_progress_6_metalolom != null){
        img_progress_6_metalolom.SetActive(false);
        }
        if(img_progress_7_metalolom != null){
        img_progress_7_metalolom.SetActive(false);
        }
        if(img_progress_8_metalolom != null){
        img_progress_8_metalolom.SetActive(false);
        }

		price_metalolom = 525000;
		PlayerPrefs.SetFloat("price_metalolom", price_metalolom);
	}

	if (int_progress_nafta == 5)
	{
		if(img_progress_1_nafta != null){
        img_progress_1_nafta.SetActive(true);
        }
        if(img_progress_2_nafta != null){
        img_progress_2_nafta.SetActive(true);
        }
        if(img_progress_3_nafta != null){
        img_progress_3_nafta.SetActive(true);
        }
        if(img_progress_4_nafta != null){
        img_progress_4_nafta.SetActive(true);
        }
        if(img_progress_5_nafta != null){
        img_progress_5_nafta.SetActive(true);
        }
        if(img_progress_6_nafta != null){
        img_progress_6_nafta.SetActive(false);
        }
        if(img_progress_7_nafta != null){
        img_progress_7_nafta.SetActive(false);
        }
        if(img_progress_8_nafta != null){
        img_progress_8_nafta.SetActive(false);
        }

		price_nafta = 1275000;
		PlayerPrefs.SetFloat("price_nafta", price_nafta);
	}

	if (int_progress_sklad == 5)
	{
		if(img_progress_1_sklad != null){
        img_progress_1_sklad.SetActive(true);
        }
        if(img_progress_2_sklad != null){
        img_progress_2_sklad.SetActive(true);
        }
        if(img_progress_3_sklad != null){
        img_progress_3_sklad.SetActive(true);
        }
        if(img_progress_4_sklad != null){
        img_progress_4_sklad.SetActive(true);
        }
        if(img_progress_5_sklad != null){
        img_progress_5_sklad.SetActive(true);
        }
        if(img_progress_6_sklad != null){
        img_progress_6_sklad.SetActive(false);
        }
        if(img_progress_7_sklad != null){
        img_progress_7_sklad.SetActive(false);
        }
        if(img_progress_8_sklad != null){
        img_progress_8_sklad.SetActive(false);
        }

		price_sklad = 5250000;
		PlayerPrefs.SetFloat("price_sklad", price_sklad);
	}

	if (int_progress_airdrom == 5)
	{
		if(img_progress_1_airdrom != null){
        img_progress_1_airdrom.SetActive(true);
        }
        if(img_progress_2_airdrom != null){
        img_progress_2_airdrom.SetActive(true);
        }
        if(img_progress_3_airdrom != null){
        img_progress_3_airdrom.SetActive(true);
        }
        if(img_progress_4_airdrom != null){
        img_progress_4_airdrom.SetActive(true);
        }
        if(img_progress_5_airdrom != null){
        img_progress_5_airdrom.SetActive(true);
        }
        if(img_progress_6_airdrom != null){
        img_progress_6_airdrom.SetActive(false);
        }
        if(img_progress_7_airdrom != null){
        img_progress_7_airdrom.SetActive(false);
        }
        if(img_progress_8_airdrom != null){
        img_progress_8_airdrom.SetActive(false);
        }

		price_airdrom = 22500000;
		PlayerPrefs.SetFloat("price_airdrom", price_airdrom);
	}

	if (int_progress_war == 5)
	{
		if(img_progress_1_war != null){
        img_progress_1_war.SetActive(true);
        }
        if(img_progress_2_war != null){
        img_progress_2_war.SetActive(true);
        }
        if(img_progress_3_war != null){
        img_progress_3_war.SetActive(true);
        }
        if(img_progress_4_war != null){
        img_progress_4_war.SetActive(true);
        }
        if(img_progress_5_war != null){
        img_progress_5_war.SetActive(true);
        }
        if(img_progress_6_war != null){
        img_progress_6_war.SetActive(false);
        }
        if(img_progress_7_war != null){
        img_progress_7_war.SetActive(false);
        }
        if(img_progress_8_war != null){
        img_progress_8_war.SetActive(false);
        }

		price_war = 97500000;
		PlayerPrefs.SetFloat("price_war", price_war);
	}

	// --------------------------------------- СЕДЬМАЯ ПРОКАЧКА
	if (int_progress_bottle == 6)
	{
		if(img_progress_1_bottle != null){
        img_progress_1_bottle.SetActive(true);
        }
        if(img_progress_2_bottle != null){
        img_progress_2_bottle.SetActive(true);
        }
        if(img_progress_3_bottle != null){
        img_progress_3_bottle.SetActive(true);
        }
        if(img_progress_4_bottle != null){
        img_progress_4_bottle.SetActive(true);
        }
        if(img_progress_5_bottle != null){
        img_progress_5_bottle.SetActive(true);
        }
        if(img_progress_6_bottle != null){
        img_progress_6_bottle.SetActive(true);
        }
        if(img_progress_7_bottle != null){
        img_progress_7_bottle.SetActive(false);
        }
        if(img_progress_8_bottle != null){
        img_progress_8_bottle.SetActive(false);
        }

		price_bottle = 150000;
		PlayerPrefs.SetFloat("price_bottle", price_bottle);
	}

	if (int_progress_metalolom == 6)
	{
		if(img_progress_1_metalolom != null){
        img_progress_1_metalolom.SetActive(true);
        }
        if(img_progress_2_metalolom != null){
        img_progress_2_metalolom.SetActive(true);
        }
        if(img_progress_3_metalolom != null){
        img_progress_3_metalolom.SetActive(true);
        }
        if(img_progress_4_metalolom != null){
        img_progress_4_metalolom.SetActive(true);
        }
        if(img_progress_5_metalolom != null){
        img_progress_5_metalolom.SetActive(true);
        }
        if(img_progress_6_metalolom != null){
        img_progress_6_metalolom.SetActive(true);
        }
        if(img_progress_7_metalolom != null){
        img_progress_7_metalolom.SetActive(false);
        }
        if(img_progress_8_metalolom != null){
        img_progress_8_metalolom.SetActive(false);
        }

		price_metalolom = 750000;
		PlayerPrefs.SetFloat("price_metalolom", price_metalolom);
	}

	if (int_progress_nafta == 6)
	{
		if(img_progress_1_nafta != null){
        img_progress_1_nafta.SetActive(true);
        }
        if(img_progress_2_nafta != null){
        img_progress_2_nafta.SetActive(true);
        }
        if(img_progress_3_nafta != null){
        img_progress_3_nafta.SetActive(true);
        }
        if(img_progress_4_nafta != null){
        img_progress_4_nafta.SetActive(true);
        }
        if(img_progress_5_nafta != null){
        img_progress_5_nafta.SetActive(true);
        }
        if(img_progress_6_nafta != null){
        img_progress_6_nafta.SetActive(true);
        }
        if(img_progress_7_nafta != null){
        img_progress_7_nafta.SetActive(false);
        }
        if(img_progress_8_nafta != null){
        img_progress_8_nafta.SetActive(false);
        }

		price_nafta = 1875000;
		PlayerPrefs.SetFloat("price_nafta", price_nafta);
	}

	if (int_progress_sklad == 6)
	{
		if(img_progress_1_sklad != null){
        img_progress_1_sklad.SetActive(true);
        }
        if(img_progress_2_sklad != null){
        img_progress_2_sklad.SetActive(true);
        }
        if(img_progress_3_sklad != null){
        img_progress_3_sklad.SetActive(true);
        }
        if(img_progress_4_sklad != null){
        img_progress_4_sklad.SetActive(true);
        }
        if(img_progress_5_sklad != null){
        img_progress_5_sklad.SetActive(true);
        }
        if(img_progress_6_sklad != null){
        img_progress_6_sklad.SetActive(true);
        }
        if(img_progress_7_sklad != null){
        img_progress_7_sklad.SetActive(false);
        }
        if(img_progress_8_sklad != null){
        img_progress_8_sklad.SetActive(false);
        }

		price_sklad = 7500000;
		PlayerPrefs.SetFloat("price_sklad", price_sklad);
	}

	if (int_progress_airdrom == 6)
	{
		if(img_progress_1_airdrom != null){
        img_progress_1_airdrom.SetActive(true);
        }
        if(img_progress_2_airdrom != null){
        img_progress_2_airdrom.SetActive(true);
        }
        if(img_progress_3_airdrom != null){
        img_progress_3_airdrom.SetActive(true);
        }
        if(img_progress_4_airdrom != null){
        img_progress_4_airdrom.SetActive(true);
        }
        if(img_progress_5_airdrom != null){
        img_progress_5_airdrom.SetActive(true);
        }
        if(img_progress_6_airdrom != null){
        img_progress_6_airdrom.SetActive(true);
        }
        if(img_progress_7_airdrom != null){
        img_progress_7_airdrom.SetActive(false);
        }
        if(img_progress_8_airdrom != null){
        img_progress_8_airdrom.SetActive(false);
        }

		price_airdrom = 37500000;
		PlayerPrefs.SetFloat("price_airdrom", price_airdrom);
	}

	if (int_progress_war == 6)
	{
		if(img_progress_1_war != null){
        img_progress_1_war.SetActive(true);
        }
        if(img_progress_2_war != null){
        img_progress_2_war.SetActive(true);
        }
        if(img_progress_3_war != null){
        img_progress_3_war.SetActive(true);
        }
        if(img_progress_4_war != null){
        img_progress_4_war.SetActive(true);
        }
        if(img_progress_5_war != null){
        img_progress_5_war.SetActive(true);
        }
        if(img_progress_6_war != null){
        img_progress_6_war.SetActive(true);
        }
        if(img_progress_7_war != null){
        img_progress_7_war.SetActive(false);
        }
        if(img_progress_8_war != null){
        img_progress_8_war.SetActive(false);
        }

		price_war = 120000000;
		PlayerPrefs.SetFloat("price_war", price_war);
	}

	// --------------------------------------- ВОСЬМАЯ ПРОКАЧКА
	if (int_progress_bottle == 7)
	{
		if(img_progress_1_bottle != null){
        img_progress_1_bottle.SetActive(true);
        }
        if(img_progress_2_bottle != null){
        img_progress_2_bottle.SetActive(true);
        }
        if(img_progress_3_bottle != null){
        img_progress_3_bottle.SetActive(true);
        }
        if(img_progress_4_bottle != null){
        img_progress_4_bottle.SetActive(true);
        }
        if(img_progress_5_bottle != null){
        img_progress_5_bottle.SetActive(true);
        }
        if(img_progress_6_bottle != null){
        img_progress_6_bottle.SetActive(true);
        }
        if(img_progress_7_bottle != null){
        img_progress_7_bottle.SetActive(true);
        }
        if(img_progress_8_bottle != null){
        img_progress_8_bottle.SetActive(false);
        }

		price_bottle = 450000;
		PlayerPrefs.SetFloat("price_bottle", price_bottle);
	}

	if (int_progress_metalolom == 7)
	{
		if(img_progress_1_metalolom != null){
        img_progress_1_metalolom.SetActive(true);
        }
        if(img_progress_2_metalolom != null){
        img_progress_2_metalolom.SetActive(true);
        }
        if(img_progress_3_metalolom != null){
        img_progress_3_metalolom.SetActive(true);
        }
        if(img_progress_4_metalolom != null){
        img_progress_4_metalolom.SetActive(true);
        }
        if(img_progress_5_metalolom != null){
        img_progress_5_metalolom.SetActive(true);
        }
        if(img_progress_6_metalolom != null){
        img_progress_6_metalolom.SetActive(true);
        }
        if(img_progress_7_metalolom != null){
        img_progress_7_metalolom.SetActive(true);
        }
        if(img_progress_8_metalolom != null){
        img_progress_8_metalolom.SetActive(false);
        }

		price_metalolom = 1275000;
		PlayerPrefs.SetFloat("price_metalolom", price_metalolom);
	}

	if (int_progress_nafta == 7)
	{
		if(img_progress_1_nafta != null){
        img_progress_1_nafta.SetActive(true);
        }
        if(img_progress_2_nafta != null){
        img_progress_2_nafta.SetActive(true);
        }
        if(img_progress_3_nafta != null){
        img_progress_3_nafta.SetActive(true);
        }
        if(img_progress_4_nafta != null){
        img_progress_4_nafta.SetActive(true);
        }
        if(img_progress_5_nafta != null){
        img_progress_5_nafta.SetActive(true);
        }
        if(img_progress_6_nafta != null){
        img_progress_6_nafta.SetActive(true);
        }
        if(img_progress_7_nafta != null){
        img_progress_7_nafta.SetActive(true);
        }
        if(img_progress_8_nafta != null){
        img_progress_8_nafta.SetActive(false);
        }

		price_nafta = 3000000;
		PlayerPrefs.SetFloat("price_nafta", price_nafta);
	}

	if (int_progress_sklad == 7)
	{
		if(img_progress_1_sklad != null){
        img_progress_1_sklad.SetActive(true);
        }
        if(img_progress_2_sklad != null){
        img_progress_2_sklad.SetActive(true);
        }
        if(img_progress_3_sklad != null){
        img_progress_3_sklad.SetActive(true);
        }
        if(img_progress_4_sklad != null){
        img_progress_4_sklad.SetActive(true);
        }
        if(img_progress_5_sklad != null){
        img_progress_5_sklad.SetActive(true);
        }
        if(img_progress_6_sklad != null){
        img_progress_6_sklad.SetActive(true);
        }
        if(img_progress_7_sklad != null){
        img_progress_7_sklad.SetActive(true);
        }
        if(img_progress_8_sklad != null){
        img_progress_8_sklad.SetActive(false);
        }

		price_sklad = 15000000;
		PlayerPrefs.SetFloat("price_sklad", price_sklad);
	}

	if (int_progress_airdrom == 7)
	{
		if(img_progress_1_airdrom != null){
        img_progress_1_airdrom.SetActive(true);
        }
        if(img_progress_2_airdrom != null){
        img_progress_2_airdrom.SetActive(true);
        }
        if(img_progress_3_airdrom != null){
        img_progress_3_airdrom.SetActive(true);
        }
        if(img_progress_4_airdrom != null){
        img_progress_4_airdrom.SetActive(true);
        }
        if(img_progress_5_airdrom != null){
        img_progress_5_airdrom.SetActive(true);
        }
        if(img_progress_6_airdrom != null){
        img_progress_6_airdrom.SetActive(true);
        }
        if(img_progress_7_airdrom != null){
        img_progress_7_airdrom.SetActive(true);
        }
        if(img_progress_8_airdrom != null){
        img_progress_8_airdrom.SetActive(false);
        }

		price_airdrom = 75000000;
		PlayerPrefs.SetFloat("price_airdrom", price_airdrom);
	}

	if (int_progress_war == 7)
	{
		if(img_progress_1_war != null){
        img_progress_1_war.SetActive(true);
        }
        if(img_progress_2_war != null){
        img_progress_2_war.SetActive(true);
        }
        if(img_progress_3_war != null){
        img_progress_3_war.SetActive(true);
        }
        if(img_progress_4_war != null){
        img_progress_4_war.SetActive(true);
        }
        if(img_progress_5_war != null){
        img_progress_5_war.SetActive(true);
        }
        if(img_progress_6_war != null){
        img_progress_6_war.SetActive(true);
        }
        if(img_progress_7_war != null){
        img_progress_7_war.SetActive(true);
        }
        if(img_progress_8_war != null){
        img_progress_8_war.SetActive(false);
        }

		price_war = 225000000;
		PlayerPrefs.SetFloat("price_war", price_war);
	}

	// --------------------------------------- ВОСЬМАЯ ПРОКАЧКА (КОНЕЦ)
	if (int_progress_bottle >= 8)
	{
		if(img_progress_1_bottle != null){
        img_progress_1_bottle.SetActive(true);
        }
        if(img_progress_2_bottle != null){
        img_progress_2_bottle.SetActive(true);
        }
        if(img_progress_3_bottle != null){
        img_progress_3_bottle.SetActive(true);
        }
        if(img_progress_4_bottle != null){
        img_progress_4_bottle.SetActive(true);
        }
        if(img_progress_5_bottle != null){
        img_progress_5_bottle.SetActive(true);
        }
        if(img_progress_6_bottle != null){
        img_progress_6_bottle.SetActive(true);
        }
        if(img_progress_7_bottle != null){
        img_progress_7_bottle.SetActive(true);
        }
        if(img_progress_8_bottle != null){
        img_progress_8_bottle.SetActive(true);
        }

		price_bottle = PlayerPrefs.GetFloat("price_bottle"); 
		
		if(language == "" || language == "eng")
		{
			price_bottle_text.text =  "everything is bought";
		}
		if (language == "Rus")
		{
			price_bottle_text.text =  "все куплено";
    	}
    	if (language == "UA")
    	{
    		price_bottle_text.text =  "все куплено";
    	}
    	if (language == "Pl")
    	{
    		price_bottle_text.text =  "wszystko kupione";
    	}
    	if (language == "De")
    	{
    		price_bottle_text.text =  "alles gekauft";
    	}

	}

	if (int_progress_metalolom >= 8)
	{
		if(img_progress_1_metalolom != null){
        img_progress_1_metalolom.SetActive(true);
        }
        if(img_progress_2_metalolom != null){
        img_progress_2_metalolom.SetActive(true);
        }
        if(img_progress_3_metalolom != null){
        img_progress_3_metalolom.SetActive(true);
        }
        if(img_progress_4_metalolom != null){
        img_progress_4_metalolom.SetActive(true);
        }
        if(img_progress_5_metalolom != null){
        img_progress_5_metalolom.SetActive(true);
        }
        if(img_progress_6_metalolom != null){
        img_progress_6_metalolom.SetActive(true);
        }
        if(img_progress_7_metalolom != null){
        img_progress_7_metalolom.SetActive(true);
        }
        if(img_progress_8_metalolom != null){
        img_progress_8_metalolom.SetActive(true);
        }
		price_metalolom = PlayerPrefs.GetFloat("price_metalolom"); 

		if(language == "" || language == "eng")
		{
			price_metalolom_text.text =  "everything is bought";
		}
		if (language == "Rus")
		{
			price_metalolom_text.text =  "все куплено";
    	}
    	if (language == "UA")
    	{
    		price_metalolom_text.text =  "все куплено";
    	}
    	if (language == "Pl")
    	{
    		price_bottle_text.text =  "wszystko kupione";
    	}
    	if (language == "De")
    	{
    		price_bottle_text.text =  "alles gekauft";
    	}

	}

	if (int_progress_nafta >= 8)
	{
		if(img_progress_1_nafta != null){
        img_progress_1_nafta.SetActive(true);
        }
        if(img_progress_2_nafta != null){
        img_progress_2_nafta.SetActive(true);
        }
        if(img_progress_3_nafta != null){
        img_progress_3_nafta.SetActive(true);
        }
        if(img_progress_4_nafta != null){
        img_progress_4_nafta.SetActive(true);
        }
        if(img_progress_5_nafta != null){
        img_progress_5_nafta.SetActive(true);
        }
        if(img_progress_6_nafta != null){
        img_progress_6_nafta.SetActive(true);
        }
        if(img_progress_7_nafta != null){
        img_progress_7_nafta.SetActive(true);
        }
        if(img_progress_8_nafta != null){
        img_progress_8_nafta.SetActive(true);
        }

		price_nafta = PlayerPrefs.GetFloat("price_nafta");

		if(language == "" || language == "eng")
		{
			price_nafta_text.text =  "everything is bought";
		}
		if (language == "Rus")
		{
			price_nafta_text.text =  "все куплено";
    	}
    	if (language == "UA")
    	{
    		price_nafta_text.text =  "все куплено";
    	}
    	if (language == "Pl")
    	{
    		price_bottle_text.text =  "wszystko kupione";
    	}
    	if (language == "De")
    	{
    		price_bottle_text.text =  "alles gekauft";
    	}

	}

	if (int_progress_sklad >= 8)
	{
		if(img_progress_1_sklad != null){
        img_progress_1_sklad.SetActive(true);
        }
        if(img_progress_2_sklad != null){
        img_progress_2_sklad.SetActive(true);
        }
        if(img_progress_3_sklad != null){
        img_progress_3_sklad.SetActive(true);
        }
        if(img_progress_4_sklad != null){
        img_progress_4_sklad.SetActive(true);
        }
        if(img_progress_5_sklad != null){
        img_progress_5_sklad.SetActive(true);
        }
        if(img_progress_6_sklad != null){
        img_progress_6_sklad.SetActive(true);
        }
        if(img_progress_7_sklad != null){
        img_progress_7_sklad.SetActive(true);
        }
        if(img_progress_8_sklad != null){
        img_progress_8_sklad.SetActive(true);
        }

		price_sklad = PlayerPrefs.GetFloat("price_sklad"); 

		if(language == "" || language == "eng")
		{
			price_sklad_text.text =  "everything is bought";
		}
		if (language == "Rus")
		{
			price_sklad_text.text =  "все куплено";
    	}
    	if (language == "UA")
    	{
    		price_sklad_text.text =  "все куплено";
    	}
    	if (language == "Pl")
    	{
    		price_bottle_text.text =  "wszystko kupione";
    	}
    	if (language == "De")
    	{
    		price_bottle_text.text =  "alles gekauft";
    	}

	}

	if (int_progress_airdrom >= 8)
	{
		if(img_progress_1_airdrom != null){
        img_progress_1_airdrom.SetActive(true);
        }
        if(img_progress_2_airdrom != null){
        img_progress_2_airdrom.SetActive(true);
        }
        if(img_progress_3_airdrom != null){
        img_progress_3_airdrom.SetActive(true);
        }
        if(img_progress_4_airdrom != null){
        img_progress_4_airdrom.SetActive(true);
        }
        if(img_progress_5_airdrom != null){
        img_progress_5_airdrom.SetActive(true);
        }
        if(img_progress_6_airdrom != null){
        img_progress_6_airdrom.SetActive(true);
        }
        if(img_progress_7_airdrom != null){
        img_progress_7_airdrom.SetActive(true);
        }
        if(img_progress_8_airdrom != null){
        img_progress_8_airdrom.SetActive(true);
        }

		price_airdrom = PlayerPrefs.GetFloat("price_airdrom"); 

		if(language == "" || language == "eng")
		{
			price_airdrom_text.text =  "everything is bought";
		}
		if (language == "Rus")
		{
			price_airdrom_text.text =  "все куплено";
    	}
    	if (language == "UA")
    	{
    		price_airdrom_text.text =  "все куплено";
    	}
    	if (language == "Pl")
    	{
    		price_bottle_text.text =  "wszystko kupione";
    	}
    	if (language == "De")
    	{
    		price_bottle_text.text =  "alles gekauft";
    	}

	}

	if (int_progress_war >= 8)
	{
		if(img_progress_1_war != null){
        img_progress_1_war.SetActive(true);
        }
        if(img_progress_2_war != null){
        img_progress_2_war.SetActive(true);
        }
        if(img_progress_3_war != null){
        img_progress_3_war.SetActive(true);
        }
        if(img_progress_4_war != null){
        img_progress_4_war.SetActive(true);
        }
        if(img_progress_5_war != null){
        img_progress_5_war.SetActive(true);
        }
        if(img_progress_6_war != null){
        img_progress_6_war.SetActive(true);
        }
        if(img_progress_7_war != null){
        img_progress_7_war.SetActive(true);
        }
        if(img_progress_8_war != null){
        img_progress_8_war.SetActive(true);
        }

		price_war = PlayerPrefs.GetFloat("price_war");

		if(language == "" || language == "eng")
		{
			price_war_text.text =  "everything is bought";
		}
		if (language == "Rus")
		{
			price_war_text.text =  "все куплено";
    	}
    	if (language == "UA")
    	{
    		price_war_text.text =  "все куплено";
    	}
    	if (language == "Pl")
    	{
    		price_bottle_text.text =  "wszystko kupione";
    	}
    	if (language == "De")
    	{
    		price_bottle_text.text =  "alles gekauft";
    	}

	}
// КОНЕЦ UPDATE
}
}