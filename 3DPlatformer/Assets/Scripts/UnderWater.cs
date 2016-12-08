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
		if (Col.CompareTag("Camera1"))
		{
			Debug.Log ("Water Entered");
			GameObject.Find ("Underwater Effect").GetComponent<MeshRenderer>().enabled=true;
		}
	}

	void OnTriggerExit(Collider Col)
	{
		if (Col.CompareTag("Camera1"))
		{
			Debug.Log ("Water Left");
			GameObject.Find ("Underwater Effect").GetComponent<MeshRenderer>().enabled=false;
		}
	}
}
