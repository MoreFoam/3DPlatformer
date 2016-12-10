using UnityEngine;
using System.Collections;

public class BarrierScrpt : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	public int hitAmount_Max = 2;
	private int hitAmount_Cur;
	public string enemy = "enemy";
	//private rigidbody Xah;
	//riftGlass = GameObject.FindGameObjectWithTag("enemy");

	void OnTriggerEnter(Collider other) {

		if (other.gameObject.CompareTag (enemy)) {
			hitAmount_Cur++;
		}

		if (hitAmount_Cur >= hitAmount_Max)
		{
			gameObject.SetActive (false);
				// You got hit too many times, it's over
				Debug.Log("Shit, I'm dead");
			//	gameObject.SetActive (false);
				//Destroy(gameObject);
			}

	}
	// Update is called once per frame
	void Update () {
	
	}
}
