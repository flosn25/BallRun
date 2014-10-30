using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	public Texture backgroundTexture;

	void onGUI(){
		Debug.Log ("ASD");
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture, ScaleMode.StretchToFill);
	}

	// Update is called once per frame
	void Update () {
	
	}
}
