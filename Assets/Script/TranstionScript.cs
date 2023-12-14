using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranstionScript : MonoBehaviour {

[Header("Обьекты для перехода")]
public GameObject Transtion_Object;
public Animation Transtion_Animation;
public string StringTranstion; 
public bool BoolTranstion;
private float Timer;

[Header("Основные панели перехода")]
public bool BoolInvader;
public bool BoolMaps;
public bool BoolIncome;
public bool BoolNews;
public bool BoolSetting;
public bool BoolLaws;

[Header("Все панели")]
public GameObject[] AllGameObject;

[Header("Сцены для перехода")]
public GameObject Invader_Panel;
public GameObject Maps_Panel;
public GameObject Income_Panel;
public GameObject News_Panel;
public GameObject Setting_Panel;
public GameObject Laws_Panel;

// Включить панель Invader
public void open_invader ()
{
	if (BoolInvader == false)
	{
		Transtion_Object.SetActive(true);
		Transtion_Animation.Play("transtion"); 

		StringTranstion = "Invader Panel";
		BoolTranstion = true;
	}

	else

	if (BoolInvader == true)
	{
		closed_all();
	}
}

// Включить панель Maps
public void open_maps ()
{
	if (BoolMaps == false)
	{
		Transtion_Object.SetActive(true);
		Transtion_Animation.Play("transtion"); 

		StringTranstion = "Maps Panel";
		BoolTranstion = true;
	}

	else

	if (BoolMaps == true)
	{
		closed_all();
	}
}

// Включить панель Income
public void open_income ()
{
	if (BoolIncome == false)
	{
		Transtion_Object.SetActive(true);
		Transtion_Animation.Play("transtion"); 

		StringTranstion = "Income Panel";
		BoolTranstion = true;
	}

	else

	if (BoolIncome == true)
	{
		closed_all();
	}
}

// Включить панель News
public void open_news ()
{
	if (BoolNews == false)
	{
		Transtion_Object.SetActive(true);
		Transtion_Animation.Play("transtion"); 

		StringTranstion = "News Panel";
		BoolTranstion = true;
	}

	else

	if (BoolNews == true)
	{
		closed_all();
	}
}

// Включить панель Setting
public void open_setting ()
{
	if (BoolSetting == false)
	{
		Transtion_Object.SetActive(true);
		Transtion_Animation.Play("transtion");

		StringTranstion = "Setting Panel";
		BoolTranstion = true; 
	}

	else

	if (BoolSetting == true)
	{
		closed_all();
	}
}

// Включить панель Laws
public void open_laws ()
{
	if (BoolLaws == false)
	{
		Transtion_Object.SetActive(true);
		Transtion_Animation.Play("transtion");

		StringTranstion = "Laws Panel";
		BoolTranstion = true; 
	}

	else

	if (BoolLaws == true)
	{
		closed_all();
	}
}

// Выключить все 
public void closed_all()
{ 
	Transtion_Object.SetActive(true);
	Transtion_Animation.Play("transtion"); 

	StringTranstion = "Closed Panel";
	BoolTranstion = true;
}

private void closed_lengt()
{
	for (int IntAll = 0; IntAll < AllGameObject.Length; IntAll++)
    {
        AllGameObject[IntAll].SetActive(false);
    }
}

	private void Update ()
	{
		if (BoolTranstion == true){
		Timer += Time.deltaTime;
		if (Timer >= 0.45)
		{
			if (StringTranstion == "Invader Panel")
			{
				BoolInvader = false;
				BoolMaps = false;
				BoolIncome = false;
				BoolNews = false;
				BoolSetting = false;
				BoolLaws = false;
				closed_lengt();

				Invader_Panel.SetActive(true);
				BoolInvader = true;
			}

			if (StringTranstion == "Maps Panel")
			{
				BoolInvader = false;
				BoolMaps = false;
				BoolIncome = false;
				BoolNews = false;
				BoolSetting = false;
				BoolLaws = false;
				closed_lengt();

				Maps_Panel.SetActive(true);
				BoolMaps = true;
			}

			if (StringTranstion == "Income Panel")
			{
				BoolInvader = false;
				BoolMaps = false;
				BoolIncome = false;
				BoolNews = false;
				BoolSetting = false;
				BoolLaws = false;
				closed_lengt();

				Income_Panel.SetActive(true);
				BoolIncome = true;
			}

			if (StringTranstion == "News Panel")
			{
				BoolInvader = false;
				BoolMaps = false;
				BoolIncome = false;
				BoolNews = false;
				BoolSetting = false;
				BoolLaws = false;
				closed_lengt();

				News_Panel.SetActive(true);
				BoolNews = true;
			}

			if (StringTranstion == "Setting Panel")
			{
				BoolInvader = false;
				BoolMaps = false;
				BoolIncome = false;
				BoolNews = false;
				BoolSetting = false;
				BoolLaws = false;
				closed_lengt();

				Setting_Panel.SetActive(true);
				BoolSetting = true;
			}

			if (StringTranstion == "Laws Panel")
			{
				BoolInvader = false;
				BoolMaps = false;
				BoolIncome = false;
				BoolNews = false;
				BoolSetting = false;
				BoolLaws = false;
				closed_lengt();

				Laws_Panel.SetActive(true);
				BoolLaws = true;
			}

			if (StringTranstion == "Closed Panel")
			{
				BoolInvader = false;
				BoolMaps = false;
				BoolIncome = false;
				BoolNews = false;
				BoolSetting = false;
				BoolLaws = false;
				closed_lengt();
			}
		}

		if (Timer >= 1.15)
		{
			BoolTranstion = false;

			Transtion_Object.SetActive(false);
			Timer = 0;
		}
		}
	}
}