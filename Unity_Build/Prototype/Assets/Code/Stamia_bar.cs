using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamia_bar : MonoBehaviour {

	public Rigidbody2D bird; 

	public float thrust = 20.0f; 

	public float cooldown = 2f; 

	public float Stamina = 100f; 

	public GameObject Staminabar; 

	private bool OutOfStamina = false; 

	// Use this for initialization
	void Start () {
		bird = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	//void Update() {
		//if (cooldown <= Time.time);
	//}

	void Update () { 
		//if (cooldown <= Time.time) { 
		//if (OutOfStamina == true) 
		//{
			//Debug.Log("Out of Stamina") 
		//}
		
		 //if (OutOfStamina == false) 
		//{
			if (Input.GetKey (KeyCode.Q))
				bird.AddForce (transform.up * thrust); 
				//Stamina - 50f;
			//bird.AddForce(transform.right * thrust); 
			if (Input.GetKey (KeyCode.E))
				bird.AddForce (transform.right * thrust);
				//Stamina - 50f;
			//if (Stamina == 0f); 
				//OutOfStamina = true;
		}
	}
//} 

