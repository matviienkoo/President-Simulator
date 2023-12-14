using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;
using TMPro;

public class InvaderScript : MonoBehaviour
{   
    [Header("Система финансов")]
    public float Money;
    public TextMeshProUGUI MoneyText;
    public Animation DontHaveMoney_Anim;

    [Header("Система для подстеча количества уничтоженой военной техники")]
    private string String_Weapon_Amount;
    public float Float_Weapon_Amount;
    public Text Text_Weapon_Amount;
    public float PriceMilitaryForOneUnit;

    public TextMeshProUGUI Text_PriceAllMilitary;
    public float PriceAllMilitary;

    [Header("Количество военной техники, и анимация для них")]
    public string ChoiseDestrojed;

    public TextMeshProUGUI Text_Tank_Amount;
    public TextMeshProUGUI Text_Pvo_Amount;
    public TextMeshProUGUI Text_Aircraft_Amount;
    public TextMeshProUGUI Text_Ak47_Amount;
    public TextMeshProUGUI Text_Btr_Amount;
    public TextMeshProUGUI Text_Warship_Amount;
    public TextMeshProUGUI Text_Ammunition_Amount;
    public TextMeshProUGUI Text_Helicopter_Amount;
    public TextMeshProUGUI Text_Solider_Amount;

    public Animation Animation_Tank_Amount;
    public Animation Animation_Pvo_Amount;
    public Animation Animation_Aircraft_Amount;
    public Animation Animation_Ak47_Amount;
    public Animation Animation_Btr_Amount;
    public Animation Animation_Watership_Amount;
    public Animation Animation_Amunition_Amount;
    public Animation Animation_Helicopter_Amount;
    public Animation Animation_Soliders_Amount;

    public float Float_Tank_Amount;
    public float Float_Pvo_Amount;
    public float Float_Aircraft_Amount;
    public float Float_Ak47_Amount;
    public float Float_Btr_Amount;
    public float Float_Warship_Amount;
    public float Float_Ammunition_Amount;
    public float Float_Helicopter_Amount;
    public float Float_Solider_Amount;

    [Header("Система зеленных, и краснных лампочек")]
    public List<Image> LampUI;

    public Sprite RedLamp;
    public Sprite GreenLamp;

    public Image TankLamp;
    public Image PvoLamp;
    public Image AircraftLamp;
    public Image Ak47Lamp;
    public Image BtrLamp;
    public Image WarshipLamp;
    public Image AmmunitionLamp;
    public Image HelicopterLamp;
    public Image SoliderLamp;

    [Header("Картинки на экране компьютера")]
    public Image ScreenUI;

    public Sprite ScreenTank;
    public Sprite ScreenPvo;
    public Sprite ScreenHelicopter;
    public Sprite ScreenAircraft;
    public Sprite ScreenAk47;
    public Sprite ScreenBtr;
    public Sprite ScreenWarship;
    public Sprite ScreenSolider;
    public Sprite ScreenAmunition;

    [Header("Эффект взрыва")]
    public GameObject AnimatorExplove;
    public bool BoolExplove;
    private float TimerExplove;

