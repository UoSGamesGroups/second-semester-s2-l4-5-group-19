using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class God_stamina : MonoBehaviour { 

	public Rigidbody2D Playerone; 

	public Rigidbody2D Playertwo;  

	public Rigidbody2D Thunderprefab; 

	public Transform SpawnLocation; 

	public Transform SpawnRotation;

	public float Thrust; 

	public float Thunderstrikes = 3f; 

	private bool Thunderstrike = false;



	// Use this for initialization
	void Start () {
		if (Thunderstrikes <= 3f) {
			Thunderstrike = true; 
			Debug.Log ("Can Thunder Strike");
		} 
		if (Thunderstrikes == 0f) {
			Thunderstrike = false; 
			Debug.Log ("Out of Thunder");
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Z)) { 
			Rigidbody2D thunderClone = (Rigidbody2D)Instantiate (Thunderprefab, SpawnLocation.position, SpawnRotation.rotation);
			//Rigidbody thunderInstance; 
			//thunderInstance = Instantiate (Thunderprefab, SpawnLocation.position) as Rigidbody;
			Playerone.AddForce (transform.right * Thrust);
			Playerone.AddForce (transform.up * Thrust/20);
			Thunderstrikes -= 1f; 
			Debug.Log ("Used Thunder"); 
		}
	}
}
