using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IncomeScript : MonoBehaviour 
{
	[Header("Система финансов")]
    public float Money;
    public float Income;
    public TextMeshProUGUI MoneyText;
    public Animation DontHaveMoney_Anim;

	[Header("Доска (Коктейли Молотва)")]
	public float Price_MolotovCocktails;
	public TextMeshProUGUI Price_MolotovCocktails_text;

	public Slider Slider_MolotovCocktails;
	public int Current_MolotovCocktails;
	public int Max_MolotovCocktails;

	[Header("Доска (Металолом)")]
	public float Price_ScrapMetal;
	public TextMeshProUGUI Price_ScrapMetal_text;

	public Slider Slider_ScrapMetal;
	public int Current_ScrapMetal;
	public int Max_ScrapMetal;

	[Header("Доска (Нафтабаза)")]
	public float Price_NaphthaBase;
	public TextMeshProUGUI Price_NaphthaBase_text;

	public Slider Slider_NaphthaBase;
	public int Current_NaphthaBase;
	public int Max_NaphthaBase;

	[Header("Доска (Военный склад)")]
	public float Price_MilitaryWarehouse;
	public TextMeshProUGUI Price_MilitaryWarehouse_text;

	public Slider Slider_MilitaryWarehouse;
	public int Current_MilitaryWarehouse;
	public int Max_MilitaryWarehouse;

	[Header("Доска (Военный аэродром)")]
	public float Price_MilitaryAirfield;
	public TextMeshProUGUI Price_MilitaryAirfield_text;

	public Slider Slider_MilitaryAirfield;
	public int Current_MilitaryAirfield;
	public int Max_MilitaryAirfield;

	[Header("Доска (Военный завод)")]
	public float Price_MilitaryFactory;
	public TextMeshProUGUI Price_MilitaryFactory_text;

	public Slider Slider_MilitaryFactory;
	public int Current_MilitaryFactory;
	public int Max_MilitaryFactory;

	private void Start ()
	{
		Current_MolotovCocktails = PlayerPrefs.GetInt("Current_MolotovCocktails");
		Current_ScrapMetal = PlayerPrefs.GetInt("Current_ScrapMetal");  
		Current_NaphthaBase = PlayerPrefs.GetInt("Current_NaphthaBase");  
		Current_MilitaryWarehouse = PlayerPrefs.GetInt("Current_MilitaryWarehouse");  
		Current_MilitaryAirfield = PlayerPrefs.GetInt("Current_MilitaryAirfield");  
		Current_MilitaryFactory = PlayerPrefs.GetInt("Current_MilitaryFactory");    
	}

	// ПЕРВАЯ ДОСКА
	public void Upgrade_MolotovCocktails ()
	{
		if (Money >= Price_MolotovCocktails){
		if (Current_MolotovCocktails < 100)
		{
			Money -= Price_MolotovCocktails;
			Current_MolotovCocktails += 10;
			Income += 10;

			PlayerPrefs.SetFloat("Money", Money);
			PlayerPrefs.SetFloat("Income", Income);
			PlayerPrefs.SetInt ("Current_MolotovCocktails", Current_MolotovCocktails);
		}
		}

		else

		DontHaveMoney_Anim.Play();
	}

	// ВТОРАЯ ДОСКА
	public void Upgrade_ScrapMetal ()
	{
		if (Money >= Price_ScrapMetal){
		if (Current_ScrapMetal < 100)
		{
			Money -= Price_ScrapMetal;
			Current_ScrapMetal += 10;
			Income += 50;

			PlayerPrefs.SetFloat("Money", Money);
			PlayerPrefs.SetFloat("Income", Income);
			PlayerPrefs.SetInt ("Current_ScrapMetal", Current_ScrapMetal);
		}
		}

		else

		DontHaveMoney_Anim.Play();
	}

	// ТРЕТЬЯ ДОСКА
	public void Upgrade_NaphthaBase ()
	{
		if (Money >= Price_NaphthaBase){ 
		if (Current_NaphthaBase < 100)
		{
			Money -= Price_NaphthaBase;
			Current_NaphthaBase += 10;
			Income += 200;

			PlayerPrefs.SetFloat("Money", Money);
			PlayerPrefs.SetFloat("Income", Income);
			PlayerPrefs.SetInt ("Current_NaphthaBase", Current_NaphthaBase);
		}
		}

		else

		DontHaveMoney_Anim.Play();
	}

	// ЧЕТВЕРТАЯ ДОСКА
	public void Upgrade_MilitaryWarehouse ()
	{
		if (Money >= Price_MilitaryWarehouse){ 
		if (Current_MilitaryWarehouse < 100)
		{
			Money -= Price_MilitaryWarehouse;
			Current_MilitaryWarehouse += 10;
			Income += 650;

			PlayerPrefs.SetFloat("Money", Money);
			PlayerPrefs.SetFloat("Income", Income);
			PlayerPrefs.SetInt ("Current_MilitaryWarehouse", Current_MilitaryWarehouse);
		}
		}

		else

		DontHaveMoney_Anim.Play();
	}

	// ПЬЯТАЯ ДОСКА
	public void Upgrade_MilitaryAirfield ()
	{
		if (Money >= Price_MilitaryAirfield){
		if (Current_MilitaryAirfield < 100)
		{
			Money -= Price_MilitaryAirfield;
			Current_MilitaryAirfield += 10;
			Income += 2500;

			PlayerPrefs.SetFloat("Money", Money);
			PlayerPrefs.SetFloat("Income", Income);
			PlayerPrefs.SetInt ("Current_MilitaryAirfield", Current_MilitaryAirfield);
		}
		}

		else

		DontHaveMoney_Anim.Play();
	}

	// ШЕСТАЯ ДОСКА
	public void Upgrade_MilitaryFactory ()
	{
		if (Money >= Price_MilitaryFactory){
		if (Current_MilitaryFactory < 100)
		{
			Money -= Price_MilitaryFactory;
			Current_MilitaryFactory += 10;
			Income += 8500;

			PlayerPrefs.SetFloat("Money", Money);
			PlayerPrefs.SetFloat("Income", Income);
			PlayerPrefs.SetInt ("Current_MilitaryFactory", Current_MilitaryFactory);
		}
		}

		else

		DontHaveMoney_Anim.Play();
	}

	private void Update ()
	{
		Money = PlayerPrefs.GetFloat("Money");

		// Первая доска
		Slider_MolotovCocktails.value = Current_MolotovCocktails;
		Slider_MolotovCocktails.maxValue = Max_MolotovCocktails;
		if (Current_MolotovCocktails == 100){
			Price_MolotovCocktails_text.text = "Все куплено";
		}

		// Вторая доска
		Slider_ScrapMetal.value = Current_ScrapMetal;
		Slider_ScrapMetal.maxValue = Max_ScrapMetal;
		if (Current_ScrapMetal == 100){
			Price_ScrapMetal_text.text = "Все куплено";
		}

		// Третья доска
		Slider_NaphthaBase.value = Current_NaphthaBase;
		Slider_NaphthaBase.maxValue = Max_NaphthaBase;
		if (Current_NaphthaBase == 100){
			Price_NaphthaBase_text.text = "Все куплено";
		}

		// Четвертая доска
		Slider_MilitaryWarehouse.value = Current_MilitaryWarehouse;
		Slider_MilitaryWarehouse.maxValue = Max_MilitaryWarehouse;
		if (Current_MilitaryWarehouse == 100){
			Price_MilitaryWarehouse_text.text = "Все куплено";
		}

		// Пьятая доска
		Slider_MilitaryAirfield.value = Current_MilitaryAirfield;
		Slider_MilitaryAirfield.maxValue = Max_MilitaryAirfield;
		if (Current_MilitaryAirfield == 100){
			Price_MilitaryAirfield_text.text = "Все куплено";
		}

		// Шестая доска
		Slider_MilitaryFactory.value = Current_MilitaryFactory;
		Slider_MilitaryFactory.maxValue = Max_MilitaryFactory;
		if (Current_MilitaryFactory == 100){
			Price_MilitaryFactory_text.text = "Все куплено";
		}
	}
}