using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMenuOptions : MonoBehaviour {

	public Text sumScoreTextObject, cointPointsTextObject, timePointsTextObject, levelEndPointsTextObject, jumpPointsTextObject;
	public string sumScoreString, cointPointsString, timePointsString, levelEndPointsString, jumpPointsString;
	
	// Use this for initialization
	void Start () {

		sumScoreString = PlayerPrefs.GetString ("SumScore"); // global "festhalten"	
		cointPointsString =  PlayerPrefs.GetString ("CointPoints"); // global "festhalten"	
		timePointsString =  PlayerPrefs.GetString ("TimePoints"); // global "festhalten"	
		levelEndPointsString =  PlayerPrefs.GetString ("LevelEndPoints"); // global "festhalten"	
		jumpPointsString =  PlayerPrefs.GetString ("JumpPoints"); // global "festhalten"	



		sumScoreTextObject = GameObject.Find ("SumScore").GetComponent<Text> (); //Angezeigten Text finden
		sumScoreTextObject.text = sumScoreString;//Anzeige von Texten

		cointPointsTextObject = GameObject.Find ("CointPoints").GetComponent<Text> (); //Angezeigten Text finden
		cointPointsTextObject.text = cointPointsString;//Anzeige von Texten

		jumpPointsTextObject = GameObject.Find ("JumpPoints").GetComponent<Text> (); //Angezeigten Text finden
		jumpPointsTextObject.text = jumpPointsString;//Anzeige von Texten


		levelEndPointsTextObject = GameObject.Find ("LevelEndPoints").GetComponent<Text> (); //Angezeigten Text finden
		levelEndPointsTextObject.text = levelEndPointsString;//Anzeige von Texten

		timePointsTextObject = GameObject.Find ("TimePoints").GetComponent<Text> (); //Angezeigten Text finden
		timePointsTextObject.text = timePointsString ;//Anzeige von Texten


		Debug.Log ("Sum Score: " + sumScoreString);
		Debug.Log ("Coint Score: " + cointPointsString);
		Debug.Log ("Time Score: " + timePointsString);
		Debug.Log ("Level End Score: " + levelEndPointsString);


		}
	
	// Update is called once per frame
	void Update () {

	}
	// Load 
	public void NextLevel () {
				Debug.Log ("Next Level: " + PlayerPrefs.GetInt ("CurrentLevel"));
				if (PlayerPrefs.GetInt ("CurrentLevel") < 3) {
			Application.LoadLevel ("Level" + (PlayerPrefs.GetInt ("CurrentLevel")+1));

				}
		}
}