    private void Start () 
    {
        PriceMilitaryForOneUnit = 0;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);
    }

    public void Soliders () 
    {
        // Цена за одну единицу
        PriceMilitaryForOneUnit = 1000;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);

        // Выбор обьекта для уничтожения
        ChoiseDestrojed = "Solider";

        // Переключение лампочки
        for(int x = 0;x <LampUI.Count;x++){
        LampUI[x].sprite = RedLamp;
        }
        SoliderLamp.sprite = GreenLamp;

        // Изменение Экрана
        ScreenUI.sprite = ScreenSolider;
    }

    public void Ammunition () 
    {
        // Цена за одну единицу
        PriceMilitaryForOneUnit = 100;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);

        // Выбор обьекта для уничтожения
        ChoiseDestrojed = "Ammunition";

        // Переключение лампочки
        for(int x = 0;x <LampUI.Count;x++){
        LampUI[x].sprite = RedLamp;
        }
        AmmunitionLamp.sprite = GreenLamp;

        // Изменение Экрана
        ScreenUI.sprite = ScreenAmunition;
    }

    public void Ak47 () 
    {
        // Цена за одну единицу
        PriceMilitaryForOneUnit = 1500;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);

        // Выбор обьекта для уничтожения
        ChoiseDestrojed = "Ak47";

        // Переключение лампочки
        for(int x = 0;x <LampUI.Count;x++){
        LampUI[x].sprite = RedLamp;
        }
        Ak47Lamp.sprite = GreenLamp;

        // Изменение Экрана
        ScreenUI.sprite = ScreenAk47;
    }

    public void Btr () 
    {
        // Цена за одну единицу
        PriceMilitaryForOneUnit = 120000;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);

        // Выбор обьекта для уничтожения
        ChoiseDestrojed = "Btr";

        // Переключение лампочки
        for(int x = 0;x <LampUI.Count;x++){
        LampUI[x].sprite = RedLamp;
        }
        BtrLamp.sprite = GreenLamp;

        // Изменение Экрана
        ScreenUI.sprite = ScreenBtr;
    }

    public void Pvo () 
    {
        // Цена за одну единицу
        PriceMilitaryForOneUnit = 450000;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);

        // Выбор обьекта для уничтожения
        ChoiseDestrojed = "Pvo";

        // Переключение лампочки
        for(int x = 0;x <LampUI.Count;x++){
        LampUI[x].sprite = RedLamp;
        }
        PvoLamp.sprite = GreenLamp;

        // Изменение Экрана
        ScreenUI.sprite = ScreenPvo;
    }

    public void Tank () 
    {
        // Цена за одну единицу
        PriceMilitaryForOneUnit = 550000;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);

        // Выбор обьекта для уничтожения
        ChoiseDestrojed = "Tank";

        // Переключение лампочки
        for(int x = 0;x <LampUI.Count;x++){
        LampUI[x].sprite = RedLamp;
        }
        TankLamp.sprite = GreenLamp;

        // Изменение Экрана
        ScreenUI.sprite = ScreenTank;
    }

    public void Aircraft () {

        // Цена за одну единицу
        PriceMilitaryForOneUnit = 1200000;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);

        // Выбор обьекта для уничтожения
        ChoiseDestrojed = "Aircraft";

        // Переключение лампочки
        for(int x = 0;x <LampUI.Count;x++){
        LampUI[x].sprite = RedLamp;
        }
        AircraftLamp.sprite = GreenLamp;

        // Изменение Экрана
        ScreenUI.sprite = ScreenAircraft;
    }

    public void Helicopter () 
    {
        // Цена за одну единицу
        PriceMilitaryForOneUnit = 950000;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);

        // Выбор обьекта для уничтожения
        ChoiseDestrojed = "Helicopter";

        // Переключение лампочки
        for(int x = 0;x <LampUI.Count;x++){
        LampUI[x].sprite = RedLamp;
        }
        HelicopterLamp.sprite = GreenLamp;

        // Изменение Экрана
        ScreenUI.sprite = ScreenHelicopter;
    }

    public void Warship () 
    {
        // Цена за одну единицу
        PriceMilitaryForOneUnit = 1500000;
        PlayerPrefs.SetFloat("PriceMilitaryForOneUnit",PriceMilitaryForOneUnit);

        // Выбор обьекта для уничтожения
        ChoiseDestrojed = "Warship";

        // Переключение лампочки
        for(int x = 0;x <LampUI.Count;x++){
        LampUI[x].sprite = RedLamp;
        }
        WarshipLamp.sprite = GreenLamp;

        // Изменение Экрана
        ScreenUI.sprite = ScreenWarship;
    }


    public void DestroyMilitary ()
    {
        // Не хватает денег на покупку
        if (PriceAllMilitary > Money)
        {
            DontHaveMoney_Anim.Play();
        }

        // Хватает денег на покупку
        if (PriceAllMilitary > 0){
        if (PriceAllMilitary <= Money)
        {
            // Снятие денег за уничтоженную технику
            Money -= PriceAllMilitary;
            PlayerPrefs.SetFloat("Money",Money);

            // Анимация взрыва
            AnimatorExplove.SetActive(true);
            BoolExplove = true;

            if (ChoiseDestrojed == "Solider"){
            if (Float_Weapon_Amount <= Float_Solider_Amount){

                // Уменьшение количества обьектов которые нужно уничтожить 
                Float_Solider_Amount -= Float_Weapon_Amount;
                PlayerPrefs.SetFloat("Float_Solider_Amount",Float_Solider_Amount);

                // Анимация текста которая показывает что количество обьектов уменьшилось
                Animation_Soliders_Amount.Play();
            }
            }

            if (ChoiseDestrojed == "Ammunition"){
            if (Float_Weapon_Amount <= Float_Ammunition_Amount){

                // Уменьшение количества обьектов которые нужно уничтожить 
                Float_Ammunition_Amount -= Float_Weapon_Amount;
                PlayerPrefs.SetFloat("Float_Ammunition_Amount",Float_Ammunition_Amount);

                // Анимация текста которая показывает что количество обьектов уменьшилось
                Animation_Amunition_Amount.Play();
            }
            }

            if (ChoiseDestrojed == "Ak47"){
            if (Float_Weapon_Amount <= Float_Ak47_Amount){

                // Уменьшение количества обьектов которые нужно уничтожить 
                Float_Ak47_Amount -= Float_Weapon_Amount;
                PlayerPrefs.SetFloat("Float_Ak47_Amount",Float_Ak47_Amount);

                // Анимация текста которая показывает что количество обьектов уменьшилось
                Animation_Ak47_Amount.Play();
            }
            }

            if (ChoiseDestrojed == "Btr"){
            if (Float_Weapon_Amount <= Float_Btr_Amount){

                // Уменьшение количества обьектов которые нужно уничтожить 
                Float_Btr_Amount -= Float_Weapon_Amount;
                PlayerPrefs.SetFloat("Float_Btr_Amount",Float_Btr_Amount);

                // Анимация текста которая показывает что количество обьектов уменьшилось
                Animation_Btr_Amount.Play();
            }
            }

            if (ChoiseDestrojed == "Pvo"){
            if (Float_Weapon_Amount <= Float_Pvo_Amount){

                // Уменьшение количества обьектов которые нужно уничтожить 
                Float_Pvo_Amount -= Float_Weapon_Amount;
                PlayerPrefs.SetFloat("Float_Pvo_Amount",Float_Pvo_Amount);

                // Анимация текста которая показывает что количество обьектов уменьшилось
                Animation_Pvo_Amount.Play();
            }
            }

            if (ChoiseDestrojed == "Tank"){
            if (Float_Weapon_Amount <= Float_Tank_Amount){

                // Уменьшение количества обьектов которые нужно уничтожить 
                Float_Tank_Amount -= Float_Weapon_Amount;
                PlayerPrefs.SetFloat("Float_Tank_Amount",Float_Tank_Amount);

                // Анимация текста которая показывает что количество обьектов уменьшилось
                Animation_Tank_Amount.Play();
            }
            }

            if (ChoiseDestrojed == "Aircraft"){
            if (Float_Weapon_Amount <= Float_Aircraft_Amount){

                // Уменьшение количества обьектов которые нужно уничтожить 
                Float_Aircraft_Amount -= Float_Weapon_Amount;
                PlayerPrefs.SetFloat("Float_Aircraft_Amount",Float_Aircraft_Amount);

                // Анимация текста которая показывает что количество обьектов уменьшилось
                Animation_Aircraft_Amount.Play();
            }
            }

            if (ChoiseDestrojed == "Helicopter"){
            if (Float_Weapon_Amount <= Float_Helicopter_Amount){

                // Уменьшение количества обьектов которые нужно уничтожить 
                Float_Helicopter_Amount -= Float_Weapon_Amount;
                PlayerPrefs.SetFloat("Float_Helicopter_Amount",Float_Helicopter_Amount);

                // Анимация текста которая показывает что количество обьектов уменьшилось
                Animation_Helicopter_Amount.Play();
            }
            }

            if (ChoiseDestrojed == "Warship"){
            if (Float_Weapon_Amount <= Float_Warship_Amount){

                // Уменьшение количества обьектов которые нужно уничтожить 
                Float_Warship_Amount -= Float_Weapon_Amount;
                PlayerPrefs.SetFloat("Float_Warship_Amount",Float_Warship_Amount);

                // Анимация текста которая показывает что количество обьектов уменьшилось
                Animation_Watership_Amount.Play();
            }
            }
        }
        }
    }

    private void Update ()
    { 
    Money = PlayerPrefs.GetFloat("Money");

        // Конвертация строки в число
        String_Weapon_Amount = Text_Weapon_Amount.text; 
        float.TryParse(String_Weapon_Amount, out Float_Weapon_Amount);

        // Подсчет цены
        PriceAllMilitary = Float_Weapon_Amount * PriceMilitaryForOneUnit; 

        // Сокращение суммы для уничтоженой техники
        if (PriceAllMilitary == 0){
        Text_PriceAllMilitary.text = "0000000";
        }
        if (PriceAllMilitary < 1000 && PriceAllMilitary > 0){
        Text_PriceAllMilitary.text = PriceAllMilitary.ToString ();
        }
        if (PriceAllMilitary >= 1000){  
        Text_PriceAllMilitary.text = (PriceAllMilitary / 1000).ToString ("f3") + " Thoushand";
        }
        if (PriceAllMilitary >= 1000000){  
        Text_PriceAllMilitary.text = (PriceAllMilitary / 1000000).ToString ("f3") + " Million";
        } 
        if (PriceAllMilitary >= 1000000000){  
        Text_PriceAllMilitary.text = (PriceAllMilitary / 1000000000).ToString ("f3") + " Milliard";
        }

        // Отключение анимации взрива
        if (BoolExplove == true){
        TimerExplove += Time.deltaTime;
        if (TimerExplove >= 1){

            AnimatorExplove.SetActive(false);

            TimerExplove = 0;
            BoolExplove = false;

        }
        }
    }
}



