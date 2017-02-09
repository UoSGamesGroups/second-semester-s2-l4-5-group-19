using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI; 
using UnityEngine.SceneManagement; 

public class Reset_button : MonoBehaviour {

	public Button reset;  







	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnGUI() {
		if (GUILayout.Button("reset")) {
			//SceneManager.LoadScene ("0", LoadSceneMode.Additive);
			Scene loadedLevel = SceneManager.GetActiveScene ();
			SceneManager.LoadScene (loadedLevel.buildIndex);
		}
	}
}
