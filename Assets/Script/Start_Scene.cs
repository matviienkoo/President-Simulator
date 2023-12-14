using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace DigitalRuby.SoundManagerNamespace
{
public class Start_Scene : MonoBehaviour {

	public AudioSource[] SoundAudioSources;

	public GameObject transtion_object;
	public Animation transtion;

	int int_start;
	float timer;

	private void PlaySound(int index)
	{
		SoundAudioSources[index].PlayOneShotSoundManaged(SoundAudioSources[index].clip);          
	}

	public void central_scene_button ()
	{
		if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play();
        int_start = 1;
	}

	public void click ()
	{
		PlaySound(0);
	}

	void Update (){

	if (int_start == 1){
		timer += Time.deltaTime;
		if (timer >= 1){
		timer = 0;
		int_start = 0;
		SceneManager.LoadScene ("central_scene");
		}
	}

	// конец Update
	}
}
}