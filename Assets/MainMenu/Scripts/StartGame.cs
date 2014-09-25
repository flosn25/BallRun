using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	// Load 
	public void PlayGame () {
		Application.LoadLevel ("Level1");

	}

	public void QuitGame() {
				Application.Quit ();
		}
}
