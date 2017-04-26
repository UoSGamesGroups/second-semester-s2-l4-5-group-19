using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Power_bar : MonoBehaviour { 

	public float Fill = 0; 

	public Image bar; 

	public float Multiplier; 

	public float Force;  

	public float LateForce;

	public GameObject Camera1; 

	public GameObject Camera2; 

	public GameObject Camera3; 

	public GameObject Camera4;

	public Rigidbody2D Bird; 

	public Rigidbody2D Peng; 

	public float Player1Speed; 

	public float Player2Speed;

	private bool Powermax = false; 

	private bool P1launched = false; 

	private bool P2launched = false; 

	private bool DelayedTime = false;

	private bool OneLaunch = false;
	private bool TwoLaunch = false;

	public BirdDistance p1Distance;
	public BirdDistance p2Distance;

	//private bool Powerempty = false;


	// Use this for initialization
	void Start () { 
		Bird.isKinematic = true;
		Peng.isKinematic = true;
		Player1Speed = Bird.velocity.magnitude; 
		Player2Speed = Peng.velocity.magnitude;
		Camera2.SetActive (false);
		Camera4.SetActive (false);
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
		LateForce = Force / 2; 
	}



	// Update is called once per frame
	void Update() {
		if (Player1Speed > 1.2 && P1launched == false) {
			P1launched = true;
		}

		if (Player2Speed > 1.2 && P2launched == false) {
			P2launched = true;
		}

		if (Powermax == false) {
			Fill += 0.01f;
			UpdatePower ();
		}

		if (Fill == 1) {
			Powermax = true;
		} else if (Fill == 1 || Fill >= 1) {
			Powermax = true;
			Fill -= 0.01f;
		}
		if (Powermax == true) {
			Fill -= 0.01f;
			UpdatePower ();
		}

		if (Fill == 0) {
			Powermax = false;
		} else if (Fill == 0 || Fill <= 0) {
			Powermax = false;
			Fill += 0.01f;
		}
		//bool getLaunch = p1Distance.GetComponent<BirdDistance>().launched;
		if (Input.GetKey (KeyCode.Space) && OneLaunch == false) {
			OneLaunch = true;
			Bird.isKinematic = false;
			ApplyPower ();
			Bird.AddForce (transform.right * 2);
			Bird.AddForce (transform.up * 100);
			Camera1.SetActive (false);
			Camera2.SetActive (true);
			bar.rectTransform.localScale = new Vector3 (0, 1, 1);
		}
		if (P1launched == true && Player1Speed < 0.1) {
			Camera2.SetActive (false);
			Camera1.SetActive (true);
		}

		//bool newgetLaunch = p2Distance.GetComponent<BirdDistance>().launched;
		if (Input.GetKey (KeyCode.Return) && TwoLaunch == false) {
			TwoLaunch = true;
			Peng.isKinematic = false;
			ApplyPower ();
			Peng.AddForce (transform.right * 2);
			Peng.AddForce (transform.up * 100 );
			Camera3.SetActive (false);
			Camera4.SetActive (true);
			bar.rectTransform.localScale = new Vector3 (0, 1, 1);
		}
		if (P2launched == true && Player2Speed < 0.1) {
			Camera4.SetActive (false);
			Camera3.SetActive (true);
		}
		else if (DelayedTime == false)  {
			StartCoroutine (Late()); 
			DelayedTime = true;
		} 
	}


	IEnumerator Late(){
		yield return new WaitForSeconds(1);
		Bird.isKinematic = false;
		ApplyPower();
		Bird.AddForce(transform.right * 10);
		Bird.AddForce(transform.up * 10);
		Camera1.SetActive(false);
		Camera2.SetActive(true);
		//bar.rectTransform.localScale = new Vector3(0, 1, 1)
		Peng.isKinematic = false;
		ApplyPower();
		Peng.AddForce(transform.right * LateForce / 2);
		Peng.AddForce(transform.up * LateForce / 10);
		Camera3.SetActive(false);
		Camera4.SetActive(true);
		//bar.rectTransform.localScale = new Vector3(0, 1, 1); 

	}
}



