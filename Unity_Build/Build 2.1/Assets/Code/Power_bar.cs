using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Power_bar : MonoBehaviour { 

	public float Fill = 0; 

	public Image bar; 

	public float Multiplier; 

	public float Force;  

	public GameObject Camera1; 

	public GameObject Camera2; 

	public Rigidbody2D Bird;

	private bool Powermax = false; 

	private 

	//private bool Powerempty = false;


	// Use this for initialization
	void Start () { 
		Camera2.SetActive (false);
		if (Fill == 0) {
			Powermax = false;		
		}

		if (Fill == 1) {
			Powermax = true;
		}
	}


	private void UpdatePower() {
		bar.rectTransform.localScale = new Vector3 (Fill, 1, 1);
	} 

	private void ApplyPower() {
		Force = Fill * Multiplier;
	} 

	// Update is called once per frame
	void Update () {
		if (Powermax == false) {
			Fill += 0.01f; 
			UpdatePower ();
		}
			
			if (Fill == 1) {
				Powermax = true;
			}

			else if (Fill == 1 || Fill>=1 ) {
				Powermax = true;
				Fill -= 0.01f;  
			}
		if (Powermax == true) {
			Fill -= 0.01f; 
			UpdatePower ();
		}

		if (Fill == 0) {
			Powermax = false;
		}

		else if (Fill == 0 || Fill<=0 ) {
			Powermax = false;
			Fill += 0.01f;  
		} 
		if (Input.GetKey (KeyCode.Space)) { 
			ApplyPower (); 
			Bird.AddForce (transform.right * Force); 
			Bird.AddForce (transform.up * Force); 
			Camera1.SetActive(false);
			Camera2.SetActive (true); 
			bar.rectTransform.localScale = new Vector3 (0, 1, 1); 
} 
}
}