using UnityEngine;
using System.Collections;

public class CollisionTester : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnCollisionEnter(Collision Col)
	{
		if (Col.gameObject.tag == "Player");
		Debug.Log("YO GET YO HANDS OFF ME FAM!");
	}
}
