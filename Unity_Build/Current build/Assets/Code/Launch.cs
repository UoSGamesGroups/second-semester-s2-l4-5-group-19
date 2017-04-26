using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour { 
	public Rigidbody2D Imps; 

	public GameObject Camera1; 

	public GameObject Camera2; 

	public GameObject Camera3; 

	public GameObject Camera4; 

	public 

	// Use this for initialization
	void Start () { 
		Imps.isKinematic = true;
		StartCoroutine (Late()); 
		Camera1.SetActive(true); 
		Camera2.SetActive(true); 
		Camera3.SetActive(false); 
		Camera4.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	} 
	IEnumerator Late(){
		yield return new WaitForSeconds(3);  
		Imps.isKinematic = false;
		Imps.AddForce(transform.right * 1000); 
		Imps.AddForce(transform.up * 50); 
		Camera1.SetActive(false); 
		Camera2.SetActive(false); 
		Camera3.SetActive(true); 
		Camera4.SetActive(true);
	}
}
