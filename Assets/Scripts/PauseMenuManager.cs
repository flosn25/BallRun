using UnityEngine;
using System.Collections;

public class PauseMenuManager : MonoBehaviour {

	public GameObject PauseMenuObject;
	private bool pauseGame = false;

	void Update () {

		if(transform.position.y <= -5)//check bei Runterfallen
		{

			Debug.Log("FAAAAAAAAAAAAAAALLLLEN");
//			LevelEnd levelEnd = new LevelEnd();//ruft LevelEnd c# funktion
//			levelEnd.LevelFail();//c# klasse wird aufgerufen
		}

		if (transform.position.y < 0) {
			Time.timeScale = 0;
			pauseGame = true;
			PauseMenuObject.SetActive (true);
			GameObject.Find ("Main Camera").GetComponent<CameraControl>().enabled = false;
				}

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

	void start () {
		Time.timeScale = 0;

		}
	
	// Update is called once per frame
	public void PauseMenu(Object mObject) {
		PauseMenuObject.SetActive (true);
	}

	public void switchToMainMenu () {
		Application.LoadLevel ("MainMenu");
}
	public void restartLevel() {
		Application.LoadLevel (Application.loadedLevelName);	}

	public void resume (Object mObject) {

		Time.timeScale =1;
		PauseMenuObject.SetActive (false);
		GameObject.Find ("Main Camera").GetComponent<CameraControl>().enabled = true;

		}

	 

}
