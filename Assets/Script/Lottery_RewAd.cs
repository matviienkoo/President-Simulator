using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class Lottery_RewAd : MonoBehaviour
{
    private string RewardedUnitIdd = "ca-app-pub-7285526461578300/9155869248";
    public int int_unity;
    private RewardedAd rewardedAdd;

    public GameObject Lottery_object;
    public Animation lottery_anim;

    public GameObject lottery_object;
    public GameObject transtion_object;
    public Animation transtion;
    public float timer_transtion;
    public int end_lottery;
    public int attemps;
    public int int_lottery_special;
    public string language;

    private void OnEnable()
    {
        rewardedAdd = new RewardedAd(RewardedUnitIdd);
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAdd.LoadAd(adRequest);
        rewardedAdd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {
        if(Lottery_object != null){
        Lottery_object.SetActive(true);
        }
        int attemps = PlayerPrefs.GetInt("attemps");
        attemps = 3;
        PlayerPrefs.SetInt("attemps", attemps);

        lottery_anim.Play ("lottery_anim_back");
    }

    public void ShowAd()
    {
        // admob реклама
        if(language == "Rus" || language == "UA" || language == "eng" || language == "Pl" || language == "De" || language == ""){
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAdd.LoadAd(adRequest);
        if (rewardedAdd.IsLoaded())
            rewardedAdd.Show();
        }
    }

    void Update (){
    int_lottery_special = PlayerPrefs.GetInt("int_lottery_special");
    end_lottery = PlayerPrefs.GetInt("end_lottery");
    int_unity = PlayerPrefs.GetInt("int_unity");
    language = PlayerPrefs.GetString("Lang");
    attemps = PlayerPrefs.GetInt("attemps");

        // если крутки закончились 
        if (int_lottery_special == 1){
        if (end_lottery >= 1){
        if (attemps <= 0)
        {
            timer_transtion += Time.deltaTime;
            if (timer_transtion >= 0.45)
            {
                if(lottery_object != null){
                lottery_object.SetActive(false);
                }
            }
            if (timer_transtion >= 1.15)
            {
                if(transtion_object != null){
                transtion_object.SetActive(false);
                }
                timer_transtion = 0;
                int_lottery_special = 0;
                PlayerPrefs.SetInt("int_lottery_special", int_lottery_special);

                end_lottery = 0;
                PlayerPrefs.SetInt("end_lottery", end_lottery);

            }
        }
        }
        }

// конец Update
}
}