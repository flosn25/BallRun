using UnityEngine;
using System.Collections;

public class DisableResumeButton : MonoBehaviour
{
	public GameObject myObject;

	void Start (){
		if (PlayerPrefs.GetInt ("fail") == 1) {
			Debug.Log ("dasd");
		myObject.SetActive (false);
			PlayerPrefs.SetInt("fail",0);
			PlayerPrefs.Save ();

		}

		else {
			myObject.SetActive (true);

	}

}
}