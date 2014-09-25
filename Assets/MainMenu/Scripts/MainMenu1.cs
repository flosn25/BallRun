using UnityEngine;
using System.Collections;

public class MainMenu1 : MonoBehaviour {

	public Texture backgroundTexture;

	// Use this for initialization
	void Start () {
//		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);
	
	}
	void onGUI(){
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), backgroundTexture);

		}
	
	// Update is called once per frame
	void Update () {
	
	}
}
