using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class GodStrikeStamia : MonoBehaviour {

	public Rigidbody2D Playerone; 

	public Rigidbody2D Playertwo; 

	public float Thrust; 

	public float Thunderstrikes = 3f; 

	private bool CanThunderStrike = false; 

	// Use this for initialization
	void Start () {
		if (Thunderstrikes == 3f) {
			CanThunderStrike = true; 
			Debug.Log ("Can Thunder Strike");
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
