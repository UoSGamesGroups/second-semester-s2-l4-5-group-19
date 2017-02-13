using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playertwo_catapult : MonoBehaviour {

	public float speed = 5.0f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (Vector3.forward * 2);
		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate (Vector3.forward * -2);
	}
}