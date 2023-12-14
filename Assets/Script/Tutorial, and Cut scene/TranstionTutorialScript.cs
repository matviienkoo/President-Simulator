using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TranstionTutorialScript : MonoBehaviour {

[Header("Обьекты для перехода")]
public GameObject Transtion_Object;
public Animation Transtion_Animation;
public string StringTranstion; 
public bool BoolTranstion;
private float Timer;

[Header("Обьекты для начального выбора языкае, и просмотра кат сцены")]
public GameObject CutScene_Panel;
public GameObject Language_Panel;
public CutScene CutSceneScript;


// Переключение с панели (Выбора Языка) на панель (Кат Сцены)
public void Switching_SelectLanguage_to_CutScene ()
{
	Transtion_Object.SetActive(true);
	Transtion_Animation.Play("transtion");

	StringTranstion = "Switching Select Language Cut Scene";
	BoolTranstion = true; 
}

// Переключение панелей (Кат Сцены)
public void Switching_Intial_CutScene ()
{
	Transtion_Object.SetActive(true);
	Transtion_Animation.Play("transtion");

	StringTranstion = "Switching Intial CutScene";
	BoolTranstion = true; 
}

// Выключить все 
public void Closed_All()
{ 
	Transtion_Object.SetActive(true);
	Transtion_Animation.Play("transtion"); 

	StringTranstion = "Closed Panel";
	BoolTranstion = true;
}

	private void Update ()
	{
		if (BoolTranstion == true){
		Timer += Time.deltaTime;
		if (Timer >= 0.45)
		{
			if (StringTranstion == "Switching Select Language Cut Scene")
			{
				Language_Panel.SetActive(false);
				CutScene_Panel.SetActive(true);
			}

			if (StringTranstion == "Switching Intial CutScene")
			{
				CutSceneScript.CutSceneSystem();
				StringTranstion = "";
			}

			if (StringTranstion == "Closed Panel")
			{
				Language_Panel.SetActive(false);
				CutScene_Panel.SetActive(false);
			}
		}

		if (Timer >= 1.15)
		{
			// Окончание переключение панели (Выбора Языка) на панель (Кат Сцены)
			if (StringTranstion == "Switching Select Language Cut Scene")
			{
				CutSceneScript.CutSceneSystem();
			}

			// Окончание переходной панели
			Transtion_Object.SetActive(false);
			BoolTranstion = false;
			Timer = 0;
		}
		}
	}
}