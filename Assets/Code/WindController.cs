using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class WindController : MonoBehaviour { 

	public float WindAffector;

	public GameObject Windminus3; 

	public GameObject Windminus2; 

	public GameObject Windminus1; 

	public GameObject Wind1; 

	public GameObject Wind2; 

	public GameObject Wind3; 

	public GameObject Windminus3pic_p1; 

	public GameObject Windminus2pic_p1; 

	public GameObject Windminus1pic_p1; 

	public GameObject Wind0pic_p1;

	public GameObject Wind1pic_p1; 

	public GameObject Wind2pic_p1; 

	public GameObject Wind3pic_p1;

	public GameObject Windminus3pic_p2; 

	public GameObject Windminus2pic_p2; 

	public GameObject Windminus1pic_p2; 

	public GameObject Wind0pic_p2;

	public GameObject Wind1pic_p2; 

	public GameObject Wind2pic_p2; 

	public GameObject Wind3pic_p2; 

	private bool WindMax; 

	// Use this for initialization
	void Start () { 
		WindAffector = Random.Range (1, 7);
		Windminus3.SetActive (false); 
		Windminus2.SetActive (false); 
		Windminus1.SetActive (false); 
		Wind1.SetActive (false); 
		Wind2.SetActive (false); 
		Wind3.SetActive (false); 
		Windminus3pic_p1.SetActive (false); 
		Windminus2pic_p1.SetActive (false); 
		Windminus1pic_p1.SetActive (false); 
		Wind0pic_p1.SetActive (false); 
		Wind1pic_p1.SetActive (false); 
		Wind2pic_p1.SetActive (false);
		Wind3pic_p1.SetActive (false); 
		Windminus3pic_p2.SetActive (false); 
		Windminus2pic_p2.SetActive (false); 
		Windminus1pic_p2.SetActive (false); 
		Wind0pic_p2.SetActive (false); 
		Wind1pic_p2.SetActive (false); 
		Wind2pic_p2.SetActive (false);
		Wind3pic_p2.SetActive (false); 
		if (WindAffector == 7) {
			WindMax = true;
		} 
		if (WindAffector == 1) {
			WindMax = false;
		}
	} 

	private void Minusthree (){
		Windminus3.SetActive (true); 
		Windminus2.SetActive (false); 
		Windminus1.SetActive (false); 
		Wind1.SetActive (false); 
		Wind2.SetActive (false); 
		Wind3.SetActive (false); 
		Windminus3pic_p1.SetActive (true); 
		Windminus2pic_p1.SetActive (true); 
		Windminus1pic_p1.SetActive (true); 
		Wind0pic_p1.SetActive (false); 
		Wind1pic_p1.SetActive (false); 
		Wind2pic_p1.SetActive (false);
		Wind3pic_p1.SetActive (false); 
		Windminus3pic_p2.SetActive (true); 
		Windminus2pic_p2.SetActive (true); 
		Windminus1pic_p2.SetActive (true); 
		Wind0pic_p2.SetActive (false); 
		Wind1pic_p2.SetActive (false); 
		Wind2pic_p2.SetActive (false);
		Wind3pic_p2.SetActive (false);
	}

	private void Minustwo (){
		Windminus3.SetActive (false); 
		Windminus2.SetActive (true); 
		Windminus1.SetActive (false); 
		Wind1.SetActive (false); 
		Wind2.SetActive (false); 
		Wind3.SetActive (false); 
		Windminus3pic_p1.SetActive (false); 
		Windminus2pic_p1.SetActive (true); 
		Windminus1pic_p1.SetActive (true); 
		Wind0pic_p1.SetActive (false); 
		Wind1pic_p1.SetActive (false); 
		Wind2pic_p1.SetActive (false);
		Wind3pic_p1.SetActive (false); 
		Windminus3pic_p2.SetActive (false); 
		Windminus2pic_p2.SetActive (true); 
		Windminus1pic_p2.SetActive (true); 
		Wind0pic_p2.SetActive (false); 
		Wind1pic_p2.SetActive (false); 
		Wind2pic_p2.SetActive (false);
		Wind3pic_p2.SetActive (false);
	} 

	private void Minusone (){
		Windminus3.SetActive (false); 
		Windminus2.SetActive (false); 
		Windminus1.SetActive (true); 
		Wind1.SetActive (false); 
		Wind2.SetActive (false); 
		Wind3.SetActive (false); 
		Windminus3pic_p1.SetActive (false); 
		Windminus2pic_p1.SetActive (false); 
		Windminus1pic_p1.SetActive (true); 
		Wind0pic_p1.SetActive (false); 
		Wind1pic_p1.SetActive (false); 
		Wind2pic_p1.SetActive (false);
		Wind3pic_p1.SetActive (false); 
		Windminus3pic_p2.SetActive (false); 
		Windminus2pic_p2.SetActive (false); 
		Windminus1pic_p2.SetActive (true); 
		Wind0pic_p2.SetActive (false); 
		Wind1pic_p2.SetActive (false); 
		Wind2pic_p2.SetActive (false);
		Wind3pic_p2.SetActive (false);
	} 

	private void Zero (){
		Windminus3.SetActive (false); 
		Windminus2.SetActive (false); 
		Windminus1.SetActive (false); 
		Wind1.SetActive (false); 
		Wind2.SetActive (false); 
		Wind3.SetActive (false); 
		Windminus3pic_p1.SetActive (false); 
		Windminus2pic_p1.SetActive (false); 
		Windminus1pic_p1.SetActive (false); 
		Wind0pic_p1.SetActive (true); 
		Wind1pic_p1.SetActive (false); 
		Wind2pic_p1.SetActive (false);
		Wind3pic_p1.SetActive (false); 
		Windminus3pic_p2.SetActive (false); 
		Windminus2pic_p2.SetActive (false); 
		Windminus1pic_p2.SetActive (false); 
		Wind0pic_p2.SetActive (true); 
		Wind1pic_p2.SetActive (false); 
		Wind2pic_p2.SetActive (false);
		Wind3pic_p2.SetActive (false);
	}

	private void One (){
		Windminus3.SetActive (false); 
		Windminus2.SetActive (false); 
		Windminus1.SetActive (false); 
		Wind1.SetActive (true); 
		Wind2.SetActive (false); 
		Wind3.SetActive (false); 
		Windminus3pic_p1.SetActive (false); 
		Windminus2pic_p1.SetActive (false); 
		Windminus1pic_p1.SetActive (false); 
		Wind0pic_p1.SetActive (false); 
		Wind1pic_p1.SetActive (true); 
		Wind2pic_p1.SetActive (false);
		Wind3pic_p1.SetActive (false); 
		Windminus3pic_p2.SetActive (false); 
		Windminus2pic_p2.SetActive (false); 
		Windminus1pic_p2.SetActive (false); 
		Wind0pic_p2.SetActive (false); 
		Wind1pic_p2.SetActive (true); 
		Wind2pic_p2.SetActive (false);
		Wind3pic_p2.SetActive (false);
	}

	private void Two (){
		Windminus3.SetActive (false); 
		Windminus2.SetActive (false); 
		Windminus1.SetActive (false); 
		Wind1.SetActive (false); 
		Wind2.SetActive (true); 
		Wind3.SetActive (false); 
		Windminus3pic_p1.SetActive (false); 
		Windminus2pic_p1.SetActive (false); 
		Windminus1pic_p1.SetActive (false); 
		Wind0pic_p1.SetActive (false); 
		Wind1pic_p1.SetActive (true); 
		Wind2pic_p1.SetActive (true);
		Wind3pic_p1.SetActive (false); 
		Windminus3pic_p2.SetActive (false); 
		Windminus2pic_p2.SetActive (false); 
		Windminus1pic_p2.SetActive (false); 
		Wind0pic_p2.SetActive (false); 
		Wind1pic_p2.SetActive (true); 
		Wind2pic_p2.SetActive (true);
		Wind3pic_p2.SetActive (false);
	} 

	private void Three (){
		Windminus3.SetActive (false); 
		Windminus2.SetActive (false); 
		Windminus1.SetActive (false); 
		Wind1.SetActive (false); 
		Wind2.SetActive (false); 
		Wind3.SetActive (true); 
		Windminus3pic_p1.SetActive (false); 
		Windminus2pic_p1.SetActive (false); 
		Windminus1pic_p1.SetActive (false); 
		Wind0pic_p1.SetActive (false); 
		Wind1pic_p1.SetActive (true); 
		Wind2pic_p1.SetActive (true);
		Wind3pic_p1.SetActive (true); 
		Windminus3pic_p2.SetActive (false); 
		Windminus2pic_p2.SetActive (false); 
		Windminus1pic_p2.SetActive (false); 
		Wind0pic_p2.SetActive (false); 
		Wind1pic_p2.SetActive (true); 
		Wind2pic_p2.SetActive (true);
		Wind3pic_p2.SetActive (true);
	}
	// Update is called once per frame
	void Update () { 
		StartCoroutine (EndofSpeed ());
		if (WindAffector == 1) {
			Minusthree ();
		} 
		if (WindAffector == 2) {
			Minustwo ();
		} 
		if (WindAffector == 3) {
			Minusone (); 
		} 
		if (WindAffector == 4) {
			Zero ();
		} 
		if (WindAffector == 5) {
			One ();
		} 
		if (WindAffector == 6) {
			Two ();
		} 
		if (WindAffector == 7) {
			Three ();
		} 
		if (WindMax == true) { 
			//WindAffector -= 1; 
			StartCoroutine (Reduce ());
		} 
		if (WindAffector == 0) {
			WindMax = false;
		} else if (WindAffector == 0 || WindAffector <= 0) {
			WindMax = false; 
			//WindAffector += 1; 
			StartCoroutine (Increase ());
		}
		if (WindMax == false) { 
			//WindAffector += 1; 
			StartCoroutine (Increase ());
		} 
		if (WindAffector == 7) {
			WindMax = true;
		} else if (WindAffector == 7 || WindAffector >= 7) {
			WindMax = true;  
			//WindAffector -= 1; 
			StartCoroutine (Reduce ());
		}
	} 
	IEnumerator Reduce(){
		yield return new WaitForSeconds(2.5f); 
		WindAffector -= 1;
	} 
	IEnumerator Increase(){
		yield return new WaitForSeconds(2.5f); 
		WindAffector += 1;
	}
	IEnumerator EndofSpeed(){
		yield return new WaitForSeconds(45); 
		Windminus3.SetActive (false); 
		Windminus2.SetActive (false); 
		Windminus1.SetActive (false); 
		Wind1.SetActive (false); 
		Wind2.SetActive (false); 
		Wind3.SetActive (false); 
		Windminus3pic_p1.SetActive (false); 
		Windminus2pic_p1.SetActive (false); 
		Windminus1pic_p1.SetActive (false); 
		Wind0pic_p1.SetActive (true); 
		Wind1pic_p1.SetActive (false); 
		Wind2pic_p1.SetActive (false);
		Wind3pic_p1.SetActive (false); 
		Windminus3pic_p2.SetActive (false); 
		Windminus2pic_p2.SetActive (false); 
		Windminus1pic_p2.SetActive (false); 
		Wind0pic_p2.SetActive (true); 
		Wind1pic_p2.SetActive (false); 
		Wind2pic_p2.SetActive (false);
		Wind3pic_p2.SetActive (false);
	}
}
