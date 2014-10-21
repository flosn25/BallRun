using UnityEngine;
using System.Collections;
/*
----------------------------------------------------------------
Handler zur Eingabe von Pfeiltasten, Leertaste
----------------------------------------------------------------
 */

public class Player : MonoBehaviour {
	// Use this for initialization
	public bool touch = true;
	public Vector3 jumpVelocity;
	public int points, cointpoints, levelendpoints, timebonus, jumpbonus;

	void Start () {
		PlayerPrefs.DeleteKey ("SumScore");
		PlayerPrefs.DeleteKey ("CointPoints");
		PlayerPrefs.DeleteKey ("TimePoints");
		PlayerPrefs.DeleteKey ("LevelEndPoints");
		PlayerPrefs.DeleteKey ("JumpPoints");


		Debug.Log ("Zeit zurücksetzen!");

		Time.timeScale = 0;
		points = 0;
		cointpoints = 0;
		levelendpoints = 0;
		timebonus = 0;
		jumpbonus = 0;

		StartCoroutine(WaitForKeyPress());
	}
	
	// Update is called once per frame
	void Update () {
		float h = Input.GetAxis("Horizontal");//Übernommen von Kurs-Material
		float v = Input.GetAxis("Vertical");
		if (touch && Input.GetButtonDown("Jump")){
			rigidbody.AddForce(jumpVelocity, ForceMode.VelocityChange);//"Sprung" durch AddForce, JumpVelocity per Hand nachgestellt (0,10,0)
			touch = false;// erst wieder Sprung, wenn Collision auf true
		}
		Vector3 f =  new Vector3 (h, 0, v);//zur Bewegung links, rechts, vorwärts, rückwärts
		rigidbody.AddForce (120.0f * f);//120 fache beschleunigung, oder um 20 abbremsen, aber nicht vollständig stoppen

	}
	void OnCollisionEnter(Collision c){//Boddenkollision zum erneuten Sprung
		touch = true;
	}

	public IEnumerator WaitForKeyPress()
	{
		while(true)
		{
			if(Input.anyKeyDown)
			{
				Time.timeScale = 1;
				break;
			}
			yield return 0;
		}
	}
}