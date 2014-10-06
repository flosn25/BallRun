using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {
	/*/////////////////////////////////////
	PowerUp benötigt:
		SphereCollider als Trigger!
		Animation, + beide PowerUp Scripte
	 //////////////////////////////////////*/

	public Player player;
		
	void Start() {
		GameObject playerObject = GameObject.Find ("Sphere");
		player = playerObject.GetComponent<Player> ();
	}
	void OnTriggerEnter (Collider col){

		//Debug.Log (this.gameObject); // gibt angestoßenes Objekt aus
		//this.gameObject.renderer.enabled = false; //nicht möglich als Entfernen, da Objekt weiterhin im Weg 
		//StartCoroutine ("PlayAnimation");//Startet 
		player.points = player.points + 1000;
		Destroy(this.gameObject);
	}


	/*IEnumerator PlayAnimation()
	{
		//transform.animation.Play("PowerUp");//SPielt Animation PowerUp ab
		//yield return new WaitForSeconds(1);//wartet 1 Sekunde, so dass Animation ablaufen kann
		Destroy(this.gameObject);//löst PowerUp auf PowerUp
	}*/
}
