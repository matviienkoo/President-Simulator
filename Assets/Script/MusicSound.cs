using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.SoundManagerNamespace
{

public class MusicSound : MonoBehaviour {

public AudioSource[] SoundAudioSources;
public AudioSource music_audiosorce;
public AudioSource sad_music;

public int end_music_good;
public int end_music;
public int end_tutorial;
public int int_koncovka;
public int int_music;
public float timer;

void Start ()
{
	end_tutorial = PlayerPrefs.GetInt("end_tutorial");
    music_audiosorce.Stop();

    if (end_tutorial >= 1){
   		music_audiosorce.Play();
   		int_music = 1;
   		timer = 0;
    }
}

private void PlaySound(int index)
{
	SoundAudioSources[index].PlayOneShotSoundManaged(SoundAudioSources[index].clip);          
}

// музыка
public void Music()
{
   if (end_tutorial <= 0){
   music_audiosorce.Play();
   int_music = 1;
   }
}

public void CLICK ()
{
	PlaySound(0);
}

void Update (){
end_tutorial = PlayerPrefs.GetInt("end_tutorial");
end_music_good = PlayerPrefs.GetInt("end_music_good");
end_music = PlayerPrefs.GetInt("end_music");

	// повтор музыки
	if (end_music == 0){
	if (end_music_good == 0) {
	if (int_music >= 1){
		timer += Time.deltaTime;
		if (timer >= 181){
   			music_audiosorce.Play();
			timer = 0;
		}
	}
	}
	}

	if (end_music == 1){
		music_audiosorce.Stop();
		PlaySound(1);
		sad_music.Play();
		end_music = 2;
		PlayerPrefs.SetInt ("end_music", end_music);
	}

	if (end_music_good == 1){
		music_audiosorce.Stop();
		PlaySound(1);
		sad_music.Play();
		end_music_good = 2;
		PlayerPrefs.SetInt ("end_music_good", end_music_good);
	}

// конец Update
}
}
}