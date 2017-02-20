using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playertwo_catapult : MonoBehaviour {



	public float speed = 5.0f;
	public BirdDistance p2Distance;
	// Use this for initialization
	void Start () {
		;
	}

	// Update is called once per frame
	void Update()
	{
		bool getLaunch = p2Distance.GetComponent<BirdDistance>().launched;
		if (Input.GetKey(KeyCode.LeftArrow) && getLaunch == false)
		{
			transform.Rotate(Vector3.forward * 2);
		}

		if (Input.GetKey(KeyCode.RightArrow) && getLaunch == false)
		{
			transform.Rotate(Vector3.forward * -2);
		}
	}
}