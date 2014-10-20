using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerUp : MonoBehaviour {
	/*/////////////////////////////////////
	PowerUp benötigt: 
		SphereCollider als Trigger!
		Animation, + beide PowerUp Scripte
	 //////////////////////////////////////*/

	public Player player;
	public Vector3 jumpVelocity;
	public bool touch;
	public Text SumScore;
	public Text LevelScore;
	public Text BonusScore;


	
	void Start() {
		GameObject playerObject = GameObject.Find ("Sphere");//
		player = playerObject.GetComponent<Player> ();//
	}

	void OnTriggerEnter (Collider col){


		player.points +=  1000; //Puntke bei einsammeln 1000 hochzählen
		SumScore = GameObject.Find ("Text_Points").GetComponent<Text> ();//Angezeigten Text finden
		SumScore.text = player.points.ToString();//Anzeige von Texten
		PlayerPrefs.SetString ("SumScore", player.points.ToString()); // global "festhalten"
		Debug.Log("SumScore= "+ PlayerPrefs.GetString ("SumScore"));
		Destroy(this.gameObject);//PowerUp auflösen

		if (collider.gameObject.name.Equals("pfeilmax")) //ob Sprung-PowerUp
		{
			player.rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);//"Sprung" durch AddForce, JumpVelocity per Hand nachgestellt (0,10,0)
			touch = false;// erst wieder Sprung, wenn Collision auf true
		}
	}
}
