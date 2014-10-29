using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;


public class LevelEnd : MonoBehaviour {
	/*/////////////////////////////////////
	PowerUp benötigt: 
		SphereCollider als Trigger!
			Animation, + beide PowerUp Scripte
			//////////////////////////////////////*/
			
	public Player player;
	public Vector3 jumpVelocity;
	public bool touch;
	private UnityEngine.UI.Text Text_Time;
	private float timeFloat = 0;
	private string timeString = "";
	
	void Start() {
		GameObject playerObject = GameObject.Find ("Sphere");//
		player = playerObject.GetComponent<Player> ();//
		Text_Time = GameObject.Find("Text_Time").GetComponent<Text>();

	}
	// Wenn Ball das Feld betritt
	void OnCollisionEnter(Collision collision) {
		player.timebonus = 0;
		player.levelendpoints += 10000;


		var Punkte = GameObject.Find ("Text_Points").GetComponent<Text> ();//Angezeigten Text finden

		timeString = Regex.Replace(Text_Time.text, "[^.0-9]", "");
		timeFloat = float.Parse (timeString);

		Debug.Log ("TimeString: " + timeString);
		Debug.Log ("TimeFloat: " + timeFloat);

		if (timeFloat <= 45) {
			float timeBonus = (45 - timeFloat)*100;
			Debug.Log ("timeBonus float: "+ timeBonus);
			Debug.Log ("timeBonus int : "+ (int) timeBonus);
			player.timebonus = (int) timeBonus;
		}

		PlayerPrefs.SetInt ("CointPoints", player.cointpoints);
		PlayerPrefs.SetInt ("TimePoints", player.timebonus);
		PlayerPrefs.SetInt ("LevelEndPoints", player.levelendpoints);
		PlayerPrefs.SetInt ("JumpPoints", player.jumpbonus);

		/*PlayerPrefs.SetString ("CointPoints", player.cointpoints.ToString()); 
	    PlayerPrefs.SetString ("TimePoints", player.timebonus.ToString()); 
		PlayerPrefs.SetString ("LevelEndPoints", player.levelendpoints.ToString()); 
		PlayerPrefs.SetString ("JumpPoints", player.jumpbonus.ToString());*/

		player.points = player.cointpoints + player.timebonus + player.levelendpoints + player.jumpbonus;
		string levelNumberString = Regex.Replace(Application.loadedLevelName, "[^.0-9]", "");
		int levelNumberInt = int.Parse (levelNumberString);

		PlayerPrefs.SetInt ("SumScore", player.points);
		//PlayerPrefs.SetString ("SumScore", player.points.ToString()); // global "festhalten"

		Debug.Log ("Level Number: " + levelNumberInt);
		PlayerPrefs.SetInt ("CurrentLevel", levelNumberInt);	
		                     
		PlayerPrefs.Save ();
		Application.LoadLevel ("HighScoreTable");
	}
	public void LevelFail()
	{

	}


}
