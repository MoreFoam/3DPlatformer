using UnityEngine;
using System.Collections;
//using UnityEngine.SceneManagement;

public class HubLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider Col)
	{
		//Make sure the player object has its tag set to Player
		if (Col.CompareTag("Player"))
		{
			Application.LoadLevel("Level 1");
		}
	}
}
