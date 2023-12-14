using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.SoundManagerNamespace  // я честно ебало набью, не меняй ничего 
{
public class Normal_lottery : MonoBehaviour {

// язык
public string language;

// основные обьекты лотереии
public GameObject lottery_object;
public Animator anim_lottery;
public GameObject paralise_object;

// переходный обьект
public GameObject transtion_object;
public Animation transtion;
public float timer_transtion;

int int_lottery_anim;

// цифры которые крутяться
public Text text_first_timer;
public Text text_second_timer;
public Text text_thirt_timer;
public float int_first_number;
public float int_second_number;
public float int_thirt_number;

public float lottery_choice;

// пересчот крутылок
public float anim_timer;
public float timer;
public int ticket;

// количество попыток
public Text text_attemps;
public Text text_attemps_black;
public int attemps;

public int int_lottery_special;

// текст если победил, или проиграл
public float money;
public int end_lottery;

public GameObject confeti_object;
public float confeti_timer;
public int int_confeti;

public AudioSource[] lott_sound;
public int music;

 private void PlaySound(int index)
 {

 lott_sound[index].PlayOneShotSoundManaged(lott_sound[index].clip);
            
 }

void Start ()
{
    anim_lottery = GetComponent<Animator>();
    anim_lottery.enabled = false; 

    int_first_number = 6;
    int_second_number = 6;
    int_thirt_number = 6;
}

public void lottery ()
{
	PlaySound(0);

	lottery_choice = 1;
	int_lottery_anim = 1;
	int_confeti = 0;
	anim_lottery.enabled = true;

	if(paralise_object != null){
    paralise_object.SetActive(true);
    }
}

public void win (){
	lottery_choice = 3;
	ticket = 20;
	int_first_number = int_second_number;
	int_first_number = int_thirt_number;
}

void Update ()
{
int_lottery_special = PlayerPrefs.GetInt("int_lottery_special");
end_lottery = PlayerPrefs.GetInt("end_lottery");
language = PlayerPrefs.GetString("Lang");
attemps = PlayerPrefs.GetInt("attemps");
money = PlayerPrefs.GetFloat("money");

text_first_timer.text = int_first_number.ToString ();
text_second_timer.text = int_second_number.ToString ();
text_thirt_timer.text = int_thirt_number.ToString ();

// перевод попыток 
if(language == "" || language == "eng"){
	if (attemps == 3){
	text_attemps.text = "three tries";
	text_attemps_black.text = "three tries";
	}
	if (attemps == 2){
	text_attemps.text = "two tries";
	text_attemps_black.text = "two tries";
	}
	if (attemps == 1){
	text_attemps.text = "one try";
	text_attemps_black.text = "one try";
	}
	if (attemps == 0){
	text_attemps.text = "zero tries";
	text_attemps_black.text = "zero tries";
	}
}

if (language == "Rus"){
	if (attemps == 3){
	text_attemps.text = "три попытки";
	text_attemps_black.text = "три попытки";
	}
	if (attemps == 2){
	text_attemps.text = "две попытки";
	text_attemps_black.text = "две попытки";
	}
	if (attemps == 1){
	text_attemps.text = "одна попытка";
	text_attemps_black.text = "одна попытка";
	}
	if (attemps == 0){
	text_attemps.text = "ноль попыток";
	text_attemps_black.text = "ноль попыток";
	}
}

if (language == "UA"){
	if (attemps == 3){
	text_attemps.text = "три спроби";
	text_attemps_black.text = "три спроби";
	}
	if (attemps == 2){
	text_attemps.text = "дві спроби";
	text_attemps_black.text = "дві спроби";
	}
	if (attemps == 1){
	text_attemps.text = "одна спроба";
	text_attemps_black.text = "одна спроба";
	}
	if (attemps == 0){
	text_attemps.text = "нуль спроб";
	text_attemps_black.text = "нуль спроб";
	}
}
if (language == "De"){
	if (attemps == 3){
	text_attemps.text = "drei versuche";
	text_attemps_black.text = "drei versuche";
	}
	if (attemps == 2){
	text_attemps.text = "zwei versuche";
	text_attemps_black.text = "zwei versuche";
	}
	if (attemps == 1){
	text_attemps.text = "ein versuch";
	text_attemps_black.text = "ein versuch";
	}
	if (attemps == 0){
	text_attemps.text = "null versuche";
	text_attemps_black.text = "null versuche";
	}
}
if (language == "Pl"){
	if (attemps == 3){
	text_attemps.text = "trzy próby";
	text_attemps_black.text = "trzy próby";
	}
	if (attemps == 2){
	text_attemps.text = "dwie próby";
	text_attemps_black.text = "dwie próby";
	}
	if (attemps == 1){
	text_attemps.text = "jedna próba";
	text_attemps_black.text = "jedna próba";
	}
	if (attemps == 0){
	text_attemps.text = "zero prób";
	text_attemps_black.text = "zero prób";
	}
}

	// отключить анимацию
	if (int_lottery_anim >= 1){
	anim_timer += Time.deltaTime;
		if (anim_timer >= 0.35){
		anim_lottery.enabled = false;
		int_lottery_anim = 0;
		anim_timer = 0;
		}
	}

	// третья цифра
	if (lottery_choice == 3){
	timer += Time.deltaTime;

	if (timer >= 0.2)
	{
		int_thirt_number = Random.Range (0, 10);
		ticket += 1;	
		timer = 0;
	}

	if (ticket >= 20)
	{
		if (int_first_number == int_second_number){
    	if (int_first_number == int_thirt_number){
		if (int_confeti == 0){

    		if(confeti_object != null){
			confeti_object.SetActive(true);
			}
			int_confeti = 1;
    
    	}
    	}
    	}

		// последняя крутка
		ticket = 0;
		timer = 0;
		lottery_choice = 0;

		if (attemps == 1){
		attemps = 0;
		PlayerPrefs.SetInt ("attemps", attemps);

		int_lottery_special = 1;
        PlayerPrefs.SetInt("int_lottery_special", int_lottery_special);

		end_lottery = 1;
		PlayerPrefs.SetInt ("end_lottery", end_lottery);
		
		if(transtion_object != null){
		transtion_object.SetActive(true);
		}
		transtion.Play("transtion"); 

		if(paralise_object != null){
    	paralise_object.SetActive(false);
    	}
    	
		}

		if (attemps == 2){
		attemps = 1;
		PlayerPrefs.SetInt ("attemps", attemps);

		if(paralise_object != null){
    	paralise_object.SetActive(false);
    	}
		}

		if (attemps >= 3){
		attemps = 2;
		PlayerPrefs.SetInt ("attemps", attemps);

		if(paralise_object != null){
    	paralise_object.SetActive(false);
    	}
		}

    }
    }

    // вторая цифра
	if (lottery_choice == 2){
	timer += Time.deltaTime;
		if (timer >= 0.2)
		{
			int_second_number = Random.Range (0, 10);
			ticket += 1;	
			timer = 0;
		}

		if (ticket >= 20)
		{
			ticket = 0;
			timer = 0;
			lottery_choice = 3;
		}

	}

	// первая цифра
	if (lottery_choice == 1){
	timer += Time.deltaTime;
		if (timer >= 0.2)
		{
			int_first_number = Random.Range (0, 10);
			ticket += 1;	
			timer = 0;
		}

		if (ticket >= 20)
		{	
			ticket = 0;
			timer = 0;
			lottery_choice = 2;
		}
	}

	// победа в лотерею
	if (int_confeti == 1){
	confeti_timer += Time.deltaTime;
	if (confeti_timer >= 0.35){

	if(confeti_object != null){
	confeti_object.SetActive(false);
	}

	if (money > 100000000){
	money = money * 5;
    PlayerPrefs.SetFloat("money", money);

	int_confeti = 0;
	confeti_timer = 0;
	}  	

	if (money <= 100000000){
	if (money > 1000){
	money = money * 15;
    PlayerPrefs.SetFloat("money", money);

	int_confeti = 0;
	confeti_timer = 0;
	}
	}  

	if (money <= 5000){
	money += 50000;
    PlayerPrefs.SetFloat("money", money);

	int_confeti = 0;
	confeti_timer = 0;
	} 

	}	
	}

// конец update
}
}
}