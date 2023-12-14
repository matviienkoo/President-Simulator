using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class shop_system : MonoBehaviour {

public GameObject transtion_object;
public Animation transtion;

float timer;

// вкладка прокачка
public GameObject HELP_object;
int int_help;
int int_closed_help;

// вкладка настройки
public GameObject SETTING_object;
int int_setting;
int int_closed_setting;

// вкладка карты
public GameObject MAPS_object;
int int_maps;
int int_closed_maps;

// вкладка новостей
public GameObject NEWS_object;
int int_news;
int int_closed_news;

// вкладка рос армии
public GameObject RUS_ARMY_object;
int int_army;
int int_closed_army;

// вкладка скинов
public GameObject SKINS_object;
int int_skins;
int int_closed_skins;

// вкладка ПРЕДУПРИЖДЕНИЕ
public GameObject WARNING_object;
int int_closed_warning;

// помощь
public void open_help ()
{

	// включить помощь
	if(transtion_object != null){
	transtion_object.SetActive(true);
	}
	transtion.Play("transtion"); 
	int_help += 1;

}

public void closed_help ()
{

	if(transtion_object != null){
	transtion_object.SetActive(true);
	}

	transtion.Play("transtion"); 
	int_closed_help += 1;

}

// настройки
public void open_setting ()
{
	// включить новости
	if(transtion_object != null){
	transtion_object.SetActive(true);
	}
	transtion.Play("transtion"); 
	int_setting += 1;

}

public void closed_setting ()
{

	if(transtion_object != null){
	transtion_object.SetActive(true);
	}

	transtion.Play("transtion"); 
	int_closed_setting += 1;

}

// карта
public void open_maps ()
{
	// включить карту
	if(transtion_object != null){
	transtion_object.SetActive(true);
	}
	transtion.Play("transtion"); 
	int_maps += 1;

}

public void closed_maps ()
{

	if(transtion_object != null){
	transtion_object.SetActive(true);
	}

	transtion.Play("transtion"); 
	int_closed_maps += 1;

}

// новости
public void open_news ()
{
	// включить новости
	if(transtion_object != null){
	transtion_object.SetActive(true);
	}
	transtion.Play("transtion"); 
	int_news += 1;

}

public void closed_news ()
{

	if(transtion_object != null){
	transtion_object.SetActive(true);
	}

	transtion.Play("transtion"); 
	int_closed_news += 1;

}

// рос. армия
public void open_rus_army ()
{
	// включить рос. армию
	if(transtion_object != null){
	transtion_object.SetActive(true);
	}
	transtion.Play("transtion"); 
	int_army += 1;

}

public void closed_rus_army ()
{

	if(transtion_object != null){
	transtion_object.SetActive(true);
	}

	transtion.Play("transtion"); 
	int_closed_army += 1;

}

// скины
public void open_skins ()
{
	// включить скины
	if(transtion_object != null){
	transtion_object.SetActive(true);
	}
	transtion.Play("transtion"); 
	int_skins += 1;

}

public void closed_skins ()
{

	if(transtion_object != null){
	transtion_object.SetActive(true);
	}

	transtion.Play("transtion"); 
	int_closed_skins += 1;

}

// предуприждение
public void closed_warning ()
{

	// выключить предуприждение
	if(transtion_object != null){
	transtion_object.SetActive(true);
	}

	transtion.Play("transtion"); 
	int_closed_warning += 1;

}

// --------------------------------------------------------------------------------

void Update ()
{


	// --------------ПОМОЩЬ
	// открыть помощь
	if (int_help >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(HELP_object != null){
			HELP_object.SetActive(true);
			}
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(false);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_help = 0;
			timer = 0;
		}
	}

	// закрыть помощь
	if (int_closed_help >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(HELP_object != null){
			HELP_object.SetActive(false);
			}
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(false);
			}
			if(SETTING_object != null){
			SETTING_object.SetActive(false);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_closed_help = 0;
			timer = 0;
		}
	}

	// --------------НАСТРОЙКИ
	// открыть настройки
	if (int_setting >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(HELP_object != null){
			HELP_object.SetActive(false);
			}
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(false);
			}
			if(SETTING_object != null){
			SETTING_object.SetActive(true);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_setting = 0;
			timer = 0;
		}
	}

	// закрыть настройки
	if (int_closed_setting >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(HELP_object != null){
			HELP_object.SetActive(true);
			}
			if(SETTING_object != null){
			SETTING_object.SetActive(false);
			}
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(false);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_closed_setting = 0;
			timer = 0;
		}
	}

	// --------------КАРТА
	// открыть карту
	if (int_maps >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(HELP_object != null){
			HELP_object.SetActive(false);
			}
			if(MAPS_object != null){
			MAPS_object.SetActive(true);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(false);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_maps = 0;
			timer = 0;
		}
	}

	// закрыть карту
	if (int_closed_maps >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
			if(NEWS_object != null){
			NEWS_object.SetActive(false);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_closed_maps = 0;
			timer = 0;
		}
	}

	// --------------НОВОСТИ
	// открыть новости
	if (int_news >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
			if(HELP_object != null){
			HELP_object.SetActive(false);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(false);
			}
			if(NEWS_object != null){
			NEWS_object.SetActive(true);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_news = 0;
			timer = 0;
		}
	}

	// закрыть новости
	if (int_closed_news >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(MAPS_object != null){
			MAPS_object.SetActive(true);
			}
			if(HELP_object != null){
			HELP_object.SetActive(false);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(false);
			}
			if(NEWS_object != null){
			NEWS_object.SetActive(false);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_closed_news = 0;
			timer = 0;
		}
	}

	// --------------РОС. АРМИЯ
	// открыть рос. амрию
	if (int_army >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(HELP_object != null){
			HELP_object.SetActive(false);
			}
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(true);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_army = 0;
			timer = 0;
		}
	}

	// закрыть рос. амрию
	if (int_closed_army >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(false);
			}
			if(SKINS_object != null){
			SKINS_object.SetActive(false);
			}
			if(HELP_object != null){
			HELP_object.SetActive(false);
			}
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_closed_army = 0;
			timer = 0;
		}
	}

	// --------------СКИНЫ

	// открыть скины
	if (int_skins >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(SKINS_object != null){
			SKINS_object.SetActive(true);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(false);
			}
			if(HELP_object != null){
			HELP_object.SetActive(false);
			}
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_skins = 0;
			timer = 0;
		}
	}

	// закрыть скины
	if (int_closed_skins >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(SKINS_object != null){
			SKINS_object.SetActive(false);
			}
			if(HELP_object != null){
			HELP_object.SetActive(false);
			}
			if(MAPS_object != null){
			MAPS_object.SetActive(false);
			}
			if(RUS_ARMY_object != null){
			RUS_ARMY_object.SetActive(true);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_closed_skins = 0;
			timer = 0;
		}
	}

	// --------------ПРЕДУПРИЖДЕНИЕ

	// закрыть предуприждение
	if (int_closed_warning >= 1)
	{
		timer += Time.deltaTime;
		if (timer >= 0.45)
		{
			if(WARNING_object != null){
			WARNING_object.SetActive(false);
			}
		}
		if (timer >= 1.15)
		{
			if(transtion_object != null){
			transtion_object.SetActive(false);
			}
			int_closed_warning = 0;
			timer = 0;
		}
	}

// конец update  
}

}