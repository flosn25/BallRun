﻿using UnityEngine;
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
	void Start () {
	
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
		rigidbody.AddForce (50.0f * f);//20 fache beschleunigung, oder um 20 abbremsen, aber nicht vollständig stoppen

	}
	void OnCollisionEnter(Collision c){//Boddenkollision zum erneuten Sprung
		touch = true;
	}
}