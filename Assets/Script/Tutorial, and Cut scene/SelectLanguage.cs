using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectLanguage : MonoBehaviour
{
[Header("Экран который показывается при смене языка")]
public Image ScreenUI;

public Sprite ScreenUkraine;
public Sprite ScreenEnglish;
public Sprite ScreenRussian;
public Sprite ScreenGermany;
public Sprite ScreenPolish;

[Header("Анимация текста при выборе")]
public Animator AnimText_Ukraine;
public Animator AnimText_English;
public Animator AnimText_Russia;
public Animator AnimText_German;
public Animator AnimText_Polish;

[Header("Обьекты для перехода")]
public GameObject Transtion_Object;
public Animation Transtion_Animation;
public TranstionTutorialScript TrnScript;

[Header("Выбор Языка")]
public string Language;

    public void UkraineLanguage ()
    {
        // Изменить экран на Зеленского
        ScreenUI.sprite = ScreenUkraine;

        // Изменить язык на украиснкий
        Language = "Ukraine";
        PlayerPrefs.SetString("Lang", Language);

        // Анимация текста
        AnimatorText();
    }

    public void EnglishLanguage ()
    {
        // Изменить экран на Байдена
        ScreenUI.sprite = ScreenEnglish;

        // Изменить язык на английский
        Language = "English";
        PlayerPrefs.SetString("Lang", Language);

        // Анимация текста
        AnimatorText();
    }

    public void RussianLanguage ()
    {
        // Изменить экран на Путина
        ScreenUI.sprite = ScreenRussian;

        // Изменить язык на русский
        Language = "Russia";
        PlayerPrefs.SetString("Lang", Language);

        // Анимация текста
        AnimatorText();
    }

    public void GermanLanguage ()
    {
        // Изменить экран на Шольца
        ScreenUI.sprite = ScreenGermany;

        // Изменить язык на немецкий
        Language = "German";
        PlayerPrefs.SetString("Lang", Language);

        // Анимация текста
        AnimatorText();
    }

    public void PolishLanguage ()
    {   
        // Изменить экран на Зеленского
        ScreenUI.sprite = ScreenPolish;

        // Изменить язык на польский
        Language = "Polish";
        PlayerPrefs.SetString("Lang", Language);

        // Анимация текста
        AnimatorText();
    }

    public void ClosedLanguage ()
    {
        if (Language == "")
        {

        }

        else 

        // Переход на панель кат сцены
        TrnScript.Switching_SelectLanguage_to_CutScene();
    }

    private void AnimatorText ()
    {
        if (Language == "Ukraine")
        {
            AnimText_Ukraine.enabled = true;
            AnimText_English.enabled = false;
            AnimText_Russia.enabled = false;
            AnimText_German.enabled = false;
            AnimText_Polish.enabled = false;
        }

        if (Language == "English")
        {
            AnimText_Ukraine.enabled = false;
            AnimText_English.enabled = true;
            AnimText_Russia.enabled = false;
            AnimText_German.enabled = false;
            AnimText_Polish.enabled = false;
        }

        if (Language == "Russia")
        {
            AnimText_Ukraine.enabled = false;
            AnimText_English.enabled = false;
            AnimText_Russia.enabled = true;
            AnimText_German.enabled = false;
            AnimText_Polish.enabled = false;
        }

        if (Language == "German")
        {
            AnimText_Ukraine.enabled = false;
            AnimText_English.enabled = false;
            AnimText_Russia.enabled = false;
            AnimText_German.enabled = true;
            AnimText_Polish.enabled = false;
        }

        if (Language == "Polish")
        {
            AnimText_Ukraine.enabled = false;
            AnimText_English.enabled = false;
            AnimText_Russia.enabled = false;
            AnimText_German.enabled = false;
            AnimText_Polish.enabled = true;
        }
    }
}