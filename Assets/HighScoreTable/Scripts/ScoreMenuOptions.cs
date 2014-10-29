using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMenuOptions : MonoBehaviour {

	public Text textObject; //, cointPointsTextObject, timePointsTextObject, levelEndPointsTextObject, jumpPointsTextObject;
	public int sumScore, cointPoints, timePoints, levelEndPoints, jumpPoints;
	public Player player;

	// Use this for initialization
	void Start () {

		sumScore = PlayerPrefs.GetInt ("SumScore"); // global "festhalten"
		PlayerPrefs.SetInt("SumScoreAllTime", Mathf.Max(PlayerPrefs.GetInt("SumScoreAllTime"), sumScore));
		cointPoints =  PlayerPrefs.GetInt ("CointPoints"); // global "festhalten"	
		PlayerPrefs.SetInt("CointPointsAllTime", Mathf.Max(PlayerPrefs.GetInt("CointPointsAllTime"), cointPoints));
		timePoints =  PlayerPrefs.GetInt ("TimePoints"); // global "festhalten"	
		PlayerPrefs.SetInt("TimePointsAllTime", Mathf.Max(PlayerPrefs.GetInt("TimePointsAllTime"), timePoints));
		levelEndPoints =  PlayerPrefs.GetInt ("LevelEndPoints"); // global "festhalten"	
		PlayerPrefs.SetInt("LevelEndPointsAllTime", Mathf.Max(PlayerPrefs.GetInt("LevelEndPointsAllTime"), levelEndPoints));
		jumpPoints =  PlayerPrefs.GetInt ("JumpPoints"); // global "festhalten"	*/
		PlayerPrefs.SetInt("JumpPointsAllTime", Mathf.Max(PlayerPrefs.GetInt("JumpPointsAllTime"), jumpPoints));

		PlayerPrefs.Save ();

		textObject = GameObject.Find ("SumScore").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = sumScore.ToString();//Anzeige von Texten
		textObject = GameObject.Find ("SumScoreAllTime").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = PlayerPrefs.GetInt ("SumScoreAllTime").ToString();//Anzeige von Texten

		textObject = GameObject.Find ("CointPoints").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = cointPoints.ToString();
		textObject = GameObject.Find ("CointPointsAllTime").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = PlayerPrefs.GetInt("CointPointsAllTime").ToString();

		textObject = GameObject.Find ("JumpPoints").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = jumpPoints.ToString();
		textObject = GameObject.Find ("JumpPointsAllTime").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = PlayerPrefs.GetInt("JumpPointsAllTime").ToString();

		textObject = GameObject.Find ("LevelEndPoints").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = levelEndPoints.ToString();
		textObject = GameObject.Find ("LevelEndPointsAllTime").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = PlayerPrefs.GetInt("LevelEndPointsAllTime").ToString();

		textObject = GameObject.Find ("TimePoints").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = timePoints.ToString();
		textObject = GameObject.Find ("TimePointsAllTime").GetComponent<Text> (); //Angezeigten Text finden
		textObject.text = PlayerPrefs.GetInt("TimePointsAllTime").ToString();


		/*Debug.Log ("Sum Score: " + sumScoreString);
		Debug.Log ("Coint Score: " + cointPointsString);
		Debug.Log ("Time Score: " + timePointsString);
		Debug.Log ("Level End Score: " + levelEndPointsString);*/


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
