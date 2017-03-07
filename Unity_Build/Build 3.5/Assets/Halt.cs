using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halt : MonoBehaviour { 

	public Rigidbody2D PlayerOne; 

	public Rigidbody2D PlayerTwo; 

	public BoxCollider2D Mud; 

	// Use this for initialization 

	void Start() {
		
	}
	void OnCollisonEnter2D(Collision2D coll) {
		if (gameObject.tag == "PlayerOne") {
			PlayerOne.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
			//PlayerOne.GetComponent<Rigidbody2D>().angularVelocity = Vector3.zero;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
