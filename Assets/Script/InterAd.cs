using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;
using System;

public class InterAd : MonoBehaviour
{
    private string RewardedUnitId = "ca-app-pub-7285526461578300/4452070694";
    private RewardedAd rewardedAd;
    public int intAD;

    private void OnEnable()
    {
        rewardedAd = new RewardedAd(RewardedUnitId);
        AdRequest adRequest = new AdRequest.Builder().Build();
        rewardedAd.LoadAd(adRequest);
        rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    // показ рекламы
    public void ShowAd()
    {
        // admob реклама
        intAD += 1;
        if (intAD >= 10){
            AdRequest adRequest = new AdRequest.Builder().Build();
            rewardedAd.LoadAd(adRequest);
            if (rewardedAd.IsLoaded())
                rewardedAd.Show();

            intAD = 0;
        }
    }

    // награда по рекламе
    private void HandleUserEarnedReward(object sender, Reward e)
    {
        
    }
}