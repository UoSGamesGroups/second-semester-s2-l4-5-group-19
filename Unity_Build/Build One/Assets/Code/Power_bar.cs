using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class Power_bar : MonoBehaviour {

	public Image Powerbar; 

	public float Fill; 

	public float Force; 

	public Rigidbody2D Bird;

	private bool Powermax; 


	// Use this for initialization
	void Start () {
		if (Fill == 1) {
			Powermax = true;
		}
	}

	private void UpdatePower() {
		Powerbar.rectTransform.localScale = new Vector3 (Fill, 1, 1);
	}

	private void AddPower() { 
		Fill += 0.01f; 
		UpdatePower ();
	}

	private void ReducePower() {
		Fill -= 0.01f; 
		UpdatePower ();
	}
	// Update is called once per frame
	void Update () {
		if (Powermax) { 
			ReducePower();  
			//Fill -= 0.01f; 
			//Debug.Log ("power maxed");
			//UpdatePower(); 
			if (Fill == 0) {
				AddPower();
			}
		} 

		//else if (Powermax == false) {
			//Fill += 0.01f; 
			//UpdatePower(); 
		//}
	}
}
