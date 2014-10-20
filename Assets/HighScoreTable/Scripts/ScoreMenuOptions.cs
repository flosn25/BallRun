using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreMenuOptions : MonoBehaviour {

	public Text sumScoreTextObject;
	public string sumScoreString;


	// Use this for initialization
	void Start () {

		sumScoreString = PlayerPrefs.GetString ("SumScore"); // global "festhalten"	
		sumScoreTextObject = GameObject.Find ("SumScore").GetComponent<Text> (); //Angezeigten Text finden
		sumScoreTextObject.text = sumScoreString;//Anzeige von Texten

		Debug.Log ("Sum Score: " + sumScoreString);

		}
	
	// Update is called once per frame
	void Update () {

	}
	// Load 
	public void NextLevel () {
		Debug.Log("Next Level: ");
	}

}
