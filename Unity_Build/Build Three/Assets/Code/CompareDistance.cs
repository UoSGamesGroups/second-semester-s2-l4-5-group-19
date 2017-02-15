using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
using UnityEngine.UI;

public class CompareDistance : MonoBehaviour {
	BirdDistance p1Distance;
	BirdDistance p2Distance;
	public string winner; 
	public Text CompareDis; 
	// Use this for initialization
	void Start () {

		GameObject playerone = GameObject.Find("Bird");
		p1Distance = playerone.GetComponent<BirdDistance>();
		GameObject playertwo = GameObject.Find("Penguin");
		p2Distance = playertwo.GetComponent<BirdDistance>();
	}



	// Update is called once per frame
	void Update () {
		if(p1Distance.launched == true && p2Distance.launched == true)
		{
			if (p1Distance.PlayerSpeed == 0 && p2Distance.PlayerSpeed == 0)
			{
				if (p1Distance.PlayerX > p2Distance.PlayerX) {
					winner = "Player one Wins!"; 
					CompareDis.text = winner;
				}
				if (p1Distance.PlayerX < p2Distance.PlayerX)
				{
					winner = "Player one Wins!"; 
					CompareDis.text = winner;
				}
				else
				{
					winner = "It's a draw!"; 
					CompareDis.text = winner;
				}
			}
		}
	}
}