﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catapult_rotate : MonoBehaviour {


	public float speed = 10.0f;
	public BirdDistance p1Distance;
	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update()
	{

		bool getLaunch = p1Distance.GetComponent<BirdDistance>().launched;
		if (Input.GetKey(KeyCode.A) && getLaunch == false)
		{
			transform.Rotate(Vector3.forward * 2);
		}

		if (Input.GetKey(KeyCode.D) && getLaunch == false)
		{
			transform.Rotate(Vector3.forward * -2);
		}
	}
}