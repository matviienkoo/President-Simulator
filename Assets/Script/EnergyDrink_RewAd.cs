using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class EnergyDrink_RewAd : MonoBehaviour
{
    private string RewardedUnitId = "ca-app-pub-7285526461578300/4066438524";
    private RewardedAd rewardedAd;
    public string language;

    // таймер на энергетике
    public Text energy_text;
    public int energy_int;

    // чмоня перевортиш
    public GameObject Paralise_Object;

    public int energy_effect;

    public Animation energy_drink_anim;
    public Animation lottery_anim;
    public float ADS_timer;

    // спец обозначение
    public int Ad_EnergyDrink;
    public int Int_dont_click_ads_lottery;
    public int Int_dont_click_ads_energetik;
    public float int_random;
    public float bonus_money;
    public float reward_timer;
    public float special_timer;

    // окончание туториала
    int end_tutorial;

    void Start ()
    {
        int_random = UnityEngine.Random.Range (1, 3);
        Debug.Log(int_random);
    }

    private void OnEnable()
    {
        rewardedAd = new RewardedAd(RewardedUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {
        Ad_EnergyDrink = 1;
        PlayerPrefs.SetInt ("Ad_EnergyDrink", Ad_EnergyDrink);

        bonus_money = bonus_money * 2;
        PlayerPrefs.SetFloat("bonus_money", bonus_money);

        energy_int = 25;
        Int_dont_click_ads_energetik = 0;

        energy_effect = 1;
        PlayerPrefs.SetInt ("energy_effect", energy_effect);
    }

    public void ShowAd()
    {
        // admob реклама
        if(language == "Rus" || language == "UA" || language == "eng" || language == "Pl" || language == "De" || language == ""){
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);
        if (rewardedAd.IsLoaded())
            rewardedAd.Show();
        }
    }

    void Update (){
        Ad_EnergyDrink = PlayerPrefs.GetInt("Ad_EnergyDrink");
        energy_effect = PlayerPrefs.GetInt("energy_effect");
        end_tutorial = PlayerPrefs.GetInt("end_tutorial");
        bonus_money = PlayerPrefs.GetFloat("bonus_money"); 
        language = PlayerPrefs.GetString("Lang");

        if (energy_int > 0){

        if(language == "" || language == "eng"){
        energy_text.text = energy_int.ToString () + " seconds";
        }

        if (language == "Rus"){
        energy_text.text = energy_int.ToString () + " секунд";
        }

        if (language == "UA"){
        energy_text.text = energy_int.ToString () + " секунд";
        }

        if (language == "Pl"){
        energy_text.text = energy_int.ToString () + " sekund";
        }

        if (language == "De"){
        energy_text.text = energy_int.ToString () + " sekunden";
        }

        }

        // показ энергетика
        if (end_tutorial >= 1){
        if (int_random == 1){
        if (Int_dont_click_ads_energetik == 0){
        if (Ad_EnergyDrink == 0){
        ADS_timer += Time.deltaTime;
            if (ADS_timer >= 180){
                energy_drink_anim.Play();
                Int_dont_click_ads_energetik = 1;
                ADS_timer = 0;
            } 
        }
        }
        }
        }

        // показ лотереи
        if (end_tutorial >= 1){
        if (int_random == 2){
        if (Int_dont_click_ads_lottery == 0){
        ADS_timer += Time.deltaTime;
            if (ADS_timer >= 180){
                lottery_anim.Play();
                Int_dont_click_ads_lottery = 1;
                ADS_timer = 0;
            } 
        }
        }
        }

        // не нажал на энергетий
        if (end_tutorial >= 1){
        if (Int_dont_click_ads_energetik >= 1){
        reward_timer += Time.deltaTime;
            if (reward_timer >= 20){
                energy_drink_anim.Play("rewarded_energy_back");
                Int_dont_click_ads_energetik = 0;
                int_random = UnityEngine.Random.Range (1, 3);
                reward_timer = 0;
            } 
        }
        }

        // не нажал на лотерею
        if (end_tutorial >= 1){
        if (Int_dont_click_ads_lottery >= 1){
        reward_timer += Time.deltaTime;
            if (reward_timer >= 20){
                lottery_anim.Play("lottery_anim_back");
                Int_dont_click_ads_lottery = 0;
                int_random = UnityEngine.Random.Range (1, 3);
                reward_timer = 0;
            } 
        }
        }

        // окончание энергетика
        if (Ad_EnergyDrink >= 1){
        if(Paralise_Object != null){
        Paralise_Object.SetActive(true);
        }
        reward_timer += Time.deltaTime;
        if (reward_timer >= 24){
            energy_drink_anim.Play("rewarded_energy_back");
        }
        if (reward_timer >= 25){

            bonus_money = bonus_money / 2;

            if(Paralise_Object != null){
            Paralise_Object.SetActive(false);
            }

            reward_timer = 0;
            energy_effect = 0;
            special_timer = 0;
            energy_int = 0;
            Ad_EnergyDrink = 0;
            Int_dont_click_ads_energetik = 0;
            int_random = UnityEngine.Random.Range (1, 3);
            ADS_timer = 0;

            PlayerPrefs.SetInt ("energy_effect", energy_effect);
            PlayerPrefs.SetInt ("Ad_EnergyDrink", Ad_EnergyDrink);
            PlayerPrefs.SetFloat("bonus_money", bonus_money);


        }
        }

        // перевод рекламной панели
        if (Ad_EnergyDrink <= 0){

        if(language == "" || language == "eng"){
        energy_text.text = "acceleration by two times";
        }

        if (language == "Rus"){
        energy_text.text = "ускорение в два раза";
        }

        if (language == "UA"){
        energy_text.text = "прискорення вдвічі";
        }

        if (language == "De"){
        energy_text.text = "Verdoppelung der Geschwindigkeit";
        }

        if (language == "Pl"){
        energy_text.text = "podwojenie prędkości";
        }

        }

        // таймер индикатора отсчета
        if (Ad_EnergyDrink >= 1){
        special_timer += Time.deltaTime;
        if (special_timer >= 1){
            special_timer = 0;
            energy_int -=1;
        }
        }

    // конец Update
    }
    }
