using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CutScene : MonoBehaviour
{
[Header("Музыка и Звуки для кат сцены")]
public AudioSource MusicCutScene;

public AudioSource SoundDonetsk;
public AudioSource SoundZelensky;
public AudioSource SoundPutin;

[Header("Экран который показывается при кат сцене")]
public GameObject CutSceneDonetsk;
public GameObject CutSceneZelensky;
public GameObject CutScenePutin;

[Header("Обьекты для перехода")]
public bool Timer_Bool;
public float Timer;
public float Timer_CutScene;
public int Int_CutScene;
public TextMeshProUGUI Text_CutScene;

[Header("Обьекты для перехода")]
public TranstionTutorialScript TranstionScr;
public GameObject Transtion_Object;
public Animation Transtion_Animation;

[Header("Выбор Языка")]
public string Language;
    
    IEnumerator LetterCutScene() 
    {
        var originalString = Text_CutScene.text;
        Text_CutScene.text = "";

        var numCharsRevealed = 0;
        while (numCharsRevealed < originalString.Length)
        {
            ++numCharsRevealed;
            Text_CutScene.text = originalString.Substring(0, numCharsRevealed);

            yield return new WaitForSeconds(0.07f);
        }
    }

    public void CutSceneSystem ()
    {
        Language = PlayerPrefs.GetString("Lang");

        // --- Первая сцена
        if (Int_CutScene == 0)
        {
            ChangeCutScene();

            if(Language == "" || Language == "English"){
            Text_CutScene.text = "351 votes of deputies out of 450 were in favor of immediately sending the president with a request to recognize the dnr. and lnr.";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "Russia"){
            Text_CutScene.text = "351 голос депутатов из 450 высказались за немедленное направление президенту с просьбой признать днр. и лнр.";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "Ukraine"){
            Text_CutScene.text = "351 голос депутатів із 450 висловилися за негайний напрямок президенту з проханням визнати днр. та лнр.";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "Polish"){
            Text_CutScene.text = "351 głosujących posłów z 450 opowiedziało się za natychmiastowym skierowaniem do prezydenta z prośbą o uznanie dnr. i lnr.";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "German"){
            Text_CutScene.text = "351 stimmen der abgeordneten von 450 sprachen sich dafür aus, den präsidenten sofort mit der bitte um anerkennung der dnr. und lnr.";
            StartCoroutine(LetterCutScene());
            }
        }

        // --- Вторая сцена
        if (Int_CutScene == 1)
        {
            ChangeCutScene();

            if(Language == "" || Language == "English"){
            Text_CutScene.text = "today I initiated a telephone conversation with the president of the russian, the result is silence, although silence should be in the donbass";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "Russia"){
            Text_CutScene.text = "сегодня я инициировал телефонный разговор с президентом российской федерации, результат тишина, хотя тишина должна быть на донбассе";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "Ukraine"){
            Text_CutScene.text = "сьогодні я ініціював телефонну розмову з президентом російської федерації, результат тиша, хоча тиша має бути на донбасі";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "Polish"){
            Text_CutScene.text = "dzisiaj zainicjowałem rozmowę telefoniczną z prezydentem federacji rosyjskiej, rezultatem jest cisza, chociaż w donbasie powinna być cisza";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "German"){
            Text_CutScene.text = "heute habe ich ein telefongespräch mit dem präsidenten der russischen föderation eingeleitet, das ergebnis ist stille, obwohl im donbass stille herrschen sollte";
            StartCoroutine(LetterCutScene());
            }
        }

        // --- Третья сцена
        if (Int_CutScene == 2)
        {
            ChangeCutScene();

            if(Language == "" || Language == "English"){
            Text_CutScene.text = "and in pursuance of the treaty of friendship and mutual assistance with the dnr. and lnr. ratified by the federal assembly on February 22 this year. I have decided to conduct a special military operation";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "Russia"){
            Text_CutScene.text = "и во исполнение ратифицированных федеральным собранием 22 февраля этого года договора о дружбе и взаимопомощи с днр. и лнр. мною принято решение о проведении специальной военной операции";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "Ukraine"){
            Text_CutScene.text = "та на виконання ратифікованих федеральними зборами 22 лютого цього року договору про дружбу та взаємодопомогу з днр. та лнр. мною ухвалено рішення про проведення спеціальної військової операції";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "Polish"){
            Text_CutScene.text = "i na mocy traktatów o przyjaźni i wzajemnej pomocy z dnr. i lnr. ratyfikowanych przez zgromadzenie federalne 22 lutego postanowiłem przeprowadzić specjalną operację wojskową";
            StartCoroutine(LetterCutScene());
            }

            if (Language == "German"){
            Text_CutScene.text = "und aufgrund des von der bundesversammlung am 22. februar dieses jahres ratifizierten freundschafts und beistandsvertrages mit der dnr. und lnr. Ich habe beschlossen, eine spezielle Militäroperation durchzuführen";
            StartCoroutine(LetterCutScene());
            }
        }
    }

    public void ChangeCutScene ()
    {
        // --- Третья сцена
        if (Timer_Bool == false){
        if (Int_CutScene == 2)
        {
            // Изменение экрана, и очистка сцены от текста
            CutSceneDonetsk.SetActive(false);
            CutSceneZelensky.SetActive(false);
            CutScenePutin.SetActive(true);

            // Таймер 
            Timer_CutScene = 18;
            Timer_Bool = true;

            // Звуки
            SoundPutin.Play();
        }
        }

        // --- Вторая сцена
        if (Timer_Bool == false){
        if (Int_CutScene == 1)
        {   
            // Изменение экрана, и очистка сцены от текста
            CutSceneDonetsk.SetActive(false);
            CutSceneZelensky.SetActive(true);
            CutScenePutin.SetActive(false);

            // Таймер 
            Timer_CutScene = 11;
            Timer_Bool = true;

            // Звуки
            SoundZelensky.Play();
        }
        }

        // --- Первая сцена
        if (Timer_Bool == false){
        if (Int_CutScene == 0)
        {
            // Изменение экрана, и очистка сцены от текста
            CutSceneDonetsk.SetActive(true);
            CutSceneZelensky.SetActive(false);
            CutScenePutin.SetActive(false);

            // Таймер 
            Timer_CutScene = 15;
            Timer_Bool = true;

            // Музыка для кат сцены, и звуки
            SoundDonetsk.Play();
            MusicCutScene.Play();
        }
        }
    }

    public void SkipCutScene ()
    {
        // Обнуление
        Timer_Bool = false;
        Int_CutScene = 0;
        Timer = 0;

        // Отключение аудио 
        MusicCutScene.Stop();
        SoundDonetsk.Stop();
        SoundZelensky.Stop();
        SoundPutin.Stop();

        // Выключеные кат-сцены
        TranstionScr.Closed_All();
    }

    private void Update ()
    {   
        // Определение того сколько будет работать кат сцена 
        if (Timer_Bool == true){
        Timer += Time.deltaTime;
        if (Timer >= Timer_CutScene)
        {
            // Переход на новую кат сцену
            Int_CutScene += 1;

            // Перезапуск параметров
            Timer_Bool = false;
            Timer = 0;

            // Запуск переходной сцены, и закртые всего после окончания 
            if (Int_CutScene == 3){
            MusicCutScene.Stop();
            TranstionScr.Closed_All();
            }

            else
            
            TranstionScr.Switching_Intial_CutScene();
        }
        }
    }
}
    



