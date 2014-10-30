using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Text.RegularExpressions;


public class LevelEnd : MonoBehaviour {
			
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

	void OnCollisionEnter(Collision collision) {

		player.timebonus = 0;
		player.levelendpoints += 10000;
		
//		var Punkte = GameObject.Find ("Text_Points").GetComponent<Text> ();//Angezeigten Text finden

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


		player.points = player.cointpoints + player.timebonus + player.levelendpoints + player.jumpbonus;
		string levelNumberString = Regex.Replace(Application.loadedLevelName, "[^.0-9]", "");
		int levelNumberInt = int.Parse (levelNumberString);
		PlayerPrefs.SetInt ("SumScore", player.points);

		Debug.Log ("Level Number: " + levelNumberInt);
		PlayerPrefs.SetInt ("CurrentLevel", levelNumberInt);	
		                     
		PlayerPrefs.Save ();
		Application.LoadLevel ("HighScoreTable");

	}
}
