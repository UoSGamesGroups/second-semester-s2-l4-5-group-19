﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class BirdDistance : MonoBehaviour {

	public Rigidbody2D rb;

	public bool launched = false;
	public float PlayerX;
	public float PlayerSpeed;
	public string information;
	public Text text; 


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update() {

		//  Gets speed of the bird
		PlayerSpeed = rb.velocity.magnitude;

		//  If Bird speed is high enough and has not be launched it will run this to toggle launched to be true.
		if(PlayerSpeed > 1.2 && launched == false)
		{
			launched = true;
		}

		//  If bird has been launched and bird has come to a stop it will take a note of the position on the x axies of the ridged body in worldspace
		if (launched == true && PlayerSpeed < 0.1)
		{
			PlayerX = rb.position.x; 
			information = "Your Distance: " + PlayerX.ToString("N1");
			//information + PlayerX.ToString;
			text.text = information;
			//Debug.Log(PlayerX);
		}
	}
}