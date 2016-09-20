using UnityEngine;
using System.Collections;

public class CoreObjScript : MonoBehaviour {

	private GameObject player;


	// Use this for initialization
	void Start () {

		player = GameObject.Find("Player");
	
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position;
	
	}
}
