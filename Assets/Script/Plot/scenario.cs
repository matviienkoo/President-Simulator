using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DigitalRuby.SoundManagerNamespace
{
public class scenario : MonoBehaviour
{
// for Maps and News
public int Maps_News_int;

float snacala_timer;
public int SNACALA_ZAPOMNI;
public int SNACALA;
public GameObject SNACALA_OBJECT;
public Text SNACALA_TEXT;

int xui_snacala;
int fack_cock;
float end_timer;
float end_timer_good;
public Text end_scene_text;
public GameObject end_scene;
public GameObject end_scene_good;
int int_konec_scenario;

public AudioSource[] SoundAudioSources;
public string language; 

// ПАНЕЛЬ АКТИВНАЯ КАРТА, И ЕЕ ГЛАВНЫЙ ТЕКСТ -----------------------------
public GameObject Osnova_Active_Maps_object;
public Text Osnova_Active_Maps_text;

// - первое решение активной карты
public GameObject maps_tv_first_true;
public GameObject maps_tv_first_false;

public GameObject maps_tv_second_true;
public GameObject maps_tv_second_false;

public GameObject maps_tv_thirt_true;
public GameObject maps_tv_thirt_false;

public GameObject maps_tv_four_true;
public GameObject maps_tv_four_false;

public GameObject maps_tv_five_true;
public GameObject maps_tv_five_false;

public GameObject maps_tv_six_true;
public GameObject maps_tv_six_false;

public GameObject maps_tv_seven_true;
public GameObject maps_tv_seven_false;

public GameObject maps_tv_eight_true;
public GameObject maps_tv_eight_false;

public GameObject maps_tv_nine_true;
public GameObject maps_tv_nine_false;

public GameObject maps_tv_ten_true;
public GameObject maps_tv_ten_false;

public GameObject maps_tv_eleven_true;
public GameObject maps_tv_eleven_false;

public GameObject maps_tv_twelve_true;
public GameObject maps_tv_twelve_false;

public GameObject maps_tv_thirteen_true;
public GameObject maps_tv_thirteen_false;

public GameObject maps_tv_fourteen_true;
public GameObject maps_tv_fourteen_false;


// ПАНЕЛЬ СЦЕНАРИЙ, И ЕЕ ГЛАВНЫЙ ТЕКСТ -----------------------------
public GameObject Osnova_Scenario_object;
public GameObject Osnova_Scenario_object_background;
public Text Osnova_Scenario_text;

// - первое решение панели сценария
public GameObject TV_start_war_panel;
public GameObject TV_lukashenko_war_panel;
public GameObject TV_bidon_war_panel;
public GameObject TV_ostrov_war_panel;
public GameObject TV_chernobyl_war_panel;
public GameObject TV_borisjhonson_war_panel;
public GameObject TV_mrija_war_panel;
public GameObject TV_jadrn_zdrv_war_panel;
public GameObject TV_zjs_war_panel;
public GameObject TV_economica_war_panel;
public GameObject TV_mariupol_war_panel;

// the bad end
public GameObject TV_kiva_war_panel;

// the good end
public GameObject TV_arestovych_war_panel;

// ПАНЕЛЬ КАТ-СЦЕНА СЦЕНАРИЯ, И ЕЕ ГЛАВНЫЙ ТЕКСТ -----------------------------
public GameObject Osnova_Plot_Scenario_object;
public Text Osnova_Plot_Scenario_text;

// - первое решение кат-сцены сценария
public GameObject TV_gordon;
public GameObject TV_spec_gordon;
public GameObject TV_bidon;
public GameObject TV_ostrov;
public GameObject TV_chernobyl;
public GameObject TV_jonhsonboris;
public GameObject TV_mrija;
public GameObject TV_jadrn_zdrv;
public GameObject TV_zjs;
public GameObject TV_economica;
public GameObject TV_mariupol;
public GameObject TV_kiva;
public GameObject TV_arestovych;

// ТЕКСТ ВЫБОРА ПЕРВОГО РЕШЕНИЯ
public Text first_choice_text_black;
public Text first_choice_text;

// ТЕКСТ ВЫБОРА ВТОРОГО РЕШЕНИЯ
public Text second_choice_text_black;
public Text second_choice_text;

// ТЕКСТ ВЫБОРА ТРЕТЬЕГО РЕШЕНИЯ
public GameObject object_thirt_choice;
public GameObject object_thirt_choice_black;
public Button button_thirt_choice;
public Text thirt_choice_text_black;
public Text thirt_choice_text;

// ТЕКСТ ВЫБОРА ЧЕТВЕРТОГО РЕШЕНИЯ
public GameObject object_four_choice;
public GameObject object_four_choice_black;
public Button button_four_choice;
public Text four_choice_text_black;
public Text four_choice_text;

// РЕПУТАЦИЯ, И ПРИНЯТИЕ РЕШЕНИЯ
public int decision_making;
public int reputation;

// панели которую нужно закрыть после окончания туториала
public GameObject Start_Plot;
public GameObject Select_Language;
public GameObject Page_last;
public int end_tutorial;

// переходной обьект
public GameObject transtion_object;
public Animation transtion;
float timer_transtion;
int closed_all;

// закрыть возможность клика
public GameObject Object_dont_touch;
int int_dont_touch;
public float timer_dont_touch;
public float recist_timer_dont_touch;

// очки для систими продвижения
public float float_amount_ammintion;
public float OCKOV;
int int_promotion;
float timer_promotion;

// - показывает сколько до следующей сюжетной ставки
public Slider plot_bar;
public float current_plot;
public float max_plot;
public int int_special_plot; // считает количество потраченных денег на армию 

// если игрок решит выйти среди кат-сцены 
public int int_koncovka;
public int end_music;
public int end_music_good;
int SPEC_TEXT;
float SPEC_TIMER;

int int_second;
int int_thirt;
int int_four;
int int_five;
int int_six;
int int_seven;
int int_eight;
int int_nine;
int int_ten;
int int_eleven;
int int_twelve;
int int_thirteen;
int int_fourteen;
int int_fiveteen;
int int_sixteen;
int int_seventeen;
int int_eightteen;
int int_nineteen;
int int_twenty;
int int_twenty_one;
int int_twenty_two;
int int_twenty_three;
int int_twenty_four;
int int_twenty_five;

// выключает первый обьект
public int int_start;
public GameObject start_transtion;
public Animation start_animation;
float start_timer;

    
    void Start (){
    end_tutorial = PlayerPrefs.GetInt("end_tutorial");
    current_plot = PlayerPrefs.GetInt("current_plot");
    // выключает первый обьект
    int_start = 1;

    // если не кончился туториал, то все обнуляется
    if (end_tutorial <= 0){
    PlayerPrefs.DeleteAll();
    current_plot = 100;
    PlayerPrefs.SetFloat ("current_plot", current_plot);

    // выключает первый обьект
    int_start = 1;
    }

    }

    public void snacala_nacat (){
        
        if (xui_snacala <= 0){
        if(language == "" || language == "eng"){
        SNACALA_TEXT.text = "restart the application";
        StartCoroutine(SNACALA_Apperance());
        }

        if (language == "Rus"){
        SNACALA_TEXT.text = "перезапустите приложение";
        StartCoroutine(SNACALA_Apperance());
        }

        if (language == "UA"){
        SNACALA_TEXT.text = "перезапустіть програму";
        StartCoroutine(SNACALA_Apperance());
        }

        PlayerPrefs.DeleteAll();
        xui_snacala = 1;
        }
    }

    public void KONEC (){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_koncovka = 0;
        int_special_plot = 11;
        int_promotion = 35;
        PlayerPrefs.SetInt ("int_koncovka", int_koncovka);  
        PlayerPrefs.SetInt ("int_special_plot", int_special_plot);  
        PlayerPrefs.SetInt ("int_promotion", int_promotion);  
    }

    private void PlaySound(int index)
    {
        SoundAudioSources[index].PlayOneShotSoundManaged(SoundAudioSources[index].clip);          
    }

    IEnumerator Scenario_Apperance () {
    var originalString = Osnova_Scenario_text.text;
    Osnova_Scenario_text.text = "";

    var numCharsRevealed = 0;
    while (numCharsRevealed < originalString.Length)
        {
        ++numCharsRevealed;
        Osnova_Scenario_text.text = originalString.Substring(0, numCharsRevealed);

        yield return new WaitForSeconds(0.07f);
        }
    }

    IEnumerator Scenario_Plot_Apperance () {
    var originalString = Osnova_Plot_Scenario_text.text;
    Osnova_Plot_Scenario_text.text = "";

    var numCharsRevealed = 0;
    while (numCharsRevealed < originalString.Length)
        {
        ++numCharsRevealed;
        Osnova_Plot_Scenario_text.text = originalString.Substring(0, numCharsRevealed);

        yield return new WaitForSeconds(0.07f);
        }
    }

    IEnumerator Maps_Change_Apperance() {
    var originalString = Osnova_Active_Maps_text.text;
    Osnova_Active_Maps_text.text = "";

    var numCharsRevealed = 0;
    while (numCharsRevealed < originalString.Length)
        {
        ++numCharsRevealed;
        Osnova_Active_Maps_text.text = originalString.Substring(0, numCharsRevealed);

        yield return new WaitForSeconds(0.07f);
        }
    }

    IEnumerator end_text_Apperance() {
    var originalString = end_scene_text.text;
    end_scene_text.text = "";

    var numCharsRevealed = 0;
    while (numCharsRevealed < originalString.Length)
        {
        ++numCharsRevealed;
        end_scene_text.text = originalString.Substring(0, numCharsRevealed);

        yield return new WaitForSeconds(0.07f);
        }
    }

    IEnumerator SNACALA_Apperance() {
    var originalString = SNACALA_TEXT.text;
    SNACALA_TEXT.text = "";

    var numCharsRevealed = 0;
    while (numCharsRevealed < originalString.Length)
        {
        ++numCharsRevealed;
        SNACALA_TEXT.text = originalString.Substring(0, numCharsRevealed);

        yield return new WaitForSeconds(0.07f);
        }
    }

    public void first_choice (){
        if (decision_making == 1){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // первая тру карта
        reputation = 1;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 3;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 2){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // вторая тру карта
        reputation = 3;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 8;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 3){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // третья тру карта
        reputation = 5;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 13;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 4){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // четвертая тру карта
        reputation = 7;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 16;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 5){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 9;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 19;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 6){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 11;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 22;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 7){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая fall карта
        reputation = 14;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 25;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 8){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 15;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 28;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 9){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 17;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 31;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 10){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая true карта
        reputation = 19;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 34;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 11){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая false карта
        reputation = 22;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 37;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        int_koncovka = 1;
        PlayerPrefs.SetInt ("int_koncovka", int_koncovka); 

        }

        if (int_koncovka == 1){
        if (decision_making == 12){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 40;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        int_koncovka = 1;
        PlayerPrefs.SetInt ("int_koncovka", int_koncovka); 

        }
        }

        if (int_koncovka == 2){
        if (decision_making == 12){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 40;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        int_koncovka = 2;
        PlayerPrefs.SetInt ("int_koncovka", int_koncovka); 

        }
        }
    }

    public void second_choice (){
        if (decision_making == 1){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // первая тру карта
        reputation = 1;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 3;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 2){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // вторая фолс карта
        reputation = 4;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 8;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 3){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // третья фолс карта
        reputation = 6;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 13;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 4){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // четвертая фолс карта
        reputation = 8;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 16;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }   

        if (decision_making == 5){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая фолс карта
        reputation = 10;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 19;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 6){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 11;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 22;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 7){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 13;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 25;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 8){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая fall карта
        reputation = 16;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 28;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 9){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая fall карта
        reputation = 18;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 31;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 10){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая true карта
        reputation = 19;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 34;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 11){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая false карта
        reputation = 21;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 37;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        int_koncovka = 2;
        PlayerPrefs.SetInt ("int_koncovka", int_koncovka); 

        }

        if (int_koncovka == 1){
        if (decision_making == 12){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 40;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        int_koncovka = 1;
        PlayerPrefs.SetInt ("int_koncovka", int_koncovka); 

        }
        }

        if (int_koncovka == 2){
        if (decision_making == 12){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 40;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        int_koncovka = 2;
        PlayerPrefs.SetInt ("int_koncovka", int_koncovka); 

        }
        }
    }

    public void thirt_choice (){
        if (decision_making == 1){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // первая фолс карта
        reputation = 2;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 3;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 3){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // третья тру карта
        reputation = 5;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 13;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        } 

        if (decision_making == 4){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // четвертая тру карта
        reputation = 7;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 16;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 5){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 9;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 19;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 6){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая фолс карта
        reputation = 12;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 22;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 7){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 14;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 25;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 8){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 15;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 28;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 10){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая true карта
        reputation = 19;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 34;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }
    }

    public void four_choice (){
        if (decision_making == 1){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // первая фолс карта
        reputation = 2;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 3;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        } 

        if (decision_making == 3){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // третья фолс карта
        reputation = 6;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 13;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        } 

        if (decision_making == 4){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // четвертая фолс карта
        reputation = 8;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 16;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 5){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая фолс карта
        reputation = 10;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 19;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 6){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая фолс карта
        reputation = 12;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 22;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 7){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 13;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 25;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 8){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая good карта
        reputation = 16;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 28;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }

        if (decision_making == 10){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        // пятая fall карта
        reputation = 20;
        PlayerPrefs.SetInt ("reputation", reputation);

        int_promotion = 34;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        }
    }

    public void closed_scenario_object (){
        if (int_konec_scenario == 0){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        if (end_tutorial == 0){
        max_plot = 3000;
        PlayerPrefs.SetFloat ("max_plot", max_plot);

        int_special_plot = 1;
        PlayerPrefs.SetInt ("int_special_plot", int_special_plot);
        }

        closed_all = 1;
        end_tutorial = 1;
        PlayerPrefs.SetInt ("end_tutorial", end_tutorial);
        }
        // ----
        if (int_konec_scenario == 1){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 43;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        end_music = 1;
        PlayerPrefs.SetInt ("end_music", end_music); 

        SNACALA = 1;

        SNACALA_ZAPOMNI = 1;
        PlayerPrefs.SetInt ("SNACALA_ZAPOMNI", SNACALA_ZAPOMNI); 
        }

        if (int_konec_scenario == 2){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 43;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 

        end_music_good = 1;
        PlayerPrefs.SetInt ("end_music_good", end_music_good); 

        SNACALA = 1;

        SNACALA_ZAPOMNI = 1;
        PlayerPrefs.SetInt ("SNACALA_ZAPOMNI", SNACALA_ZAPOMNI); 
        }
    }

    public void closed_plot_scnerio (){
        if (int_special_plot == 2){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 6;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 3){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 11;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 4){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 15;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 5){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 18;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 6){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 21;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 7){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 24;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 8){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 27;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 9){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 30;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 10){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 33;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 11){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 36;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }

        if (int_special_plot == 12){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        int_promotion = 39;
        PlayerPrefs.SetInt ("int_promotion", int_promotion); 
        }
    }

    // ----------------------------UPDATE----------------------------

    void Update (){
    float_amount_ammintion = PlayerPrefs.GetFloat("float_amount_ammintion");
    int_special_plot = PlayerPrefs.GetInt("int_special_plot");
    int_koncovka = PlayerPrefs.GetInt("int_koncovka");
    end_music_good = PlayerPrefs.GetInt("end_music_good");
    SNACALA_ZAPOMNI = PlayerPrefs.GetInt("SNACALA_ZAPOMNI");
    end_music = PlayerPrefs.GetInt("end_music");
    max_plot = PlayerPrefs.GetFloat("max_plot");
    reputation = PlayerPrefs.GetInt("reputation");
    end_tutorial = PlayerPrefs.GetInt("end_tutorial");
    Maps_News_int = PlayerPrefs.GetInt("Maps_News_int");
    language = PlayerPrefs.GetString("Lang");
    int_promotion = PlayerPrefs.GetInt("int_promotion");
    decision_making = PlayerPrefs.GetInt("decision_making");

    current_plot = PlayerPrefs.GetFloat("current_plot");
    plot_bar.value = current_plot;
    plot_bar.maxValue = max_plot;

    // конец туториала (выключает стартовые обьекты)
    if (end_tutorial >= 1){
        if(Start_Plot != null){
        Start_Plot.SetActive(false);
        }
        if(Select_Language != null){
        Select_Language.SetActive(false);
        }
        if(Page_last != null){
        Page_last.SetActive(false);
        }
    }

    // выключает первый обьект
    if (int_start == 1){
        start_animation.Play();
        int_start = 2;
    }

    if (int_start == 2){
        start_timer += Time.deltaTime;
        if (start_timer >= 0.34){

        if(start_transtion != null){
        start_transtion.SetActive(false);
        }
        start_timer = 0;
        int_start = 0;
        }
    }

    // система систематического перехода (что бы нельзя было ничего нажать)
    if (int_dont_touch == 1){
        if(Object_dont_touch != null){
        Object_dont_touch.SetActive(true);
        }
        timer_dont_touch += Time.deltaTime;
        if (timer_dont_touch >= recist_timer_dont_touch){

        if(Object_dont_touch != null){
        Object_dont_touch.SetActive(false);
        }
        int_dont_touch = 0;
        timer_dont_touch = 0;
        recist_timer_dont_touch = 0;

        if (int_second >= 1){
            if(TV_spec_gordon != null){
            TV_spec_gordon.SetActive(true);
            }
        }

        }
    }

    // ПЕРВОЕ ВКЛЮЧЕНИЕ СЦЕНАРИЯ (ТУТОРИАЛ)
    if (int_promotion == 0){
    if (float_amount_ammintion <= 4499999){

        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion"); 

        int_promotion = 1;
        PlayerPrefs.SetInt ("int_promotion", int_promotion);  

    }
    }

    // ПРОДВИЖЕНИЕ ПЕРВОГО СЦЕНАРИЯ (ТУТОРИАЛ)
    if (int_promotion == 1){
    timer_promotion += Time.deltaTime;
    if (timer_promotion >= 0.45)
    {
        if(Osnova_Scenario_object != null){
        Osnova_Scenario_object.SetActive(true);
        }
        if(TV_start_war_panel != null){
        TV_start_war_panel.SetActive(true);
        }

        if(language == "" || language == "eng"){
        // обичный текст
        first_choice_text.text = "announce mobilization";
        second_choice_text.text = "ask for help in europe";
        thirt_choice_text.text = "go to negotiations";
        four_choice_text.text = "postpone decision";

        // черный текст
        first_choice_text_black.text = "announce mobilization";
        second_choice_text_black.text = "ask for help in europe";
        thirt_choice_text_black.text = "go to negotiations";
        four_choice_text_black.text = "postpone decision";
        }

        if (language == "Rus"){
        // обичный текст
        first_choice_text.text = "объявить мобилизацию";
        second_choice_text.text = "попросить помощь у запада";
        thirt_choice_text.text = "пойти на переговоры";
        four_choice_text.text = "отложить решение";

        // черный текст
        first_choice_text_black.text = "объявить мобилизацию";
        second_choice_text_black.text = "попросить помощь у запада";
        thirt_choice_text_black.text = "пойти на переговоры";
        four_choice_text_black.text = "отложить решение";
        }

        if (language == "UA"){
        // обичный текст
        first_choice_text.text = "оголосити мобілізацію";
        second_choice_text.text = "попросити допомогу у заходу";
        thirt_choice_text.text = "піти на переговори";
        four_choice_text.text = "відкласти рішення";

        // черный текст
        first_choice_text_black.text = "оголосити мобілізацію";
        second_choice_text_black.text = "попросити допомогу у заходу";
        thirt_choice_text_black.text = "піти на переговори";
        four_choice_text_black.text = "відкласти рішення";
        }

        if (language == "De"){
        // обичный текст
        first_choice_text.text = "mobilisierung ankündigen";
        second_choice_text.text = "пhilfe in europa suchen";
        thirt_choice_text.text = "zu verhandlungen gehen";
        four_choice_text.text = "entscheidung verschieben";

        // черный текст
        first_choice_text_black.text = "mobilisierung ankündigen";
        second_choice_text_black.text = "пhilfe in europa suchen";
        thirt_choice_text_black.text = "zu verhandlungen gehen";
        four_choice_text_black.text = "entscheidung verschieben";
        }

        if (language == "Pl"){
        // обичный текст
        first_choice_text.text = "ogłosić mobilizację";
        second_choice_text.text = "poproś o pomoc w Europie";
        thirt_choice_text.text = "idź do negocjacji";
        four_choice_text.text = "odroczenie decyzji";

        // черный текст
        first_choice_text_black.text = "ogłosić mobilizację";
        second_choice_text_black.text = "poproś o pomoc w Europie";
        thirt_choice_text_black.text = "idź do negocjacji";
        four_choice_text_black.text = "odroczenie decyzji";
        }
    }

    if (timer_promotion >= 1.15)
    {
        if(transtion_object != null){
        transtion_object.SetActive(false);
        }
        PlaySound(0);

        // окончить продвижение ( после включение панели выбора )
        int_promotion = 2;

        // включить панель которая закрывает ( и не дает никуда нажимать )
        int_dont_touch = 1;

        // дать возможность выбрать первые четыре варианта
        decision_making = 1;

        // поставить таймера во время которого нельзя будет ничего трогать 
        recist_timer_dont_touch = 5;

        timer_promotion = 0;
        PlayerPrefs.SetInt ("int_promotion", int_promotion);  
        PlayerPrefs.SetInt ("decision_making", decision_making);  

        if(language == "" || language == "eng"){
        Osnova_Scenario_text.text = "enemy vehicles have crossed your border, what decision will you make?";
        StartCoroutine(Scenario_Apperance());
        }

        if (language == "Rus"){
        Osnova_Scenario_text.text = "вражеская техника пересекла вашу границу, какое решение вы примите?";
        StartCoroutine(Scenario_Apperance());
        }

        if (language == "UA"){
        Osnova_Scenario_text.text = "ворожа техніка перетнула ваш кордон, яке рішення ви ухвалите?";
        StartCoroutine(Scenario_Apperance());
        }

        if (language == "De"){
        Osnova_Scenario_text.text = "die feindliche Ausrüstung hat die Grenze Ihres Landes überschritten, welche Entscheidung treffen Sie?";
        StartCoroutine(Scenario_Apperance());
        }

        if (language == "Pl"){
        Osnova_Scenario_text.text = "sprzęt wroga przekroczył granicę twojego kraju, jaką decyzję podejmujesz?";
        StartCoroutine(Scenario_Apperance());
        }

    }
    }

    // КОНЕЦ ПЕРВОГО СЦЕНАРИЯ (КАРТА ПОСЛЕ РЕШЕНИЯ)
    if (int_promotion == 3){
    timer_promotion += Time.deltaTime;
    if (timer_promotion >= 0.45)
    {
        if(Osnova_Scenario_object != null){
        Osnova_Scenario_object.SetActive(false);
        }
        if(Osnova_Active_Maps_object != null){
        Osnova_Active_Maps_object.SetActive(true);
        }

        if (reputation == 1){
        // карта правильно выбора
        if(maps_tv_first_true != null){
        maps_tv_first_true.SetActive(true);
        }
        if(maps_tv_first_false != null){
        maps_tv_first_false.SetActive(false);
        }

        Maps_News_int = 1;
        PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

        }

        if (reputation == 2){
        // карта НЕ правильно выбора
        if(maps_tv_first_true != null){
        maps_tv_first_true.SetActive(false);
        }
        if(maps_tv_first_false != null){
        maps_tv_first_false.SetActive(true);
        }

        Maps_News_int = 2;
        PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  
        }
    }

    if (timer_promotion >= 1.15){

        // выключить на время все кнопки
        recist_timer_dont_touch = 5;
        int_dont_touch = 1;

        // плохой исход
        if (reputation == 2){
            
        if(transtion_object != null){
        transtion_object.SetActive(false);
        }

        if(language == "" || language == "eng"){
        Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
        StartCoroutine(Maps_Change_Apperance());
        }

        if (language == "Rus"){
        Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
        StartCoroutine(Maps_Change_Apperance());
        }

        if (language == "UA"){
        Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
        StartCoroutine(Maps_Change_Apperance());
        }

        if (language == "De"){
        Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
        StartCoroutine(Maps_Change_Apperance());
        }

        if (language == "Pl"){
        Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
        StartCoroutine(Maps_Change_Apperance());
        }

        int_promotion = 4;
        timer_promotion = 0;
        PlayerPrefs.SetInt ("int_promotion", int_promotion);  

        }

        // хороший исход
        if (reputation == 1){

        if(transtion_object != null){
        transtion_object.SetActive(false);
        }

        if(language == "" || language == "eng"){
        Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
        StartCoroutine(Maps_Change_Apperance());
        }

        if (language == "Rus"){
        Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
        StartCoroutine(Maps_Change_Apperance());
        }

        if (language == "UA"){
        Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
        StartCoroutine(Maps_Change_Apperance());
        }

        if (language == "De"){
        Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
        StartCoroutine(Maps_Change_Apperance());
        }

        if (language == "Pl"){
        Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
        StartCoroutine(Maps_Change_Apperance());
        }

        int_promotion = 4;
        timer_promotion = 0;
        PlayerPrefs.SetInt ("int_promotion", int_promotion);  
        }
    }
    }

    // ВТОРАЯ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_second <= 0){
    if (int_special_plot == 2){
    if (int_promotion == 4){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(true);
            }
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "enemy equipment passed through Belarus";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "через беларусь прошла вражеская техника";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "через білорусь пройшла ворожа техніка";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "przez białoruś przeszedł sprzęt wroga";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "durch Weißrussland ging feindliche Technik";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(1);

            // включает панель в случаи перезахода
            int_second = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 11;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ВТОРАЯ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_thirt <= 0){
    if (int_special_plot == 2){
    if (int_promotion == 6){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }
            if(Osnova_Scenario_object_background != null){
            Osnova_Scenario_object_background.SetActive(true);
            }
            if(object_thirt_choice != null){
            object_thirt_choice.SetActive(false);
            }
            if(object_thirt_choice_black != null){
            object_thirt_choice_black.SetActive(false);
            }
            if(object_four_choice != null){
            object_four_choice.SetActive(false);
            }
            if(object_four_choice_black != null){
            object_four_choice_black.SetActive(false);
            }
            if(TV_lukashenko_war_panel != null){
            TV_lukashenko_war_panel.SetActive(true);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            button_thirt_choice.interactable = false;
            button_four_choice.interactable = false;

            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "Kyiv";
            second_choice_text.text = "Donetsk";

            // черный текст
            first_choice_text_black.text = "Kyiv";
            second_choice_text_black.text = "Donetsk";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "Киев";
            second_choice_text.text = "Донецк";

            // черный текст
            first_choice_text_black.text = "Киев";
            second_choice_text_black.text = "Донецк";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "Київ";
            second_choice_text.text = "Донецьк";

            // черный текст
            first_choice_text_black.text = "Київ";
            second_choice_text_black.text = "Донецьк";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "Kijów";
            second_choice_text.text = "Donieck";

            // черный текст
            first_choice_text_black.text = "Kijów";
            second_choice_text_black.text = "Donieck";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "Kiew";
            second_choice_text.text = "Donezk";

            // черный текст
            first_choice_text_black.text = "Kiew";
            second_choice_text_black.text = "Donezk";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "which region to prioritize?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "на какой из регионов поставить приоритет?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "на який із регіонів поставити пріоритет?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "który z regionów ma pierwszeństwo?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "welche Region hat Priorität?";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_thirt = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 4;

            // дать возможность выбрать первые два варианта
            decision_making = 2;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ВТОРАЯ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 2){
    if (int_promotion == 8){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(TV_spec_gordon != null){
            TV_spec_gordon.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object_background != null){
            Osnova_Scenario_object_background.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }
            if(TV_lukashenko_war_panel != null){
            TV_lukashenko_war_panel.SetActive(false);
            }

            if(object_thirt_choice != null){
            object_thirt_choice.SetActive(true);
            }
            if(object_thirt_choice_black != null){
            object_thirt_choice_black.SetActive(true);
            }
            if(object_four_choice != null){
            object_four_choice.SetActive(true);
            }
            if(object_four_choice_black != null){
            object_four_choice_black.SetActive(true);
            }

            button_thirt_choice.interactable = true;
            button_four_choice.interactable = true;

            if (reputation == 4){
            // карта bad
            if(maps_tv_first_true != null){
            maps_tv_first_true.SetActive(false);
            }
            if(maps_tv_first_false != null){
            maps_tv_first_false.SetActive(false);
            }
            if(maps_tv_second_true != null){
            maps_tv_second_true.SetActive(false);
            }
            if(maps_tv_second_false != null){
            maps_tv_second_false.SetActive(true);
            }

            Maps_News_int = 3;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 3){
            // карта good
            if(maps_tv_first_true != null){
            maps_tv_first_true.SetActive(false);
            }
            if(maps_tv_first_false != null){
            maps_tv_first_false.SetActive(false);
            }
            if(maps_tv_second_true != null){
            maps_tv_second_true.SetActive(true);
            }
            if(maps_tv_second_false != null){
            maps_tv_second_false.SetActive(false);
            }

            Maps_News_int = 4;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 4){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 9;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 3){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 9;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // ТРЕТЬЕ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_four <= 0){
    if (int_special_plot == 3){
    if (int_promotion == 9){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(true);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "putin is the aggressor. putin chose this war and now, he and his country will bear the consequences. today, I am announcing additional enhanced sanctions.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "путин - агрессор. путин выбрал эту войну и теперь, он и его страна понесут последствие. сегодня я объявляю дополнительные усиленные санкции.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "путін – агресор. путін обрав цю війну і тепер, він та його країна понесуть наслідки. сьогодні я оголошую додаткові посилені санкції.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "putin jest agresorem. putin wybrał tę wojnę, a teraz on i jego kraj poniosą konsekwencje. dziś ogłaszam dodatkowe wzmożone sankcje.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "putin ist ein Aggressor. putin hat sich für diesen Krieg entschieden, und jetzt werden er und sein Land die Konsequenzen ziehen. heute kündige ich weitere verstärkte Sanktionen an.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(2);

            // включает панель в случаи перезахода
            int_four = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 11;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ТРЕТЬЯ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_five <= 0){
    if (int_special_plot == 3){
    if (int_promotion == 11){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(Osnova_Scenario_object_background != null){
            Osnova_Scenario_object_background.SetActive(false);
            }
            if(object_thirt_choice != null){
            object_thirt_choice.SetActive(true);
            }
            if(object_thirt_choice_black != null){
            object_thirt_choice_black.SetActive(true);
            }
            if(object_four_choice != null){
            object_four_choice.SetActive(true);
            }
            if(object_four_choice_black != null){
            object_four_choice_black.SetActive(true);
            }
            if(TV_lukashenko_war_panel != null){
            TV_lukashenko_war_panel.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }
            if(TV_bidon_war_panel != null){
            TV_bidon_war_panel.SetActive(true);
            }

            button_thirt_choice.interactable = true;
            button_four_choice.interactable = true;

            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "ask for military assistance";
            second_choice_text.text = "ask for diplomatic assistance";
            thirt_choice_text.text = "increase sanctions pressure";
            four_choice_text.text = "refusal to help";

            // черный текст
            first_choice_text_black.text = "ask for military assistance";
            second_choice_text_black.text = "ask for diplomatic assistance";
            thirt_choice_text_black.text = "increase sanctions pressure";
            four_choice_text_black.text = "refusal to help";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "попросить военную помощь";
            second_choice_text.text = "попросить дипломатическую помощь";
            thirt_choice_text.text = "увеличить санкционное давление";
            four_choice_text.text = "отказ от помощи";

            // черный текст
            first_choice_text_black.text = "попросить военную помощь";
            second_choice_text_black.text = "попросить дипломатическую помощь";
            thirt_choice_text_black.text = "увеличить санкционное давление";
            four_choice_text_black.text = "отказ от помощи";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "попросити військову допомогу";
            second_choice_text.text = "попросити дипломатичну допомогу";
            thirt_choice_text.text = "збільшити санкційний тиск";
            four_choice_text.text = "відмова від допомоги";

            // черный текст
            first_choice_text_black.text = "попросити військову допомогу";
            second_choice_text_black.text = "попросити дипломатичну допомогу";
            thirt_choice_text_black.text = "збільшити санкційний тиск";
            four_choice_text_black.text = "відмова від допомоги";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "poproś o pomoc wojskową";
            second_choice_text.text = "poproś o pomoc dyplomatyczną";
            thirt_choice_text.text = "zwiększyć presję sankcyjną";
            four_choice_text.text = "odmowa pomocy";

            // черный текст
            first_choice_text_black.text = "poproś o pomoc wojskową";
            second_choice_text_black.text = "poproś o pomoc dyplomatyczną";
            thirt_choice_text_black.text = "zwiększyć presję sankcyjną";
            four_choice_text_black.text = "odmowa pomocy";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "um militärische Hilfe bitten";
            second_choice_text.text = "um diplomatische Hilfe bitten";
            thirt_choice_text.text = "sanktionsdruck erhöhen";
            four_choice_text.text = "verzicht auf Hilfe";

            // черный текст
            first_choice_text_black.text = "um militärische Hilfe bitten";
            second_choice_text_black.text = "um diplomatische Hilfe bitten";
            thirt_choice_text_black.text = "sanktionsdruck erhöhen";
            four_choice_text_black.text = "verzicht auf Hilfe";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "you have the opportunity to receive western assistance, what should be prioritized?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "у вас есть возможность получить западную помощь, на что поставить приоритет?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "Ви маєте можливість отримати західну допомогу, на що поставити пріоритет?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "masz możliwość uzyskania pomocy zachodniej, na co zwrócić uwagę?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "sie haben die Möglichkeit, westliche Hilfe zu erhalten, was hat Priorität?";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_five = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 6;

            // дать возможность выбрать первые два варианта
            decision_making = 3;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ТРЕТЬЕ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 3){
    if (int_promotion == 13){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }

            if (reputation == 5){
            // карта good
            if(maps_tv_second_true != null){
            maps_tv_second_true.SetActive(false);
            }
            if(maps_tv_second_false != null){
            maps_tv_second_false.SetActive(false);
            }

            if(maps_tv_thirt_true != null){
            maps_tv_thirt_true.SetActive(true);
            }
            if(maps_tv_thirt_false != null){
            maps_tv_thirt_false.SetActive(false);
            }

            Maps_News_int = 5;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 6){
            // карта bad
            if(maps_tv_second_true != null){
            maps_tv_second_true.SetActive(false);
            }
            if(maps_tv_second_false != null){
            maps_tv_second_false.SetActive(false);
            }

            if(maps_tv_thirt_true != null){
            maps_tv_thirt_true.SetActive(false);
            }
            if(maps_tv_thirt_false != null){
            maps_tv_thirt_false.SetActive(true);
            }

            Maps_News_int = 6;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 6){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 14;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 5){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 14;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // ЧЕТВЕРТОЕ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_six <= 0){
    if (int_special_plot == 4){
    if (int_promotion == 14){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(true);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "i am a Russian warship. i propose to lay down our arms and surrender in order to avoid cowshed and unjustified victims. otherwise you will be bombed";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "я русский военный корабль.предлагаю сложить оружие и сдаться во избежание кровопролития и неоправданных жертв. в противном случае по вам будет нанесен бомбовый удар";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "я російський військовий корабель.пропоную скласти зброю і здатися, щоб уникнути коровопролиття та невиправданих жертв. в іншому випадку по вам буде завдано бомбового удару";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "jestem rosyjskim okrętem wojennym.proponuję złożyć broń i poddać się, aby uniknąć rozlewu krwi i nieuzasadnionych ofiar. w przeciwnym razie zostaniesz uderzony bombą";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "ich bin ein russisches Kriegsschiff.ich schlage vor, die Waffen niederzulegen und sich zu ergeben, um Blutvergießen und ungerechtfertigte Opfer zu vermeiden. andernfalls werden Sie bombardiert";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(3);

            // доп.текст
            SPEC_TEXT = 1;

            // включает панель в случаи перезахода
            int_six = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 24;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    if (SPEC_TEXT == 1){
    SPEC_TIMER += Time.deltaTime;
    if (SPEC_TIMER >= 22){
        if (Osnova_Plot_Scenario_text.text == "я русский военный корабль.предлагаю сложить оружие и сдаться во избежание коровопролития и неоправданных жертв. в противном случае по вам будет нанесен бомбовый удар"){
           Osnova_Plot_Scenario_text.text = "русский военный корабль, иди *****"; 
           StartCoroutine(Scenario_Plot_Apperance());

           SPEC_TIMER = 0;
           SPEC_TEXT = 0;
        }
        if (Osnova_Plot_Scenario_text.text == "я російський військовий корабель.пропоную скласти зброю і здатися, щоб уникнути коровопролиття та невиправданих жертв. в іншому випадку по вам буде завдано бомбового удару"){
           Osnova_Plot_Scenario_text.text = "російський військовий корабель, йди *****"; 
           StartCoroutine(Scenario_Plot_Apperance()); 

           SPEC_TIMER = 0;
           SPEC_TEXT = 0;
        }
        if (Osnova_Plot_Scenario_text.text == "i am a Russian warship. i propose to lay down our arms and surrender in order to avoid cowshed and unjustified victims. otherwise you will be bombed"){
           Osnova_Plot_Scenario_text.text = "russian warship, **** you"; 
           StartCoroutine(Scenario_Plot_Apperance());

           SPEC_TIMER = 0;
           SPEC_TEXT = 0;
        }
        if (Osnova_Plot_Scenario_text.text == "jestem rosyjskim okrętem wojennym.proponuję złożyć broń i poddać się, aby uniknąć rozlewu krwi i nieuzasadnionych ofiar. w przeciwnym razie zostaniesz uderzony bombą"){
           Osnova_Plot_Scenario_text.text = "rosyjski okręt wojenny, ******* się"; 
           StartCoroutine(Scenario_Plot_Apperance());

           SPEC_TIMER = 0;
           SPEC_TEXT = 0;
        }
        if (Osnova_Plot_Scenario_text.text == "ich bin ein russisches Kriegsschiff.ich schlage vor, die Waffen niederzulegen und sich zu ergeben, um Blutvergießen und ungerechtfertigte Opfer zu vermeiden. andernfalls werden Sie bombardiert"){
           Osnova_Plot_Scenario_text.text = "russisches kriegsschiff, **** dich."; 
           StartCoroutine(Scenario_Plot_Apperance());

           SPEC_TIMER = 0;
           SPEC_TEXT = 0;
        }
    }
    }



    // ЧЕТВЕРТАЯ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_seven <= 0){
    if (int_special_plot == 4){
    if (int_promotion == 15){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(TV_lukashenko_war_panel != null){
            TV_lukashenko_war_panel.SetActive(false);
            }
            if(TV_bidon_war_panel != null){
            TV_bidon_war_panel.SetActive(false);
            }
            if(TV_ostrov_war_panel != null){
            TV_ostrov_war_panel.SetActive(true);
            }

            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "give awards for courage";
            second_choice_text.text = "deny the incident";
            thirt_choice_text.text = "distribute to the media";
            four_choice_text.text = "ignore";

            // черный текст
            first_choice_text_black.text = "give awards for courage";
            second_choice_text_black.text = "deny the incident";
            thirt_choice_text_black.text = "distribute to the media";
            four_choice_text_black.text = "ignore";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "присвоить награды за мужество";
            second_choice_text.text = "отрицать инцидент";
            thirt_choice_text.text = "распространить в СМИ";
            four_choice_text.text = "игнорировать";

            // черный текст
            first_choice_text_black.text = "присвоить награды за мужество";
            second_choice_text_black.text = "отрицать инцидент";
            thirt_choice_text_black.text = "распространить в СМИ";
            four_choice_text_black.text = "игнорировать";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "присвоїти нагороди за мужність";
            second_choice_text.text = "заперечувати інцидент";
            thirt_choice_text.text = "поширити в ЗМІ";
            four_choice_text.text = "ігнорувати";

            // черный текст
            first_choice_text_black.text = "присвоїти нагороди за мужність";
            second_choice_text_black.text = "заперечувати інцидент";
            thirt_choice_text_black.text = "поширити в ЗМІ";
            four_choice_text_black.text = "ігнорувати";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "dać nagrodę za odwagę";
            second_choice_text.text = "zaprzeczaj incydentowi";
            thirt_choice_text.text = "rozpowszechniać w mediach";
            four_choice_text.text = "ignorować";

            // черный текст
            first_choice_text_black.text = "dać nagrodę za odwagę";
            second_choice_text_black.text = "zaprzeczaj incydentowi";
            thirt_choice_text_black.text = "rozpowszechniać w mediach";
            four_choice_text_black.text = "ignorować";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "eine Belohnung für Mut geben";
            second_choice_text.text = "vorfall bestreiten";
            thirt_choice_text.text = "in den Medien verbreiten";
            four_choice_text.text = "ignoriert";

            // черный текст
            first_choice_text_black.text = "eine Belohnung für Mut geben";
            second_choice_text_black.text = "vorfall bestreiten";
            thirt_choice_text_black.text = "in den Medien verbreiten";
            four_choice_text_black.text = "ignoriert";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "How will you react to this event?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "как вы отреагируете на это событие?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "як ви відреагуєте на цю подію?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "jak zareagujesz na to wydarzenie?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "wie werden Sie auf dieses Ereignis reagieren?";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_seven = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 3;

            // дать возможность выбрать первые два варианта
            decision_making = 4;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // Четвертте СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 4){
    if (int_promotion == 16){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }

            if (reputation == 7){
            // карта good
            if(maps_tv_thirt_true != null){
            maps_tv_thirt_true.SetActive(false);
            }
            if(maps_tv_thirt_false != null){
            maps_tv_thirt_false.SetActive(false);
            }
            if(maps_tv_four_true != null){
            maps_tv_four_true.SetActive(true);
            }
            if(maps_tv_four_false != null){
            maps_tv_four_false.SetActive(false);
            }

            Maps_News_int = 7;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 8){
            // карта bad
            if(maps_tv_thirt_true != null){
            maps_tv_thirt_true.SetActive(false);
            }
            if(maps_tv_thirt_false != null){
            maps_tv_thirt_false.SetActive(false);
            }
            if(maps_tv_four_true != null){
            maps_tv_four_true.SetActive(false);
            }
            if(maps_tv_four_false != null){
            maps_tv_four_false.SetActive(true);
            }

            Maps_News_int = 8;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 8){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 17;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 7){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 17;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // ПЯТОЕ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_eight <= 0){
    if (int_special_plot == 5){
    if (int_promotion == 17){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_chernobyl!= null){
            TV_chernobyl.SetActive(true);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(false);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "i want to inform you that the chernobyl zone, and all the facilities of the chernobyl nuclear power plant, were taken under the control of russian armed groups";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "я хочу сообщить, что чернобыльская зона, и все объекты чернобыльской АЭС были взяты под контроль российскими вооруженными группировками";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "я хочу повідомити, що чорнобильська зона і всі об'єкти чорнобильської АЕС були взяті під контроль російськими збройними угрупованнями";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "chcę poinformować, że strefa czarnobyla i wszystkie obiekty elektrowni jądrowej w czarnobylu zostały przejęte przez rosyjskie grupy zbrojne";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "ich möchte mitteilen, dass die Tschernobyl-Zone und alle Objekte des Kernkraftwerks Tschernobyl von russischen bewaffneten Gruppen unter die Kontrolle gebracht wurden";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(4);

            // включает панель в случаи перезахода
            int_eight = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 13;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ПЯТОЕ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_nine <= 0){
    if (int_special_plot == 5){
    if (int_promotion == 18){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(TV_lukashenko_war_panel != null){
            TV_lukashenko_war_panel.SetActive(false);
            }
            if(TV_bidon_war_panel != null){
            TV_bidon_war_panel.SetActive(false);
            }
            if(TV_ostrov_war_panel != null){
            TV_ostrov_war_panel.SetActive(false);
            }
            if(TV_chernobyl_war_panel != null){
            TV_chernobyl_war_panel.SetActive(true);
            }

            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "report a nuclear threat";
            second_choice_text.text = "deny everything";
            thirt_choice_text.text = "state the situation at an international summit";
            four_choice_text.text = "ignore";

            // черный текст
            first_choice_text_black.text = "report a nuclear threat";
            second_choice_text_black.text = "deny everything";
            thirt_choice_text_black.text = "state the situation at an international summit";
            four_choice_text_black.text = "ignore";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "сообщить о ядерной угрозе";
            second_choice_text.text = "все отрицать";
            thirt_choice_text.text = "заявить о ситуации на международном саммите";
            four_choice_text.text = "ничего не говорить";

            // черный текст
            first_choice_text_black.text = "сообщить о ядерной угрозе";
            second_choice_text_black.text = "все отрицать";
            thirt_choice_text_black.text = "заявить о ситуации на международном саммите";
            four_choice_text_black.text = "ничего не говорить";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "повідомити про ядерну загрозу";
            second_choice_text.text = "все заперечувати";
            thirt_choice_text.text = "заявити про ситуацію на міжнародному саміті";
            four_choice_text.text = "нічого не говорити";

            // черный текст
            first_choice_text_black.text = "повідомити про ядерну загрозу";
            second_choice_text_black.text = "все заперечувати";
            thirt_choice_text_black.text = "заявити про ситуацію на міжнародному саміті";
            four_choice_text_black.text = "нічого не говорити";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "zgłoś zagrożenie nuklearne";
            second_choice_text.text = "zaprzeczyć wszystkim";
            thirt_choice_text.text = "zgłoś sytuację na międzynarodowym szczycie";
            four_choice_text.text = "nic nie mówić";

            // черный текст
            first_choice_text_black.text = "zgłoś zagrożenie nuklearne";
            second_choice_text_black.text = "zaprzeczyć wszystkim";
            thirt_choice_text_black.text = "zgłoś sytuację na międzynarodowym szczycie";
            four_choice_text_black.text = "nic nie mówić";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "nukleare Bedrohung melden";
            second_choice_text.text = "alles leugnen";
            thirt_choice_text.text = "die Situation auf dem internationalen Gipfel erklären";
            four_choice_text.text = "nichts sagen";

            // черный текст
            first_choice_text_black.text = "nukleare Bedrohung melden";
            second_choice_text_black.text = "alles leugnen";
            thirt_choice_text_black.text = "die Situation auf dem internationalen Gipfel erklären";
            four_choice_text_black.text = "nichts sagen";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "How will you react to this event?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "как вы отреагируете на это событие?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "як ви відреагуєте на цю подію?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "jak zareagujesz na to wydarzenie?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "wie werden Sie auf dieses Ereignis reagieren?";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_nine = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 4;

            // дать возможность выбрать первые два варианта
            decision_making = 5;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ПЯТОЕ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 5){
    if (int_promotion == 19){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }

            if (reputation == 9){
            // карта good
            if(maps_tv_four_true != null){
            maps_tv_four_true.SetActive(false);
            }
            if(maps_tv_four_false != null){
            maps_tv_four_false.SetActive(false);
            }

            if(maps_tv_five_true != null){
            maps_tv_five_true.SetActive(true);
            }
            if(maps_tv_five_false != null){
            maps_tv_five_false.SetActive(false);
            }

            Maps_News_int = 9;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 10){
            // карта bad
            if(maps_tv_four_true != null){
            maps_tv_four_true.SetActive(false);
            }
            if(maps_tv_four_false != null){
            maps_tv_four_false.SetActive(false);
            }

            if(maps_tv_five_true != null){
            maps_tv_five_true.SetActive(false);
            }
            if(maps_tv_five_false != null){
            maps_tv_five_false.SetActive(true);
            }

            Maps_News_int = 10;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 10){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 20;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 9){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 20;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // ШЕСТОЕ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_ten <= 0){
    if (int_special_plot == 6){
    if (int_promotion == 20){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_jonhsonboris!= null){
            TV_jonhsonboris.SetActive(true);
            }
            if(TV_chernobyl!= null){
            TV_chernobyl.SetActive(false);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(false);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "I don't believe that this is a war in your name";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "я не верю что это война от вашего имени";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "я не вірю, що ця війна від вашого імені";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "nie wierzę, że to wojna w twoim imieniu";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "ich glaube nicht, dass es ein Krieg in Ihrem Namen ist.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(5);

            // включает панель в случаи перезахода
            int_ten = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 5;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ШЕСТОЕ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_eleven <= 0){
    if (int_special_plot == 6){
    if (int_promotion == 21){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(TV_chernobyl_war_panel != null){
            TV_chernobyl_war_panel.SetActive(false);
            }
            if(TV_borisjhonson_war_panel != null){
            TV_borisjhonson_war_panel.SetActive(true);
            }

            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "increase political pressure";
            second_choice_text.text = "try to attract public figures";
            thirt_choice_text.text = "give up political pressure";
            four_choice_text.text = "to do nothing";

            // черный текст
            first_choice_text_black.text = "increase political pressure";
            second_choice_text_black.text = "try to attract public figures";
            thirt_choice_text_black.text = "give up political pressure";
            four_choice_text_black.text = "to do nothing";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "увеличить политическое давление";
            second_choice_text.text = "постараться привлечь публичных лиц";
            thirt_choice_text.text = "отказать от политического давления";
            four_choice_text.text = "ничего не делать";

            // черный текст
            first_choice_text_black.text = "увеличить политическое давление";
            second_choice_text_black.text = "постараться привлечь публичных лиц";
            thirt_choice_text_black.text = "отказать от политического давления";
            four_choice_text_black.text = "ничего не делать";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "збільшити політичний тиск";
            second_choice_text.text = "постаратися залучити публічних осіб";
            thirt_choice_text.text = "відмовити від політичного тиску";
            four_choice_text.text = "нічого не робити";

            // черный текст
            first_choice_text_black.text = "збільшити політичний тиск";
            second_choice_text_black.text = "постаратися залучити публічних осіб";
            thirt_choice_text_black.text = "відмовити від політичного тиску";
            four_choice_text_black.text = "нічого не робити";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "zwiększyć presję polityczną";
            second_choice_text.text = "spróbuj przyciągnąć osoby publiczne";
            thirt_choice_text.text = "rezygnacja z nacisków politycznych";
            four_choice_text.text = "nic nie robić";

            // черный текст
            first_choice_text_black.text = "zwiększyć presję polityczną";
            second_choice_text_black.text = "spróbuj przyciągnąć osoby publiczne";
            thirt_choice_text_black.text = "rezygnacja z nacisków politycznych";
            four_choice_text_black.text = "nic nie robić";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "den politischen Druck erhöhen";
            second_choice_text.text = "versuchen Sie, öffentliche Personen anzuziehen";
            thirt_choice_text.text = "verzicht auf politischen Druck";
            four_choice_text.text = "nichts tun";

            // черный текст
            first_choice_text_black.text = "den politischen Druck erhöhen";
            second_choice_text_black.text = "versuchen Sie, öffentliche Personen anzuziehen";
            thirt_choice_text_black.text = "verzicht auf politischen Druck";
            four_choice_text_black.text = "nichts tun";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "make the decision you think is right";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "примите решение, которое считаете правильным";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "ухваліть рішення, яке вважаєте правильним";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "podejmij decyzję, którą uważasz za słuszną";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "treffen Sie eine Entscheidung, die Sie für richtig halten";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_eleven = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 4;

            // дать возможность выбрать первые два варианта
            decision_making = 6;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ШЕСТОЕ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 6){
    if (int_promotion == 22){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }

            if (reputation == 11){
            // карта good
            if(maps_tv_five_true != null){
            maps_tv_five_true.SetActive(false);
            }
            if(maps_tv_five_false != null){
            maps_tv_five_false.SetActive(false);
            }

            if(maps_tv_six_true != null){
            maps_tv_six_true.SetActive(true);
            }
            if(maps_tv_six_false != null){
            maps_tv_six_false.SetActive(false);
            }

            Maps_News_int = 11;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 12){
            // карта bad
            if(maps_tv_five_true != null){
            maps_tv_five_true.SetActive(false);
            }
            if(maps_tv_five_false != null){
            maps_tv_five_false.SetActive(false);
            }

            if(maps_tv_six_true != null){
            maps_tv_six_true.SetActive(false);
            }
            if(maps_tv_six_false != null){
            maps_tv_six_false.SetActive(true);
            }

            Maps_News_int = 12;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 12){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 23;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 11){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 23;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // СЕДЬМОЕ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_twelve <= 0){
    if (int_special_plot == 7){
    if (int_promotion == 23){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_mrija!= null){
            TV_mrija.SetActive(true);
            }
            if(TV_jonhsonboris!= null){
            TV_jonhsonboris.SetActive(false);
            }
            if(TV_chernobyl!= null){
            TV_chernobyl.SetActive(false);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(false);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "during fierce battles for the Antonov airport, which is located in the village of gostomel, kyiv region, a unique an-225 mriya aircraft was destroyed";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "во время ожесточенных боев за аэропорт «антонов» который расположен в поселке гостомель киевской области, был уничтожен уникальный самолет ан-225 «мрия»";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "під час запеклих боїв за аеропорт «антонов», який розташований у селищі гостомель київської області, було знищено унікальний літак ан-225 «мрія»";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "podczas zaciętych walk o Lotnisko «antonow», które znajduje się we wsi Gostomel w obwodzie kijowskim, unikalny samolot AN-225 «Mriya» został zniszczony";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "während der erbitterten Kämpfe um den Flughafen «Antonov», der sich im Dorf Gostomel des Kiewer Gebiets befindet, wurde das einzigartige Flugzeug «mriya» an-225 zerstört";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(6);

            // включает панель в случаи перезахода
            int_twelve = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 11;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // СЕДЬМОЕ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_thirteen <= 0){
    if (int_special_plot == 7){
    if (int_promotion == 24){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(TV_borisjhonson_war_panel != null){
            TV_borisjhonson_war_panel.SetActive(false);
            }
            if(TV_mrija_war_panel != null){
            TV_mrija_war_panel.SetActive(true);
            }

            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "try to hide this fact from the public";
            second_choice_text.text = "postpone the problem";
            thirt_choice_text.text = "start restoring the plane";
            four_choice_text.text = "ask for extra military aid";

            // черный текст
            first_choice_text_black.text = "try to hide this fact from the public";
            second_choice_text_black.text = "postpone the problem";
            thirt_choice_text_black.text = "start restoring the plane";
            four_choice_text_black.text = "ask for extra military aid";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "постараться скрыть этот факт от общественности";
            second_choice_text.text = "отложить решение проблемы";
            thirt_choice_text.text = "начать восстанавливать самолет";
            four_choice_text.text = "попросить доп. военную помощь";

            // черный текст
            first_choice_text_black.text = "постараться скрыть этот факт от общественности";
            second_choice_text_black.text = "отложить решение проблемы";
            thirt_choice_text_black.text = "начать восстанавливать самолет";
            four_choice_text_black.text = "попросить доп. военную помощь";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "постаратися приховати цей факт від громадськості";
            second_choice_text.text = "відкласти вирішення проблеми";
            thirt_choice_text.text = "почати відновлювати літак";
            four_choice_text.text = "попросити дод. військову допомогу";

            // черный текст
            first_choice_text_black.text = "постаратися приховати цей факт від громадськості";
            second_choice_text_black.text = "відкласти вирішення проблеми";
            thirt_choice_text_black.text = "почати відновлювати літак";
            four_choice_text_black.text = "попросити дод. військову допомогу";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "spróbuj ukryć ten fakt przed opinią publiczną";
            second_choice_text.text = "opóźnij rozwiązanie problemu";
            thirt_choice_text.text = "zacznij odbudowywać samolot";
            four_choice_text.text = "poproś o dodatkową pomoc wojskową";

            // черный текст
            first_choice_text_black.text = "spróbuj ukryć ten fakt przed opinią publiczną";
            second_choice_text_black.text = "opóźnij rozwiązanie problemu";
            thirt_choice_text_black.text = "zacznij odbudowywać samolot";
            four_choice_text_black.text = "poproś o dodatkową pomoc wojskową";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "versuchen Sie, diese Tatsache vor der Öffentlichkeit zu verbergen";
            second_choice_text.text = "lösung des Problems verschieben";
            thirt_choice_text.text = "starten Sie das Flugzeug zu reparieren";
            four_choice_text.text = "bitte um zusätzliche militärische Hilfe";

            // черный текст
            first_choice_text_black.text = "versuchen Sie, diese Tatsache vor der Öffentlichkeit zu verbergen";
            second_choice_text_black.text = "lösung des Problems verschieben";
            thirt_choice_text_black.text = "starten Sie das Flugzeug zu reparieren";
            four_choice_text_black.text = "bitte um zusätzliche militärische Hilfe";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "make the decision you think is right";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "примите решение, которое считаете правильным";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "ухваліть рішення, яке вважаєте правильним";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "podejmij decyzję, którą uważasz za słuszną";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "treffen Sie eine Entscheidung, die Sie für richtig halten";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_thirteen = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 3;

            // дать возможность выбрать первые два варианта
            decision_making = 7;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // СЕДЬМОЕ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 7){
    if (int_promotion == 25){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }

            if (reputation == 13){
            // карта good
            if(maps_tv_six_true != null){
            maps_tv_six_true.SetActive(false);
            }
            if(maps_tv_six_false != null){
            maps_tv_six_false.SetActive(false);
            }

            if(maps_tv_seven_true != null){
            maps_tv_seven_true.SetActive(true);
            }
            if(maps_tv_seven_false != null){
            maps_tv_seven_false.SetActive(false);
            }

            Maps_News_int = 13;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 14){
            // карта bad
            if(maps_tv_six_true != null){
            maps_tv_six_true.SetActive(false);
            }
            if(maps_tv_six_false != null){
            maps_tv_six_false.SetActive(false);
            }

            if(maps_tv_seven_true != null){
            maps_tv_seven_true.SetActive(false);
            }
            if(maps_tv_seven_false != null){
            maps_tv_seven_false.SetActive(true);
            }

            Maps_News_int = 14;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 14){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 26;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 13){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 26;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // ВОСЬМАЯ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_fourteen <= 0){
    if (int_special_plot == 8){
    if (int_promotion == 26){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_jadrn_zdrv!= null){
            TV_jadrn_zdrv.SetActive(true);
            }
            if(TV_mrija!= null){
            TV_mrija.SetActive(false);
            }
            if(TV_jonhsonboris!= null){
            TV_jonhsonboris.SetActive(false);
            }
            if(TV_chernobyl!= null){
            TV_chernobyl.SetActive(false);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(false);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "therefore, i order the minister of defense and the chief of the general Staff to transfer the army containment forces to a special mode of combat duty";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "поэтому приказываю министру обороны и начальнику генерального штаба перевести силы сдерживания армии в особый режим несения боевого дежурства";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "тому наказую міністру оборони та начальнику генерального штабу перевести сили стримування армії в особливий режим несення бойового чергування";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "dlatego nakazuję ministrowi obrony i szefowi sztabu generalnego przeniesienie sił powstrzymujących armię w specjalny tryb pełnienia służby bojowej";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "deshalb befehle ich dem Verteidigungsminister und dem Generalstabschef, die Abschreckungskräfte der Armee in eine besondere Art der Kampfbereitschaft zu versetzen";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(7);

            // включает панель в случаи перезахода
            int_fourteen = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 14;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ВОСЬМАЯ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_fiveteen <= 0){
    if (int_special_plot == 8){
    if (int_promotion == 27){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(TV_mrija_war_panel != null){
            TV_mrija_war_panel.SetActive(false);
            }
            if(TV_jadrn_zdrv_war_panel != null){
            TV_jadrn_zdrv_war_panel.SetActive(true);
            }

            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "rudely condemn";
            second_choice_text.text = "ease political pressure";
            thirt_choice_text.text = "ask to be calm";
            four_choice_text.text = "start preparing for nuclear war";

            // черный текст
            first_choice_text_black.text = "rudely condemn";
            second_choice_text_black.text = "ease political pressure";
            thirt_choice_text_black.text = "ask to be calm";
            four_choice_text_black.text = "start preparing for nuclear war";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "грубо осудить";
            second_choice_text.text = "ослабить политическое давление";
            thirt_choice_text.text = "попросить соблюдать спокойствие";
            four_choice_text.text = "начать подготовку к ядерной войне";

            // черный текст
            first_choice_text_black.text = "грубо осудить";
            second_choice_text_black.text = "ослабить политическое давление";
            thirt_choice_text_black.text = "попросить соблюдать спокойствие";
            four_choice_text_black.text = "начать подготовку к ядерной войне";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "грубо засудити";
            second_choice_text.text = "послабити політичний тиск";
            thirt_choice_text.text = "попросити дотримуватися спокою";
            four_choice_text.text = "розпочати підготовку до ядерної війни";

            // черный текст
            first_choice_text_black.text = "грубо засудити";
            second_choice_text_black.text = "послабити політичний тиск";
            thirt_choice_text_black.text = "попросити дотримуватися спокою";
            four_choice_text_black.text = "розпочати підготовку до ядерної війни";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "potępić wypowiedź";
            second_choice_text.text = "złagodzić presję polityczną";
            thirt_choice_text.text = "poproś o zachowanie spokoju";
            four_choice_text.text = "Rozpocznij przygotowania do wojny nuklearnej";

            // черный текст
            first_choice_text_black.text = "potępić wypowiedź";
            second_choice_text_black.text = "złagodzić presję polityczną";
            thirt_choice_text_black.text = "poproś o zachowanie spokoju";
            four_choice_text_black.text = "Rozpocznij przygotowania do wojny nuklearnej";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "äußerung verurteilen";
            second_choice_text.text = "politischen druck abschwächen";
            thirt_choice_text.text = "bitte um Ruhe";
            four_choice_text.text = "Fangen Sie an, sich auf einen Atomkrieg vorzubereiten";

            // черный текст
            first_choice_text_black.text = "äußerung verurteilen";
            second_choice_text_black.text = "politischen druck abschwächen";
            thirt_choice_text_black.text = "bitte um Ruhe";
            four_choice_text_black.text = "Fangen Sie an, sich auf einen Atomkrieg vorzubereiten";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "make the decision you think is right";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "примите решение, которое считаете правильным";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "ухваліть рішення, яке вважаєте правильним";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "podejmij decyzję, którą uważasz za słuszną";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "treffen Sie eine Entscheidung, die Sie für richtig halten";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_fiveteen = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 4;

            // дать возможность выбрать первые два варианта
            decision_making = 8;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ВОСЬМАЯ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 8){
    if (int_promotion == 28){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }

            if (reputation == 15){
            // карта good
            if(maps_tv_seven_true != null){
            maps_tv_seven_true.SetActive(false);
            }
            if(maps_tv_seven_false != null){
            maps_tv_seven_false.SetActive(false);
            }

            if(maps_tv_eight_true != null){
            maps_tv_eight_true.SetActive(true);
            }
            if(maps_tv_eight_false != null){
            maps_tv_eight_false.SetActive(false);
            }

            Maps_News_int = 15;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 16){
            // карта bad
            if(maps_tv_seven_true != null){
            maps_tv_seven_true.SetActive(false);
            }
            if(maps_tv_seven_false != null){
            maps_tv_seven_false.SetActive(false);
            }

            if(maps_tv_eight_true != null){
            maps_tv_eight_true.SetActive(false);
            }
            if(maps_tv_eight_false != null){
            maps_tv_eight_false.SetActive(true);
            }

            Maps_News_int = 16;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 16){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 29;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 15){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 29;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // ДЕВЯТОЕ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_sixteen <= 0){
    if (int_special_plot == 9){
    if (int_promotion == 29){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_zjs!= null){
            TV_zjs.SetActive(true);
            }
            if(TV_jadrn_zdrv!= null){
            TV_jadrn_zdrv.SetActive(false);
            }
            if(TV_mrija!= null){
            TV_mrija.SetActive(false);
            }
            if(TV_jonhsonboris!= null){
            TV_jonhsonboris.SetActive(false);
            }
            if(TV_chernobyl!= null){
            TV_chernobyl.SetActive(false);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(false);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "the fire at the zaporozhye nuclear power plant continues. firefighters cannot get to the place of ignition and eliminate the consequences";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "пожар на запорожской аэс продолжается. пожарники не могут достаться к месту возгорания и ликвидировать последствия";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "пожежа на запорізькому аес триває. пожежники не можуть дістатись до місця загоряння та ліквідувати наслідки";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "pożar w zaporoskiej elektrowni jądrowej trwa. strażacy nie mogą dotrzeć do miejsca pożaru i wyeliminować skutków";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "das Feuer im Kernkraftwerk von Zaporozhye geht weiter. feuerwehrleute können den Brandort nicht erreichen und die Folgen beseitigen";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(8);

            // включает панель в случаи перезахода
            int_sixteen = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 11;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ДЕВЯТОЕ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_seventeen <= 0){
    if (int_special_plot == 9){
    if (int_promotion == 30){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(Osnova_Scenario_object_background != null){
            Osnova_Scenario_object_background.SetActive(true);
            }

            if(TV_zjs_war_panel != null){
            TV_zjs_war_panel.SetActive(true);
            }
            if(TV_jadrn_zdrv_war_panel != null){
            TV_jadrn_zdrv_war_panel.SetActive(false);
            }

            if(object_thirt_choice != null){
            object_thirt_choice.SetActive(false);
            }
            if(object_thirt_choice_black != null){
            object_thirt_choice_black.SetActive(false);
            }
            if(object_four_choice != null){
            object_four_choice.SetActive(false);
            }
            if(object_four_choice_black != null){
            object_four_choice_black.SetActive(false);
            }

            button_thirt_choice.interactable = false;
            button_four_choice.interactable = false;


            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "declare a nuclear threat";
            second_choice_text.text = "ignore";

            // черный текст
            first_choice_text_black.text = "declare a nuclear threat";
            second_choice_text_black.text = "ignore";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "заявить о ядерной угрозе";
            second_choice_text.text = "проигнорировать";

            // черный текст
            first_choice_text_black.text = "заявить о ядерной угрозе";
            second_choice_text_black.text = "проигнорировать";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "заявити про ядерну загрозу";
            second_choice_text.text = "проігнорувати";

            // черный текст
            first_choice_text_black.text = "заявити про ядерну загрозу";
            second_choice_text_black.text = "проігнорувати";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "ogłosić zagrożenie nuklearne";
            second_choice_text.text = "ignorować";

            // черный текст
            first_choice_text_black.text = "ogłosić zagrożenie nuklearne";
            second_choice_text_black.text = "ignorować";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "deklarieren eine nukleare Bedrohung";
            second_choice_text.text = "ignorieren";

            // черный текст
            first_choice_text_black.text = "deklarieren eine nukleare Bedrohung";
            second_choice_text_black.text = "ignorieren";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "make the decision you think is right";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "примите решение, которое считаете правильным";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "ухваліть рішення, яке вважаєте правильним";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "podejmij decyzję, którą uważasz za słuszną";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "treffen Sie eine Entscheidung, die Sie für richtig halten";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_seventeen = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 4;

            // дать возможность выбрать первые два варианта
            decision_making = 9;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ДЕВЯТОЕ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 9){
    if (int_promotion == 31){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }

            if (reputation == 17){
            // карта good
            if(maps_tv_eight_true != null){
            maps_tv_eight_true.SetActive(false);
            }
            if(maps_tv_eight_false != null){
            maps_tv_eight_false.SetActive(false);
            }

            if(maps_tv_ten_true != null){
            maps_tv_ten_true.SetActive(true);
            }
            if(maps_tv_ten_false != null){
            maps_tv_ten_false.SetActive(false);
            }

            Maps_News_int = 17;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 18){
            // карта bad
            if(maps_tv_eight_true != null){
            maps_tv_eight_true.SetActive(false);
            }
            if(maps_tv_eight_false != null){
            maps_tv_eight_false.SetActive(false);
            }

            if(maps_tv_ten_true != null){
            maps_tv_ten_true.SetActive(false);
            }
            if(maps_tv_ten_false != null){
            maps_tv_ten_false.SetActive(true);
            }

            Maps_News_int = 18;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 18){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 32;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 17){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 32;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // ДЕСЯТОЕ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_eightteen <= 0){
    if (int_special_plot == 10){
    if (int_promotion == 32){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_economica!= null){
            TV_economica.SetActive(true);
            }
            if(TV_zjs!= null){
            TV_zjs.SetActive(false);
            }
            if(TV_jadrn_zdrv!= null){
            TV_jadrn_zdrv.SetActive(false);
            }
            if(TV_mrija!= null){
            TV_mrija.SetActive(false);
            }
            if(TV_jonhsonboris!= null){
            TV_jonhsonboris.SetActive(false);
            }
            if(TV_chernobyl!= null){
            TV_chernobyl.SetActive(false);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(false);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "according to the World Bank forecast, ukraine's gdp may fall by 44% by the end of the year. one of the reasons is inflation.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "по прогнозу всемирного банка, до конца года ввп украины может упасть на 44% одна из причин - инфляция";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "за прогнозом світового банку, до кінця року ВВП України може впасти на 44% одна з причин - інфляція";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "według prognozy Banku Światowego, do końca roku PKB Ukrainy może spaść o 44% jednym z powodów-inflacja";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "nach der Prognose der Weltbank kann das Bip der Ukraine bis zum Ende des Jahres um 44% fallen einer der Gründe ist die Inflation";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(9);

            // включает панель в случаи перезахода
            int_eightteen = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 9;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ДЕСЯТОЕ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_nineteen <= 0){
    if (int_special_plot == 10){
    if (int_promotion == 33){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }
            if(Osnova_Scenario_object_background != null){
            Osnova_Scenario_object_background.SetActive(false);
            }

            if(TV_jadrn_zdrv_war_panel != null){
            TV_jadrn_zdrv_war_panel.SetActive(false);
            }
            if(TV_zjs_war_panel != null){
            TV_zjs_war_panel.SetActive(false);
            }
            if(TV_economica_war_panel != null){
            TV_economica_war_panel.SetActive(true);
            }

            if(object_thirt_choice != null){
            object_thirt_choice.SetActive(true);
            }
            if(object_thirt_choice_black != null){
            object_thirt_choice_black.SetActive(true);
            }
            if(object_four_choice != null){
            object_four_choice.SetActive(true);
            }
            if(object_four_choice_black != null){
            object_four_choice_black.SetActive(true);
            }

            button_thirt_choice.interactable = true;
            button_four_choice.interactable = true;


            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "raise taxes";
            second_choice_text.text = "use the rest of the reserve";
            thirt_choice_text.text = "get foreign loans";
            four_choice_text.text = "print money";

            // черный текст
            first_choice_text_black.text = "raise taxes";
            second_choice_text_black.text = "use the rest of the reserve";
            thirt_choice_text_black.text = "get foreign loans";
            four_choice_text_black.text = "print money";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "повысить налоги";
            second_choice_text.text = "использовать остатки резерва";
            thirt_choice_text.text = "получить иностранные займы";
            four_choice_text.text = "напечатать денег";

            // черный текст
            first_choice_text_black.text = "повысить налоги";
            second_choice_text_black.text = "использовать остатки резерва";
            thirt_choice_text_black.text = "получить иностранные займы";
            four_choice_text_black.text = "напечатать денег";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "підвищити податки";
            second_choice_text.text = "використовувати залишки резерву";
            thirt_choice_text.text = "отримати іноземні позики";
            four_choice_text.text = "надрукувати грошей";

            // черный текст
            first_choice_text_black.text = "підвищити податки";
            second_choice_text_black.text = "використовувати залишки резерву";
            thirt_choice_text_black.text = "отримати іноземні позики";
            four_choice_text_black.text = "надрукувати грошей";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "podnieść podatki";
            second_choice_text.text = "wykorzystaj salda rezerwy";
            thirt_choice_text.text = "uzyskaj pożyczki zagraniczne";
            four_choice_text.text = "wydrukuj pieniądze";

            // черный текст
            first_choice_text_black.text = "podnieść podatki";
            second_choice_text_black.text = "wykorzystaj salda rezerwy";
            thirt_choice_text_black.text = "uzyskaj pożyczki zagraniczne";
            four_choice_text_black.text = "wydrukuj pieniądze";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "steuern erhöhen";
            second_choice_text.text = "rücklagen verwenden";
            thirt_choice_text.text = "ausländische Kredite erhalten";
            four_choice_text.text = "geld drucken";

            // черный текст
            first_choice_text_black.text = "steuern erhöhen";
            second_choice_text_black.text = "rücklagen verwenden";
            thirt_choice_text_black.text = "ausländische Kredite erhalten";
            four_choice_text_black.text = "geld drucken";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "make the decision you think is right";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "примите решение, которое считаете правильным";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "ухваліть рішення, яке вважаєте правильним";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "podejmij decyzję, którą uważasz za słuszną";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "treffen Sie eine Entscheidung, die Sie für richtig halten";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_nineteen = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 4;

            // дать возможность выбрать первые два варианта
            decision_making = 10;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ДЕСЯТОЕ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 10){
    if (int_promotion == 34){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }

            if (reputation == 19){
            // карта good
            if(maps_tv_ten_true != null){
            maps_tv_ten_true.SetActive(false);
            }
            if(maps_tv_ten_false != null){
            maps_tv_ten_false.SetActive(false);
            }

            if(maps_tv_eleven_true != null){
            maps_tv_eleven_true.SetActive(true);
            }
            if(maps_tv_eleven_false != null){
            maps_tv_eleven_false.SetActive(false);
            }

            Maps_News_int = 19;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 20){
            // карта bad
            if(maps_tv_ten_true != null){
            maps_tv_ten_true.SetActive(false);
            }
            if(maps_tv_ten_false != null){
            maps_tv_ten_false.SetActive(false);
            }

            if(maps_tv_eleven_true != null){
            maps_tv_eleven_true.SetActive(false);
            }
            if(maps_tv_eleven_false != null){
            maps_tv_eleven_false.SetActive(true);
            }

            Maps_News_int = 20;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 20){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 35;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 19){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 35;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // ОДИНАЦЕТОЕ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_twenty <= 0){
    if (int_special_plot == 11){
    if (int_promotion == 35){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_mariupol!= null){
            TV_mariupol.SetActive(true);
            }
            if(TV_economica!= null){
            TV_economica.SetActive(false);
            }
            if(TV_zjs!= null){
            TV_zjs.SetActive(false);
            }
            if(TV_jadrn_zdrv!= null){
            TV_jadrn_zdrv.SetActive(false);
            }
            if(TV_mrija!= null){
            TV_mrija.SetActive(false);
            }
            if(TV_jonhsonboris!= null){
            TV_jonhsonboris.SetActive(false);
            }
            if(TV_chernobyl!= null){
            TV_chernobyl.SetActive(false);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(false);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "aviation purposefully dropped a powerful bomb on the drama theater in the city center. Hundreds of people were hiding there. the building is destroyed.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "авиация целенаправленно скинула мощную бомбу на драматический театр в центре города. там прятались од обстрелом сотни людей. здание разрушено.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "авіація цілеспрямовано скинула потужну бомбу на драматичний театр у центрі міста. Там ховалися сотні людей. будинок зруйнований.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "lotnictwo celowo zrzuciło potężną bombę na Teatr Dramatyczny w centrum miasta. ukrywały się tam setki ludzi. budynek został zniszczony.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "die Luftwaffe hatte gezielt eine mächtige Bombe auf ein Schauspielhaus in der Innenstadt geworfen. dort hatten sich Hunderte Menschen versteckt. das Gebäude ist zerstört.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(10);

            // включает панель в случаи перезахода
            int_twenty = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 12;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ОДИНАЦЕТОЕ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_twenty_one <= 0){
    if (int_special_plot == 11){
    if (int_promotion == 36){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(Osnova_Scenario_object_background != null){
            Osnova_Scenario_object_background.SetActive(true);
            }


            if(TV_economica_war_panel != null){
            TV_economica_war_panel.SetActive(false);
            }
            if(TV_mariupol_war_panel != null){
            TV_mariupol_war_panel.SetActive(true);
            }

            if(object_thirt_choice != null){
            object_thirt_choice.SetActive(false);
            }
            if(object_thirt_choice_black != null){
            object_thirt_choice_black.SetActive(false);
            }
            if(object_four_choice != null){
            object_four_choice.SetActive(false);
            }
            if(object_four_choice_black != null){
            object_four_choice_black.SetActive(false);
            }

            button_thirt_choice.interactable = false;
            button_four_choice.interactable = false;


            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "surrender the city";
            second_choice_text.text = "don't give up the city";

            // черный текст
            first_choice_text_black.text = "surrender the city";
            second_choice_text_black.text = "don't give up the city";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "сдать город";
            second_choice_text.text = "не сдавать город";

            // черный текст
            first_choice_text_black.text = "сдать город";
            second_choice_text_black.text = "не сдавать город";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "здати місто";
            second_choice_text.text = "не здавати місто";

            // черный текст
            first_choice_text_black.text = "здати місто";
            second_choice_text_black.text = "не здавати місто";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "oddaj miasto";
            second_choice_text.text = "nie oddawaj miasta";

            // черный текст
            first_choice_text_black.text = "oddaj miasto";
            second_choice_text_black.text = "nie oddawaj miasta";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "die Stadt verschenken";
            second_choice_text.text = "die Stadt nicht abgeben";

            // черный текст
            first_choice_text_black.text = "die Stadt verschenken";
            second_choice_text_black.text = "die Stadt nicht abgeben";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "the city is under blockade, what decision will you make?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "город в блокаде, какое решение вы примите?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "місто в блокаді, яке рішення ви ухвалите?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "miasto jest oblężone, jaką decyzję podejmiesz?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "eine Stadt in der Blockade, welche Entscheidung treffen Sie?";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_twenty_one = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 4;

            // дать возможность выбрать первые два варианта
            decision_making = 11;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }

    // ОДИНАЦЕТОЕ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_special_plot == 11){
    if (int_promotion == 37){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }

            if (reputation == 21){
            // карта good
            if(maps_tv_eleven_true != null){
            maps_tv_eleven_true.SetActive(false);
            }
            if(maps_tv_eleven_false != null){
            maps_tv_eleven_false.SetActive(false);
            }

            if(maps_tv_twelve_true != null){
            maps_tv_twelve_true.SetActive(true);
            }
            if(maps_tv_twelve_false != null){
            maps_tv_twelve_false.SetActive(false);
            }

            Maps_News_int = 21;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            if (reputation == 22){
            // карта bad
            if(maps_tv_eleven_true != null){
            maps_tv_eleven_true.SetActive(false);
            }
            if(maps_tv_eleven_false != null){
            maps_tv_eleven_false.SetActive(false);
            }

            if(maps_tv_twelve_true != null){
            maps_tv_twelve_true.SetActive(false);
            }
            if(maps_tv_twelve_false != null){
            maps_tv_twelve_false.SetActive(true);
            }

            Maps_News_int = 22;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            }

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 5;
            int_dont_touch = 1;

            // плохой исход
            if (reputation == 22){
                
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a negative impact on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это негативно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це негативно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "wpłynęło to negatywnie na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich negativ auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 38;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

            }

            // хороший исход
            if (reputation == 21){

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 38;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  
            }
        }
    }
    }

    // ----------------------П Л О Х А Я - К О Н Ц О В К А----------------------

    // ДВЕНАДЦАТАЯ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_koncovka == 1){
    if (int_twenty_two <= 0){
    if (int_special_plot == 12){
    if (int_promotion == 38){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_kiva!= null){
            TV_kiva.SetActive(true);
            }
            if(TV_mariupol!= null){
            TV_mariupol.SetActive(false);
            }
            if(TV_economica!= null){
            TV_economica.SetActive(false);
            }
            if(TV_zjs!= null){
            TV_zjs.SetActive(false);
            }
            if(TV_jadrn_zdrv!= null){
            TV_jadrn_zdrv.SetActive(false);
            }
            if(TV_mrija!= null){
            TV_mrija.SetActive(false);
            }
            if(TV_jonhsonboris!= null){
            TV_jonhsonboris.SetActive(false);
            }
            if(TV_chernobyl!= null){
            TV_chernobyl.SetActive(false);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(false);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "i have just been confirmed that the commander-in-chief of the Armed Forces of Ukraine, president volodymyr oleksandrovich Zelensky, crossed the ukrainian-polish border today and is now safe in the american embassy";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "только что мне подтвердили, что главнокомандующий вооруженных сил украины президент владимир александрович зеленский пересек сегодня украино-польскую границу и сейчас находится в безопасности в американском посольстве";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "щойно мені підтвердили, що головнокомандувач збройних сил україни президент володимир олександрович зелений перетнув сьогодні українсько-польський кордон і зараз перебуває в безпеці в американському посольстві";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "właśnie potwierdzono mi, że głównodowodzący sił zbrojnych Ukrainy prezydent Wołodymyr Aleksandrowicz zełenski przekroczył dziś ukraińsko-polską granicę i jest teraz bezpieczny w ambasadzie amerykańskiej";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "ich habe gerade bestätigt, dass der Oberbefehlshaber der Streitkräfte der Ukraine, Präsident Vladimir Aleksandrovich zelensky, heute die ukrainisch-polnische Grenze überquert hat und sich jetzt in der amerikanischen Botschaft in Sicherheit befindet";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(11);

            // включает панель в случаи перезахода
            int_twenty_two = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 13;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }
    }

    // ДВЕНАДЦАТАЯ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_koncovka == 1){
    if (int_twenty_three <= 0){
    if (int_special_plot == 12){
    if (int_promotion == 39){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(Osnova_Scenario_object_background != null){
            Osnova_Scenario_object_background.SetActive(true);
            }


            if(TV_economica_war_panel != null){
            TV_economica_war_panel.SetActive(false);
            }
            if(TV_mariupol_war_panel != null){
            TV_mariupol_war_panel.SetActive(false);
            }
            if(TV_kiva_war_panel != null){
            TV_kiva_war_panel.SetActive(true);
            }

            if(object_thirt_choice != null){
            object_thirt_choice.SetActive(false);
            }
            if(object_thirt_choice_black != null){
            object_thirt_choice_black.SetActive(false);
            }
            if(object_four_choice != null){
            object_four_choice.SetActive(false);
            }
            if(object_four_choice_black != null){
            object_four_choice_black.SetActive(false);
            }

            button_thirt_choice.interactable = false;
            button_four_choice.interactable = false;


            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "confirm";
            second_choice_text.text = "deny everything";

            // черный текст
            first_choice_text_black.text = "confirm";
            second_choice_text_black.text = "deny everything";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "подтвердить";
            second_choice_text.text = "все отрицать";

            // черный текст
            first_choice_text_black.text = "подтвердить";
            second_choice_text_black.text = "все отрицать";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "підтвердити";
            second_choice_text.text = "все заперечувати";

            // черный текст
            first_choice_text_black.text = "підтвердити";
            second_choice_text_black.text = "все заперечувати";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "potwierdzić";
            second_choice_text.text = "zaprzeczyć wszystkim";

            // черный текст
            first_choice_text_black.text = "potwierdzić";
            second_choice_text_black.text = "zaprzeczyć wszystkim";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "bestätigen";
            second_choice_text.text = "alles leugnen";

            // черный текст
            first_choice_text_black.text = "bestätigen";
            second_choice_text_black.text = "alles leugnen";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "what will you answer?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "что вы ответите?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "що ви відповісте?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "co odpowiesz?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "was werden Sie antworten?";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_twenty_three = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 2;

            // дать возможность выбрать первые два варианта
            decision_making = 12;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }
    }

    // ДВЕНАДЦАТАЯ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_koncovka == 1){
    if (int_special_plot == 12){
    if (int_promotion == 40){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }


            if(maps_tv_twelve_true != null){
            maps_tv_twelve_true.SetActive(false);
            }
            if(maps_tv_twelve_false != null){
            maps_tv_twelve_false.SetActive(false);
            }
            if(maps_tv_thirteen_false != null){
            maps_tv_thirteen_false.SetActive(true);
            }

            Maps_News_int = 23;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 3;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "your answer doesn't matter anymore";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "ваш ответ уже не имеет никакого значения";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "ваша відповідь вже не має жодного значення";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "twoja odpowiedź nie ma już znaczenia";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "ihre Antwort spielt keine Rolle mehr";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 41;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

        }
    }
    }
    }

    // ТРИНАДЦАТАЯ ПАНЕЛЬ (ПОСЛЕДНЯЯ ПЛОХОЙ КОНЦОВКИ)
    if (int_twenty_five <= 0){
    if (int_koncovka == 1){
    if (int_special_plot == 13){
    if (int_promotion == 41){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }


            if(maps_tv_thirteen_false != null){
            maps_tv_thirteen_false.SetActive(false);
            }
            if(maps_tv_fourteen_false != null){
            maps_tv_fourteen_false.SetActive(true);
            }

            Maps_News_int = 24;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "you unlocked the bad ending";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "вы открыли плохую концовку";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "ви відкрили погану кінцівку";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "otworzyłeś złe zakończenie";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "sie haben ein schlechtes Ende entdeckt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_konec_scenario = 1;
            timer_promotion = 0;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 2;

            int_twenty_five = 1;

        }

    }
    }
    }
    }

    // последняя сцена
    if (int_promotion == 43){
    if (int_konec_scenario == 1){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(false);
            }
            if(end_scene != null){
            end_scene.SetActive(true);
            }

            // обнуляет прошлый текст
            end_scene_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            timer_promotion = 0;
            int_promotion = 44;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

        }
    }
    }

    // изменялки (меняет картинки)
    if (end_music == 2){
    end_timer += Time.deltaTime;
        if (fack_cock <= 0){
        if (end_timer >= 42){
            if(transtion_object != null){
            transtion_object.SetActive(true);
            }
            transtion.Play("transtion");  
        } 
        }

        if (end_timer >= 42.45){         
            if(end_scene_good != null){
            end_scene_good.SetActive(false);
            } 
            fack_cock = 1;
        } 

        if (end_timer >= 43.5){ 

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }   

            end_timer = 0;
            end_music = 3;
            PlayerPrefs.SetInt ("end_music", end_music);
        }  
    }

    if (end_music == 3){
        end_timer += Time.deltaTime;
        if (end_timer >= 30){

            if(language == "" || language == "eng"){
            end_scene_text.text = "thanks for playing the game";
            StartCoroutine(end_text_Apperance());
            }

            if (language == "Rus"){
            end_scene_text.text = "спасибо за прохождение игры";
            StartCoroutine(end_text_Apperance());
            }

            if (language == "UA"){
            end_scene_text.text = "дякую за проходження гри";
            StartCoroutine(end_text_Apperance());
            }

            if (language == "Pl"){
            end_scene_text.text = "thanks for playing the game";
            StartCoroutine(end_text_Apperance());
            }

            if (language == "De"){
            end_scene_text.text = "thanks for playing the game";
            StartCoroutine(end_text_Apperance());
            }

            end_timer = 0;
            end_music = 5;
        }
    }

    // ----------------------Х О Р О Ш А Я - К О Н Ц О В К А----------------------

    // ДВЕНАДЦАТАЯ СЦЕНАРНОЕ СОБИТИЕ (кат-сцена)
    if (int_koncovka == 2){
    if (int_twenty_two <= 0){
    if (int_special_plot == 12){
    if (int_promotion == 38){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(true);
            }
            if(TV_arestovych!= null){
            TV_arestovych.SetActive(true);
            }
            if(TV_mariupol!= null){
            TV_mariupol.SetActive(false);
            }
            if(TV_economica!= null){
            TV_economica.SetActive(false);
            }
            if(TV_zjs!= null){
            TV_zjs.SetActive(false);
            }
            if(TV_jadrn_zdrv!= null){
            TV_jadrn_zdrv.SetActive(false);
            }
            if(TV_mrija!= null){
            TV_mrija.SetActive(false);
            }
            if(TV_jonhsonboris!= null){
            TV_jonhsonboris.SetActive(false);
            }
            if(TV_chernobyl!= null){
            TV_chernobyl.SetActive(false);
            }
            if(TV_ostrov!= null){
            TV_ostrov.SetActive(false);
            }
            if(TV_bidon!= null){
            TV_bidon.SetActive(false);
            }
            if(TV_gordon != null){
            TV_gordon.SetActive(false);
            }

            Osnova_Plot_Scenario_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){
            Osnova_Plot_Scenario_text.text = "our soldiers began small tactical and counter-offensive actions in the sumy, kharkov region. continue respectively in the kyiv region and in the Kherson region.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Rus"){
            Osnova_Plot_Scenario_text.text = "наши солдаты начали маленькие тактические и контр - наступательные действия в сумской, харьковской области. продолжают соответственно в киевской области и в херсонской области.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "UA"){
            Osnova_Plot_Scenario_text.text = "наші солдати розпочали маленькі тактичні та контр-наступальні дії у сумській, харківській області. продовжують відповідно у київській області та у херсонській області.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "Pl"){
            Osnova_Plot_Scenario_text.text = "nasi żołnierze rozpoczęli drobne działania taktyczne i kontrofensywne w Sumach w rejonie Charkowa. kontynuować odpowiednio w obwodzie kijowskim iw obwodzie chersońskim.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            if (language == "De"){
            Osnova_Plot_Scenario_text.text = "Unsere Soldaten begannen mit kleinen taktischen und Gegenoffensiven in der Region Sumy, Charkow. weiterhin in der Region Kiew und in der Region Cherson.";
            StartCoroutine(Scenario_Plot_Apperance());
            }

            timer_promotion = 0;
            PlaySound(12);

            // включает панель в случаи перезахода
            int_twenty_two = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 13;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }
    }

    // ДВЕНАДЦАТАЯ СЦЕНА СЦЕНАРНОГО СОБИТИЯ ( ВЫБОР )
    if (int_koncovka == 2){
    if (int_twenty_three <= 0){
    if (int_special_plot == 12){
    if (int_promotion == 39){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            // два основнных обьекта
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(true);
            }

            if(Osnova_Scenario_object_background != null){
            Osnova_Scenario_object_background.SetActive(true);
            }


            if(TV_economica_war_panel != null){
            TV_economica_war_panel.SetActive(false);
            }
            if(TV_mariupol_war_panel != null){
            TV_mariupol_war_panel.SetActive(false);
            }
            if(TV_arestovych_war_panel != null){
            TV_arestovych_war_panel.SetActive(true);
            }

            if(object_thirt_choice != null){
            object_thirt_choice.SetActive(false);
            }
            if(object_thirt_choice_black != null){
            object_thirt_choice_black.SetActive(false);
            }
            if(object_four_choice != null){
            object_four_choice.SetActive(false);
            }
            if(object_four_choice_black != null){
            object_four_choice_black.SetActive(false);
            }

            button_thirt_choice.interactable = false;
            button_four_choice.interactable = false;


            if(language == "" || language == "eng"){
            // обичный текст
            first_choice_text.text = "east priority";
            second_choice_text.text = "south priority";

            // черный текст
            first_choice_text_black.text = "east priority";
            second_choice_text_black.text = "south priority";
            }

            if (language == "Rus"){
            // обичный текст
            first_choice_text.text = "приоритет на восток";
            second_choice_text.text = "приоритет на юг";

            // черный текст
            first_choice_text_black.text = "приоритет на восток";
            second_choice_text_black.text = "приоритет на юг";
            }

            if (language == "UA"){
            // обичный текст
            first_choice_text.text = "пріоритет на схід";
            second_choice_text.text = "пріоритет на південь";

            // черный текст
            first_choice_text_black.text = "пріоритет на схід";
            second_choice_text_black.text = "пріоритет на південь";
            }

            if (language == "Pl"){
            // обичный текст
            first_choice_text.text = "priorytet na wschód";
            second_choice_text.text = "priorytet na południe";

            // черный текст
            first_choice_text_black.text = "priorytet na wschód";
            second_choice_text_black.text = "priorytet na południe";
            }

            if (language == "De"){
            // обичный текст
            first_choice_text.text = "vorrang nach Osten";
            second_choice_text.text = "priorität nach Süden";

            // черный текст
            first_choice_text_black.text = "vorrang nach Osten";
            second_choice_text_black.text = "priorität nach Süden";
            }

            // обнуляет прошлый текст
            Osnova_Scenario_text.text = "";

        }

        if (timer_promotion >= 1.15)
        {
            if(language == "" || language == "eng"){

            Osnova_Scenario_text.text = "you go on the offensive. which region to prioritize?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Rus"){
            Osnova_Scenario_text.text = "вы идете в контрнаступление. на какой регион поставить приоритет?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "UA"){
            Osnova_Scenario_text.text = "ви йдете в контрнаступ. на який регіон поставити пріоритет?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "Pl"){
            Osnova_Scenario_text.text = "idziesz do kontrofensywy. w jakim regionie należy nadać priorytet?";
            StartCoroutine(Scenario_Apperance());
            }

            if (language == "De"){
            Osnova_Scenario_text.text = "Du gehst in die Offensive. Welche Region soll priorisiert werden?";
            StartCoroutine(Scenario_Apperance());
            }

            timer_promotion = 0;

            // включает панель в случаи перезахода
            int_twenty_three = 1;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 4;

            // дать возможность выбрать первые два варианта
            decision_making = 12;
            PlayerPrefs.SetInt ("decision_making", decision_making);  

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
        }
    }
    }
    }
    }

    // ДВЕНАДЦАТАЯ СЦЕНАРНОЕ СОБИТИЕ (карта)
    if (int_koncovka == 2){
    if (int_special_plot == 12){
    if (int_promotion == 40){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }


            if(maps_tv_twelve_true != null){
            maps_tv_twelve_true.SetActive(false);
            }
            if(maps_tv_twelve_false != null){
            maps_tv_twelve_false.SetActive(false);
            }
            if(maps_tv_thirteen_true != null){
            maps_tv_thirteen_true.SetActive(true);
            }

            Maps_News_int = 25;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            // выключить на время все кнопки
            recist_timer_dont_touch = 3;

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "this had a positive effect on the future outcome of events";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "это положительно повлияло на дальнейший исход событий";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "це позитивно вплинуло на подальший результат подій";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "miało to pozytywny wpływ na dalszy wynik wydarzeń";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "dies hat sich positiv auf das weitere Ergebnis der Ereignisse ausgewirkt";
            StartCoroutine(Maps_Change_Apperance());
            }

            int_promotion = 41;
            timer_promotion = 0;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

        }
    }
    }
    }

    // ТРИНАДЦАТАЯ ПАНЕЛЬ (ПОСЛЕДНЯЯ ХОРОШЕЙ КОНЦОВКИ)
    if (int_twenty_five <= 0){
    if (int_koncovka == 2){
    if (int_special_plot == 13){
    if (int_promotion == 41){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(true);
            }


            if(maps_tv_thirteen_true != null){
            maps_tv_thirteen_true.SetActive(false);
            }
            if(maps_tv_fourteen_true != null){
            maps_tv_fourteen_true.SetActive(true);
            }

            Maps_News_int = 26;
            PlayerPrefs.SetInt ("Maps_News_int", Maps_News_int);  

            // обнуляет прошлый текст
            Osnova_Active_Maps_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            if(language == "" || language == "eng"){
            Osnova_Active_Maps_text.text = "you unlocked the good ending";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Rus"){
            Osnova_Active_Maps_text.text = "вы открыли хорошую концовку";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "UA"){
            Osnova_Active_Maps_text.text = "ви відкрили хорошу кінцівку";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "Pl"){
            Osnova_Active_Maps_text.text = "otworzyłeś dobre zakończenie";
            StartCoroutine(Maps_Change_Apperance());
            }

            if (language == "De"){
            Osnova_Active_Maps_text.text = "sie haben ein gutes Ende gefunden";
            StartCoroutine(Maps_Change_Apperance());
            }

            timer_promotion = 0;

            // включить панель которая закрывает ( и не дает никуда нажимать )
            int_dont_touch = 1;

            int_konec_scenario = 2;

            // поставить таймера во время которого нельзя будет ничего трогать 
            recist_timer_dont_touch = 2;

            int_twenty_five = 1;

        }

    }
    }
    }
    }

    // последняя сцена
    if (int_promotion == 43){
    if (int_konec_scenario == 2){
    timer_promotion += Time.deltaTime;
        if (timer_promotion >= 0.45)
        {
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(false);
            }
            if(end_scene != null){
            end_scene.SetActive(true);
            }
            if(end_scene_good != null){
            end_scene_good.SetActive(false);
            }

            // обнуляет прошлый текст
            end_scene_text.text = "";
        }

        if (timer_promotion >= 1.15)
        {
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }

            timer_promotion = 0;
            int_promotion = 44;
            PlayerPrefs.SetInt ("int_promotion", int_promotion);  

        }
    }
    }

    // изменялки (меняет картинки)
    if (end_music_good == 2){
    end_timer_good += Time.deltaTime;
        if (fack_cock <= 0){
        if (end_timer_good >= 42){
            if(transtion_object != null){
            transtion_object.SetActive(true);
            }
            transtion.Play("transtion");  
        } 
        }

        if (end_timer_good >= 42.45){         
            if(end_scene_good != null){
            end_scene_good.SetActive(true);
            } 
            fack_cock = 1;
        } 

        if (end_timer_good >= 43.5){ 

            if(transtion_object != null){
            transtion_object.SetActive(false);
            }   

            end_timer_good = 0;
            end_music_good = 3;
            PlayerPrefs.SetInt ("end_music_good", end_music_good);
        }  
    }

    if (end_music_good == 3){
        end_timer_good += Time.deltaTime;
        if (end_timer_good >= 30){

            if(language == "" || language == "eng"){
            end_scene_text.text = "thanks for playing the game";
            StartCoroutine(end_text_Apperance());
            }

            if (language == "Rus"){
            end_scene_text.text = "спасибо за прохождение игры";
            StartCoroutine(end_text_Apperance());
            }

            if (language == "UA"){
            end_scene_text.text = "дякую за проходження гри";
            StartCoroutine(end_text_Apperance());
            }

            if (language == "Pl"){
            end_scene_text.text = "thanks for playing the game";
            StartCoroutine(end_text_Apperance());
            }

            if (language == "De"){
            end_scene_text.text = "thanks for playing the game";
            StartCoroutine(end_text_Apperance());
            }

            end_timer_good = 0;
            end_music_good = 5;
        }
    }

    // ПАНЕЛЬ СНАЧАЛА
    if (SNACALA_ZAPOMNI == 1){
    if (SNACALA == 1){
        snacala_timer += Time.deltaTime;
        if (snacala_timer >= 77){
            snacala_timer = 0;
            SNACALA = 0;
        }
    }
    }

    if (SNACALA_ZAPOMNI == 1){
    if (SNACALA == 0){
        if(transtion_object != null){
        transtion_object.SetActive(true);
        }
        transtion.Play("transtion");

        SNACALA_ZAPOMNI = 2;
        PlayerPrefs.SetInt ("SNACALA_ZAPOMNI", SNACALA_ZAPOMNI); 
    }
    }

    if (SNACALA_ZAPOMNI == 2){
    snacala_timer += Time.deltaTime;
        if (snacala_timer >= 0.45){
            if(end_scene != null){
            end_scene.SetActive(false);
            }
            if(end_scene_good != null){
            end_scene_good.SetActive(false);
            }
            if(SNACALA_OBJECT != null){
            SNACALA_OBJECT.SetActive(true);
            }

            if(language == "" || language == "eng"){
            SNACALA_TEXT.text = "start over";
            }

            if (language == "Rus"){
            SNACALA_TEXT.text = "начать сначала";
            }

            if (language == "UA"){
            SNACALA_TEXT.text = "почати спочатку";
            }

            if (language == "Pl"){
            SNACALA_TEXT.text = "zacząć od nowa";
            }

            if (language == "De"){
            SNACALA_TEXT.text = "von vorne anfangen";
            }
        }

        if (snacala_timer >= 1.15){
        if(transtion_object != null){
        transtion_object.SetActive(false);  
        }

        snacala_timer = 0; 
        SNACALA_ZAPOMNI = 3;
        PlayerPrefs.SetInt ("SNACALA_ZAPOMNI", SNACALA_ZAPOMNI); 
        }
    }


    // закрыть панель
    if (closed_all >= 1)
    {
        timer_transtion += Time.deltaTime;
        if (timer_transtion >= 0.45)
        {
            if(Osnova_Scenario_object != null){
            Osnova_Scenario_object.SetActive(false);
            }
            if(Osnova_Active_Maps_object != null){
            Osnova_Active_Maps_object.SetActive(false);
            }
            if(Osnova_Plot_Scenario_object != null){
            Osnova_Plot_Scenario_object.SetActive(false);
            }
        }
        if (timer_transtion >= 1.15)
        {
            if(transtion_object != null){
            transtion_object.SetActive(false);
            }
            closed_all = 0;
            timer_transtion = 0;
        }
    }


    // конец Update
    }


}
}