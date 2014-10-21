using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeDisplay : MonoBehaviour {

	private UnityEngine.UI.Text Text_Time;

	// Use this for initialization
	void Start () {
		Text_Time = GameObject.Find("Text_Time").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		Text_Time.text = "Zeit: " + Time.unscaledTime.ToString ("F2").PadLeft(6, '0');
	}
}
