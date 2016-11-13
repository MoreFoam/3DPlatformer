using UnityEngine;
using System.Collections;

public class UnderWater : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider Col)
	{
		//Make sure the player object has its tag set to Player
		if (Col.CompareTag("Camera1"))
		{
			GameObject.Find ("Underwater Effect").GetComponent<MeshRenderer>().enabled=true;
		}
	}

	void OnTriggerExit(Collider Col)
	{
		//Make sure the player object has its tag set to Player
		Debug.Log(Col.tag);
		if (Col.CompareTag("Camera1"))
		{
			GameObject.Find ("Underwater Effect").GetComponent<MeshRenderer>().enabled=false;
		}
	}
}
