using UnityEngine;
using System.Collections;

public class GameMenuBehaviour : MonoBehaviour {
	public bool pauseEnabled;

	// Use this for initialization
	void Start () {
		pauseEnabled = false;
		Time.timeScale = 1;
		AudioListener.volume = 1;
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update ()  {
		//check if pause button (escape key) is pressed
		if (Input.GetKeyDown (KeyCode.Escape) || Input.GetKeyDown (KeyCode.P))
		{
			//check if game is already paused
			if(pauseEnabled == true)
			{
				//unpause the game
				Debug.Log("PAUSE");
				pauseEnabled = false;
				Time.timeScale = 1;
				AudioListener.volume = 1;
				Screen.showCursor = false;
			}
			
			//else if game isn't paused, then pause it
			else if(pauseEnabled == false)
			{
				Debug.Log("UNPAUSE");

				pauseEnabled = true;
				AudioListener.volume = 0;
				Time.timeScale = 0;
				Screen.showCursor = true;
			}
		}
	}
}
