using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpeedUp : MonoBehaviour {

	public float speedUpFactor = 5; // Faktor, um den timeScale erhöht wird
	private float prevSpeed; // Geschwindigkeit bevor Ball über Feld
	public AudioClip Sound;

	// Use this for initialization
	void Start() {
	}

	// Wenn Ball das Feld betritt
	void OnCollisionEnter(Collision collision) {
		prevSpeed = Time.timeScale; // vorherige Geschwindigkeit zwischenspeichern
		Time.timeScale *= speedUpFactor; // Geschwindigkeit mit Faktor multiplizieren
		//Debug.Log ("OnCollisionEnter: Player is above me");
		AudioSource.PlayClipAtPoint(Sound, transform.position);
	}

	// Wenn Ball das Feld wieder verlässt
	void OnCollisionExit(Collision collision) {
		Time.timeScale = prevSpeed; // vorherige Geschwindigkeit wieder herstellen
		//Debug.Log ("OnCollisionExit: Player is not above me any more");
	}

}
