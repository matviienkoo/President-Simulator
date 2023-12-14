using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Maps_and_News : MonoBehaviour {

public GameObject Sirena_object;
public string language;

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

public int Maps_News_int;

public Text News_text;
public Text Reaction_text;

void Update (){
Maps_News_int = PlayerPrefs.GetInt("Maps_News_int");
language = PlayerPrefs.GetString("Lang");

if (Maps_News_int == 1){
if(Sirena_object != null){
Sirena_object.SetActive(false);
}
if(maps_tv_first_true != null){
maps_tv_first_true.SetActive(true);
}
// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "The war has begun, what to do next?";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "Началась война, что делать дальше?";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "Почалася війна, що робити далі?";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Rozpoczęła się wojna, co dalej?";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "Der Krieg hat begonnen, was soll ich als nächstes tun?";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}
// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
if(maps_tv_first_false != null){
maps_tv_first_false.SetActive(false);
}
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
maps_tv_thirt_false.SetActive(false);
}
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
maps_tv_five_false.SetActive(false);
}
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
maps_tv_seven_false.SetActive(false);
}
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
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 2){
if(maps_tv_first_false != null){
maps_tv_first_false.SetActive(true);
}

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "The war has begun, what to do next?";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "Началась война, что делать дальше?";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "Почалася війна, що робити далі?";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Rozpoczęła się wojna, co dalej?";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "Der Krieg hat begonnen, was soll ich als nächstes tun?";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}


// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
if(maps_tv_first_true != null){
maps_tv_first_true.SetActive(false);
}
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
maps_tv_thirt_false.SetActive(false);
}
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
maps_tv_five_false.SetActive(false);
}
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
maps_tv_seven_false.SetActive(false);
}
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
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 3){
if(maps_tv_second_false != null){
maps_tv_second_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "the big problem of the migration crisis, what should europe do?";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "большая проблема миграционного кризиса, что делать европе?";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "велика проблема міграційної кризи, що робити європі?";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "duży problem kryzysu migracyjnego, co powinna zrobić Europa?";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "das große Problem der Migrationskrise, was soll Europa tun?";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
if(maps_tv_first_true != null){
maps_tv_first_true.SetActive(false);
}
if(maps_tv_first_false != null){
maps_tv_first_false.SetActive(false);
}
if(maps_tv_second_true != null){
maps_tv_second_true.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 4){
if(maps_tv_second_true != null){
maps_tv_second_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "the big problem of the migration crisis, what should Europe do?";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "большая проблема миграционного кризиса, что делать Европе?";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "велика проблема міграційної кризи, що робити європі?";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "duży problem kryzysu migracyjnego, co powinna zrobić Europa?";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "das große Problem der Migrationskrise, was soll Europa tun?";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
if(maps_tv_first_true != null){
maps_tv_first_true.SetActive(false);
}
if(maps_tv_first_false != null){
maps_tv_first_false.SetActive(false);
}
if(maps_tv_second_false != null){
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 5){
if(maps_tv_thirt_true != null){
maps_tv_thirt_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "america has approved more military aid";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "америка утвердила большую военную помощь";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "америка утвердила велику військову допомогу";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Ameryka zatwierdziła dużą pomoc wojskową";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "Amerika genehmigt große militärische Hilfe";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
if(maps_tv_thirt_false != null){
maps_tv_thirt_false.SetActive(false);
}
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
maps_tv_five_false.SetActive(false);
}
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
maps_tv_seven_false.SetActive(false);
}
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
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 6){
if(maps_tv_thirt_false != null){
maps_tv_thirt_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "america has approved more military aid";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "америка утвердила большую военную помощь";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "америка утвердила велику військову допомогу";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Ameryka zatwierdziła dużą pomoc wojskową";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "Amerika genehmigt große militärische Hilfe";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
if(maps_tv_thirt_true != null){
maps_tv_thirt_true.SetActive(false);
}
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
maps_tv_five_false.SetActive(false);
}
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
maps_tv_seven_false.SetActive(false);
}
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
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 7){
if(maps_tv_four_true != null){
maps_tv_four_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "snake island is now under occupation";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "остров змеиный теперь под оккупацией";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "острів зміїний тепер під окупацією";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Wyspa węża jest teraz pod okupacją";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "Schlangeninsel steht jetzt unter Besetzung";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
if(maps_tv_thirt_true != null){
maps_tv_thirt_true.SetActive(false);
}
if(maps_tv_thirt_false != null){
maps_tv_thirt_false.SetActive(false);
}
if(maps_tv_four_false != null){
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 8){
if(maps_tv_four_false != null){
maps_tv_four_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "snake island is now under occupation";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "остров змеиный теперь под оккупацией";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "острів зміїний тепер під окупацією";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Wyspa węża jest teraz pod okupacją";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "Schlangeninsel steht jetzt unter Besetzung";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
if(maps_tv_thirt_true != null){
maps_tv_thirt_true.SetActive(false);
}
if(maps_tv_thirt_false != null){
maps_tv_thirt_false.SetActive(false);
}
if(maps_tv_four_true != null){
maps_tv_four_true.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 9){
if(maps_tv_five_true != null){
maps_tv_five_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "chernobyl was captured, then Kyiv?";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "чернобыль захватили, дальше киев?";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "чорнобиль захопили, далі київ?";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Czarnobyl zdobyty, dalej Kijów?";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "tschernobyl wurde erobert, Kiew weiter?";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
if(maps_tv_five_false != null){
maps_tv_five_false.SetActive(false);
}
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
maps_tv_seven_false.SetActive(false);
}
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
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 10){
if(maps_tv_five_false != null){
maps_tv_five_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "chernobyl was captured, then Kyiv?";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "чернобыль захватили, дальше киев?";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "чорнобиль захопили, далі київ?";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Czarnobyl zdobyty, dalej Kijów?";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "tschernobyl wurde erobert, Kiew weiter?";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
if(maps_tv_five_true != null){
maps_tv_five_true.SetActive(false);
}
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
maps_tv_seven_false.SetActive(false);
}
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
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 11){
if(maps_tv_five_true != null){
maps_tv_five_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "how successful is the war?";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "насколько успешно идет война?";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "наскільки успішно йде війна?";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "jak udana jest wojna?";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "wie erfolgreich ist der Krieg?";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
if(maps_tv_five_false != null){
maps_tv_five_false.SetActive(false);
}
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
maps_tv_seven_false.SetActive(false);
}
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
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 12){
if(maps_tv_six_false != null){
maps_tv_six_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "how successful is the war?";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "насколько успешно идет война?";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "наскільки успішно йде війна?";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "jak udana jest wojna?";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "wie erfolgreich ist der Krieg?";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
if(maps_tv_five_true != null){
maps_tv_five_true.SetActive(false);
}
if(maps_tv_five_false != null){
maps_tv_five_false.SetActive(false);
}
if(maps_tv_six_true != null){
maps_tv_six_true.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 13){
if(maps_tv_six_true != null){
maps_tv_six_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "does anyone read this paper?";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "читает ли кто-то эту газету?";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "чи хтось читає цю газету?";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "czy ktoś czyta tę gazetę?";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "liest jemand diese Zeitung?";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
if(maps_tv_five_true != null){
maps_tv_five_true.SetActive(false);
}
if(maps_tv_five_false != null){
maps_tv_five_false.SetActive(false);
}
if(maps_tv_six_false != null){
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 14){
if(maps_tv_seven_false != null){
maps_tv_seven_false.SetActive(true);
}

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "does anyone read this paper?";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "читает ли кто-то эту газету?";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "Чи хтось читає цю газету?";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}	
if (language == "Pl")
{
	News_text.text = "czy ktoś czyta tę gazetę?";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "liest jemand diese Zeitung?";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
if(maps_tv_seven_true != null){
maps_tv_seven_true.SetActive(false);
}
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
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 15){
if(maps_tv_seven_true != null){
maps_tv_seven_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "should we start preparing for a nuclear war?";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "стоит ли начинать готовиться к ядерной войне?";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "чи варто починати готуватися до ядерної війни?";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "czy warto przygotować się do wojny nuklearnej?";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "lohnt es sich, sich auf einen Atomkrieg vorzubereiten?";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
if(maps_tv_seven_false != null){
maps_tv_seven_false.SetActive(false);
}
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
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 16){
if(maps_tv_eight_false != null){
maps_tv_eight_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "should we start preparing for a nuclear war?";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "стоит ли начинать готовиться к ядерной войне?";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "чи варто починати готуватися до ядерної війни?";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "czy warto przygotować się do wojny nuklearnej?";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "lohnt es sich, sich auf einen Atomkrieg vorzubereiten?";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
if(maps_tv_seven_true != null){
maps_tv_seven_true.SetActive(false);
}
if(maps_tv_seven_false != null){
maps_tv_seven_false.SetActive(false);
}
if(maps_tv_eight_true != null){
maps_tv_eight_true.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 17){
if(maps_tv_ten_true != null){
maps_tv_ten_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "how i got tired of doing this job";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "как же я устал делать эту работу";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "як же я втомився робити цю роботу";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "jestem zmęczony tą pracą.";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "ich bin es leid, diesen Job zu machen.";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
if(maps_tv_ten_false != null){
maps_tv_ten_false.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 18){
if(maps_tv_ten_false != null){
maps_tv_ten_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "how i got tired of doing this job";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "как же я устал делать эту работу";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "як же я втомився робити цю роботу";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "jestem zmęczony tą pracą.";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "ich bin müde von diesem Job.";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
if(maps_tv_ten_true != null){
maps_tv_ten_true.SetActive(false);
}
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
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 19){
if(maps_tv_eleven_true != null){
maps_tv_eleven_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "end of the ukrainian economy?";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "украинской экономике конец?";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "українській економіці кінець?";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "koniec ukraińskiej gospodarki?";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "das Ende der ukrainischen Wirtschaft?";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
if(maps_tv_ten_true != null){
maps_tv_ten_true.SetActive(false);
}
if(maps_tv_ten_false != null){
maps_tv_ten_false.SetActive(false);
}
if(maps_tv_eleven_false != null){
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 20){
if(maps_tv_eleven_false != null){
maps_tv_eleven_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "end of the ukrainian economy?";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "украинской экономике конец?";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "українській економіці кінець?";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "koniec ukraińskiej gospodarki?";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "das Ende der ukrainischen Wirtschaft?";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
if(maps_tv_ten_true != null){
maps_tv_ten_true.SetActive(false);
}
if(maps_tv_ten_false != null){
maps_tv_ten_false.SetActive(false);
}
if(maps_tv_eleven_true != null){
maps_tv_eleven_true.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 21){
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "the city is under blockade, what will happen to civilians?";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "город в блокаде, что будет с мирными людьми?";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "місто у блокаді, що буде з мирними людьми?";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "miasto w blokadzie, co stanie się z pokojowymi ludźmi?";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "eine Stadt in der Blockade, was wird mit den friedlichen Menschen passieren?";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 22){
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "the city is under blockade, what will happen to civilians?";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "город в блокаде, что будет с мирными людьми?";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "місто у блокаді, що буде з мирними людьми?";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "miasto w blokadzie, co stanie się z pokojowymi ludźmi?";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "eine Stadt in der Blockade, was wird mit den friedlichen Menschen passieren?";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

// - bad end
if (Maps_News_int == 23){
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(true);
}

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "ukrainian government capitulates";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "украинское правительство капитулирует";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "український уряд капітулює";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}	
if (language == "Pl")
{
	News_text.text = "ukraiński rząd kapituluje";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "ukrainische Regierung kapituliert";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 24){
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "ukrainian government capitulates";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "украинское правительство капитулирует";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "український уряд капітулює";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "ukraiński rząd kapituluje";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "ukrainische Regierung kapituliert";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
}

// - good end
if (Maps_News_int == 25){
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "ukraine goes on a successful counteroffensive";
	Reaction_text.text = "you have made a good decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "украина идет в успешное контрнаступление";
	Reaction_text.text = "вы приняли хорошое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "україна йде в успішний контрнаступ";
	Reaction_text.text = "ви прийняли гарне рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Ukraina idzie do udanej kontrofensywy";
	Reaction_text.text = "podjąłeś dobrą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "ukraine geht in eine erfolgreiche Gegenoffensive";
	Reaction_text.text = "Sie haben eine gute Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

if (Maps_News_int == 26){
if(maps_tv_fourteen_true != null){
maps_tv_fourteen_true.SetActive(true);
}	

// ТЕКСТ ГАЗЕТЫ
if(language == "" || language == "eng")
{
	News_text.text = "ukraine goes on a successful counteroffensive";
	Reaction_text.text = "you made a bad decision. it will affect the war.";
}
if (language == "Rus")
{
	News_text.text = "украина идет в успешное контрнаступление";
	Reaction_text.text = "вы приняли плохое решение. это повлияет на войну.";
}
if (language == "UA")
{
	News_text.text = "україна йде в успішний контрнаступ";
	Reaction_text.text = "ви прийняли погане рішення. це вплине на війну.";
}
if (language == "Pl")
{
	News_text.text = "Ukraina idzie do udanej kontrofensywy";
	Reaction_text.text = "podjąłeś złą decyzję. to wpłynie na wojnę.";
}

if (language == "De")
{
	News_text.text = "Die Ukraine geht auf eine erfolgreiche Gegenoffensive ein";
	Reaction_text.text = "du hast die falsche Entscheidung getroffen. das wird den Krieg beeinflussen.";
}

// ВЫКЛЮЧАЕТ ВСЕ ОСТАЛЬНОЕ
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
maps_tv_second_false.SetActive(false);
}
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
maps_tv_four_false.SetActive(false);
}
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
maps_tv_six_false.SetActive(false);
}
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
maps_tv_eight_false.SetActive(false);
}
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
maps_tv_eleven_false.SetActive(false);
}
if(maps_tv_twelve_true != null){
maps_tv_twelve_true.SetActive(false);
}
if(maps_tv_twelve_false != null){
maps_tv_twelve_false.SetActive(false);
}
if(maps_tv_thirteen_true != null){
maps_tv_thirteen_true.SetActive(false);
}
if(maps_tv_thirteen_false != null){
maps_tv_thirteen_false.SetActive(false);
}
if(maps_tv_fourteen_false != null){
maps_tv_fourteen_false.SetActive(false);
}
}

// конец Update 
}
}