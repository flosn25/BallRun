using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour {
	/*/////////////////////////////////////
	PowerUp benötigt: 
		SphereCollider als Trigger!
			Animation, + beide PowerUp Scripte
			//////////////////////////////////////*/
			
			public Player player;
	public Vector3 jumpVelocity;
	public bool touch;
	
	void Start() {
		GameObject playerObject = GameObject.Find ("Sphere");//
		player = playerObject.GetComponent<Player> ();//
	}
	// Wenn Ball das Feld betritt
	void OnCollisionEnter(Collision collision) {

		var Punkte = GameObject.Find ("Text_Points").GetComponent<Text> ();//Angezeigten Text finden

		Debug.Log ("OnCollisionEnter");
		Application.LoadLevel ("HighScoreTable");
	}



}
