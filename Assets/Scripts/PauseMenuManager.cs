using UnityEngine;
using System.Collections;

public class PauseMenuManager : MonoBehaviour {

	public GameObject PauseMenuObject;
	private bool pauseGame = false;

	void Update () {
		PlayerPrefs.SetInt("fail",0);
		PlayerPrefs.Save ();

		if (Input.GetKeyDown (KeyCode.Escape)) {

						pauseGame = !pauseGame;
						if (pauseGame == true) {
								Time.timeScale = 0;
								pauseGame = true;
								PauseMenuObject.SetActive (true);
								GameObject.Find ("Main Camera").GetComponent<CameraControl>().enabled = false;
						}
						if (pauseGame == false) {
								Time.timeScale = 1;
								pauseGame = false;
								PauseMenuObject.SetActive (false);
								GameObject.Find ("Main Camera").GetComponent<CameraControl>().enabled = true;
						}
				}
		}

	public void pauseForFail() {
		PlayerPrefs.SetInt("fail",1);
		PlayerPrefs.Save ();

		Time.timeScale = 1;
		pauseGame = true;
		PauseMenuObject.SetActive (true);
		GameObject.Find ("Main Camera").GetComponent<CameraControl>().enabled = false;




	}

	void start () {

		Time.timeScale = 0;
		}
	
	public void PauseMenu(Object mObject) {
		PauseMenuObject.SetActive (true);
	}

	public void switchToMainMenu () {
		Application.LoadLevel ("MainMenu");
}
	public void restartLevel() {
		Application.LoadLevel (Application.loadedLevelName);	

	}

	public void resume (Object mObject) {

		Time.timeScale =1;
		PauseMenuObject.SetActive (false);
		GameObject.Find ("Main Camera").GetComponent<CameraControl>().enabled = true;

		}
}
