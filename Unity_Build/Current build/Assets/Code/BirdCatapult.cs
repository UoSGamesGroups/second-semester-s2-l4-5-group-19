using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdCatapult : MonoBehaviour {

	public Rigidbody2D rb; 

	public float releaseTime = .15f; 

	public GameObject Camera1; 

	public GameObject Camera2;

	private bool isPressed = false; 

	void Update ()
	{ 
		if (isPressed) 
		{  
			Camera2.SetActive (false);
			rb.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	} 
	}


	void OnMouseDown () 
	{
		isPressed = true; 
		rb.isKinematic = true; 
	} 

	void OnMouseUp ()
	{ 
		isPressed = false; 
		rb.isKinematic = false; 

		StartCoroutine(Release ());
	} 

	IEnumerator Release ()
	{
		yield return new WaitForSeconds (releaseTime);

		GetComponent<SpringJoint2D> ().enabled = false; 
		Camera1.SetActive(false);
		Camera2.SetActive (true);
	}
}
