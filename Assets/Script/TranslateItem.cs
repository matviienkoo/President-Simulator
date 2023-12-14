using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TranslateItem : MonoBehaviour
{
    [Header("Выбор Языка")]
    public string Language;
    private TextMeshProUGUI Text;
    
    [Header("Перевод")]
    public string TextRussian;
    public string TextEnglish;
    public string TextPolish;
    public string TextGerman;
    public string TextUkraine;
 
    private void Start ()
    {
        //Language = PlayerPrefs.GetString("Lang");

        //if(Language == "" || Language == "English") //P.S. я ставлю инглиш как дефолт
        //{
        //    Text.text = TextEnglish;
        //}
        
        //if (Language == "Russia")
        //{
        //    Text.text = TextRussian;
        //}
        //
        //if (Language == "Ukraine")
        //{
        //    Text.text = TextUkraine;
        //}

        //if (Language == "Polish")
        //{
        //    Text.text = TextPolish;
        //}

        //if (Language == "German")
        //{
        //    Text.text = TextGerman;
        //}
    }
}