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
	public AudioClip Sound;

	
	void Start() {
		GameObject playerObject = GameObject.Find ("Sphere");//
		player = playerObject.GetComponent<Player> ();//
	}

	void OnTriggerEnter (Collider col){
		
		AudioSource.PlayClipAtPoint(Sound, transform.position);//spielt Sound ab
		player.points +=  1000; //Puntke bei einsammeln 1000 hochzählen

		SumScore = GameObject.Find ("Text_Points").GetComponent<Text> ();//Angezeigten Text finden
		SumScore.text = player.points.ToString();//Anzeige von Texten
		//Debug.Log("SumScore= "+ PlayerPrefs.GetString ("SumScore"));
		Destroy(this.gameObject);//PowerUp auflösen

		if (collider.gameObject.name.Equals("pfeilmax")) //ob Sprung
		{
			player.jumpbonus += 1000;
			Debug.Log("JumpBonus= " + player.jumpbonus);

			player.rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);//"Sprung" durch AddForce, JumpVelocity per Hand nachgestellt (0,10,0)
			touch = false;// erst wieder Sprung, wenn Collision auf true
		}

		if (collider.gameObject.name.Equals("Cylinder")) //ob Coins
		{
			player.cointpoints += 1000;
			Debug.Log("CointsPoints= "+ player.cointpoints);

			
			player.rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);//"Sprung" durch AddForce, JumpVelocity per Hand nachgestellt (0,10,0)
			touch = false;// erst wieder Sprung, wenn Collision auf true
		}
	}
}
