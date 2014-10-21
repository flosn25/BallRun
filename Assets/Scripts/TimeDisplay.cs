using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	private UnityEngine.UI.Text Text_Time;
	private float timePassed;

	// Use this for initialization
	void Start () {
		timePassed = 0f;

		Text_Time = GameObject.Find("Text_Time").GetComponent<Text>();
		resetTime();
	}
	
	// Update is called once per frame
	void Update () {
		timePassed += Time.deltaTime;

		Text_Time.text = timePassed.ToString ("F2").PadLeft(6, '0');

	}

	void resetTime() {

		timePassed = 0f;
	}
}
