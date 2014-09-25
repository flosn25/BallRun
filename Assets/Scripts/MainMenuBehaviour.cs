using UnityEngine;
using System.Collections;

public class MenuBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
//		if (Input.GetKeyDown (KeyCode.Escape) && (!Application.loadedLevel.Equals("MainMenu")))
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Debug.Log("Currnt Scene = "+Application.loadedLevelName); 
			Time.timeScale=0;

			if (!Application.loadedLevel.Equals(1)) {
					Debug.Log("Main Menu called");

						Application.LoadLevel ("MainMenu");
			}
			else {
				Debug.Log("We are in main menu. Continue Level is called");
				Application.LoadLevel ("Level1");
			}
		}
	}
}
