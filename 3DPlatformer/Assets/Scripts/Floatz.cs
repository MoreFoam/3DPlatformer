﻿using UnityEngine;
using System.Collections;

public class Floatz : MonoBehaviour {

	// Use this for initialization
	public float amplitude;          //Set in Inspector 
	public float speed;                  //Set in Inspector 
	public float tempVal;
	public Vector3 tempPos;
	void Start () 
	{
		tempVal = transform.position.y;
	}
	void Update ()
	{   
		tempPos = transform.position;
		tempPos.y = tempVal + amplitude * Mathf.Sin (speed * Time.time);
		transform.position = tempPos;
	}
}
