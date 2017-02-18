using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class Playertwo_Stamina : MonoBehaviour {

	public Rigidbody2D Peng; 

	public float thrust = 20.0f; 

	public float Stamina = 1f; 

	public Image Staminabar; 

	public Text Staminartxt; 

	private bool OutOfStamina = false; 



	void Start () {
		if (Stamina == 0f) {
			OutOfStamina = true;
		}
	}

	private void UpdateStamina() {
		Staminabar.rectTransform.localScale = new Vector3 (Stamina, 1, 1);
	}

	void Update () { 

		if (OutOfStamina == true) 
		{
			Staminartxt.text = ("Out of Stamina");
		}


		else if(Input.GetKey (KeyCode.I)){	
			Peng.AddForce (transform.up * thrust); 
			Stamina -= 0.004f;  
			UpdateStamina();
		}

		else if (Input.GetKey (KeyCode.P)){
			Peng.AddForce (transform.right * thrust);
			Stamina -= 0.001f; 
			UpdateStamina ();

		}

		else if (Stamina == 0f || Stamina <= 0f){ 
			//Stamina < 0f;
			OutOfStamina = true;
		}
	} 
}

