using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Other : MonoBehaviour {

public void Telegram (){
	Application.OpenURL ("https://t.me/deedokk");
}

public void TikTok (){
	Application.OpenURL ("https://vm.tiktok.com/ZMNHo3x1s/");
}

public void PayPal (){
	Application.OpenURL ("https://www.paypal.me/maratmatviienko");
}

public void Copy_Text (){
	GUIUtility.systemCopyBuffer = "5354561540647395";
}

}