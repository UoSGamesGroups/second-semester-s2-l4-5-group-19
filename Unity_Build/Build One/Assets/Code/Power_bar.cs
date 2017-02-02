using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class Power_bar : MonoBehaviour {

	public Image Powerbar; 

	public float Fill; 

	public float Multiplier;  

	public float Force; 

	public GameObject Camera1; 

	public GameObject Camera2; 

	public Rigidbody2D Bird;

	private bool Powermax; 

	private bool Powerempty; 


	// Use this for initialization
	void Start () { 
		Camera2.SetActive (false);
		if (Fill == 1) {
			Powermax = true; 

			if (Fill == 0) { 
				Powerempty = true;
			}
		}
	}

	private void UpdatePower() {
		Powerbar.rectTransform.localScale = new Vector3 (Fill, 1, 1);
	}

	private void AddPower() { 
		Fill += 0.01f; 
		UpdatePower (); 
		if (Fill == 1) {
			ReducePower (); 
		}
	}

	private void ReducePower() {
		Fill -= 0.01f; 
		UpdatePower (); 
		if (Fill == 0) {
			AddPower ();
		}
	} 

	private void ApplyPower() {
		Force = Fill * Multiplier; 
	}

	// Update is called once per frame
	void Update () {
		if (Powermax) { 
			ReducePower();   
			//Fill -= 0.01f; 
			//Debug.Log ("power maxed");
			//UpdatePower(); 
			if (Powerempty) {
				AddPower();
			} 
			if (Input.GetKey (KeyCode.Space)) { 
				ApplyPower (); 
				Bird.AddForce (transform.right * Force); 
				Bird.AddForce (transform.up * Force); 
				Camera1.SetActive(false);
				Camera2.SetActive (true);
			}
		} 

		else if (Powerempty) {
			AddPower (); 
			if (Powermax) {
				ReducePower ();
			}
			//Fill += 0.01f; 
			//UpdatePower(); 
		}
	}
}
