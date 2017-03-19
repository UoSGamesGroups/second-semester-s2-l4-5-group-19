using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina_p2 : MonoBehaviour {


	public Rigidbody2D Playertwo; 

	//public Rigidbody2D Playertwo;  

	public Rigidbody2D Thunderprefab; 

	public Transform SpawnLocation; 

	public Transform SpawnRotation;

	public float Thrust; 

	public float Thunderstrikes;

	public GameObject ThunderBG; 

	public GameObject Particles;

	private bool Canthunderstrike;



	// Use this for initialization
	void Start () {
		if (Thunderstrikes == 3f) {
			Canthunderstrike = true; 
			Debug.Log ("Can Thunder Strike");
		} 
		if (Thunderstrikes == 0f ||Thunderstrikes <= 0f) { 
			Canthunderstrike = false; 
			Debug.Log ("Out of Thunder");
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.DownArrow)) {  
			if ( Thunderstrikes == 3){
				Rigidbody2D thunderClone = (Rigidbody2D)Instantiate (Thunderprefab, SpawnLocation.position, SpawnRotation.rotation);
				//Rigidbody thunderInstance; 
				//thunderInstance = Instantiate (Thunderprefab, SpawnLocation.position) as Rigidbody;
				ThunderBG.SetActive (true); 
				StartCoroutine (EndofBG ());
				Playertwo.AddForce (transform.right * Thrust);
				Playertwo.AddForce (transform.up * Thrust/20);
				Thunderstrikes -= 1f; 
				Particles.SetActive (true); 
				StartCoroutine (EndofP ());
				Debug.Log ("Used Thunder"); 
			}  
			else if ( Thunderstrikes == 2){
				Rigidbody2D thunderClone = (Rigidbody2D)Instantiate (Thunderprefab, SpawnLocation.position, SpawnRotation.rotation);
				//Rigidbody thunderInstance; 
				//thunderInstance = Instantiate (Thunderprefab, SpawnLocation.position) as Rigidbody;
				ThunderBG.SetActive (true); 
				StartCoroutine (EndofBG ());
				Playertwo.AddForce (transform.right * Thrust);
				Playertwo.AddForce (transform.up * Thrust/20);
				Thunderstrikes -= 1f; 
				Particles.SetActive (true); 
				StartCoroutine (EndofP ());
				Debug.Log ("Used Thunder"); 
			}  
			else if ( Thunderstrikes == 1){
				Rigidbody2D thunderClone = (Rigidbody2D)Instantiate (Thunderprefab, SpawnLocation.position, SpawnRotation.rotation);
				//Rigidbody thunderInstance; 
				//thunderInstance = Instantiate (Thunderprefab, SpawnLocation.position) as Rigidbody;
				ThunderBG.SetActive (true); 
				StartCoroutine (EndofBG ());
				Playertwo.AddForce (transform.right * Thrust);
				Playertwo.AddForce (transform.up * Thrust/20);
				Thunderstrikes -= 1f; 
				Particles.SetActive (true); 
				StartCoroutine (EndofP ());
				Debug.Log ("Used Thunder"); 
			}  
			else if ( Thunderstrikes == 0){
				Debug.Log ("Out of Stamina"); 
			} 
		}    

	} 
	IEnumerator EndofBG(){
		yield return new WaitForSeconds (0.3f); 
		ThunderBG.SetActive (false); 
	} 
	IEnumerator EndofP(){
		yield return new WaitForSeconds (0.4f); 
		Particles.SetActive (false);
	}
}

