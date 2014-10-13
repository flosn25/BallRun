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
	
	void Start() {
		GameObject playerObject = GameObject.Find ("Sphere");//
		player = playerObject.GetComponent<Player> ();//
	}

	void OnTriggerEnter (Collider col){
		player.points = player.points + 1000;//Puntke bei einsammeln 1000 hochzählen
		var Punkte = GameObject.Find ("Text_Points").GetComponent<Text> ();//Angezeigten Text finden
		Punkte.text = player.points.ToString();//Anzeige von Texten
		Destroy(this.gameObject);//PowerUp auflösen

		if (this.gameObject.Equals ("Capsule")) 
		{
			Debug.Log ("test");
		}
	}
}
