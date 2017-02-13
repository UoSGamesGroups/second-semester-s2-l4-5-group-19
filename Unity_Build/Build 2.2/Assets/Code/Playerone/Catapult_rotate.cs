using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult_rotate : MonoBehaviour {

	public float speed = 10.0f;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A))
			transform.Rotate (Vector3.forward * 2);
		if (Input.GetKey (KeyCode.D))
			transform.Rotate (Vector3.forward * -2);
	}
}