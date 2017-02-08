using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_shadow : MonoBehaviour {

	public GameObject bird;      


	private Vector3 offset;        

	// Use this for initialization
	void Start () 
	{
		
		offset = transform.position - bird.transform.position;
	}


	void LateUpdate () 
	{
		
		transform.position = bird.transform.position + offset;
	}
}
