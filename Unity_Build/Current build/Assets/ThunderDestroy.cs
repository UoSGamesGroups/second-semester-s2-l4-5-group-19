using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderDestroy : MonoBehaviour { 

	public GameObject thunder; 



	// Use this for initialization
	void Start () {
		StartCoroutine (ThunderDestory ());
	}
	
	// Update is called once per frame
	void Update () {
		
	} 

	IEnumerator ThunderDestory(){
		yield return new WaitForSeconds (1); 
		Destroy(thunder); 

	}
}
