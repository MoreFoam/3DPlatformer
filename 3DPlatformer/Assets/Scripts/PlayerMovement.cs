﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed = 3.0F;
	public float rotateSpeed = 3.0F;
	public float jumpSpeed = 3.0f;

	private Camera cam1;


	// Use this for initialization
	void Start () {
		cam1 = GameObject.FindWithTag("Camera1").GetComponent<Camera>();
	
	}
	
	


	void Update() {
		CharacterController controller = GetComponent<CharacterController>();

		float speed2 = speed * Input.GetAxis("Horizontal");
		float moveHorizontal = Input.GetAxisRaw ("Horizontal");
        float moveVertical = Input.GetAxisRaw ("Vertical");


		//transform.Rotate(0, Input.GetAxis("Horizontal") * rotateSpeed, 0);

		
		Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

		Vector3 strafe = cam1.transform.TransformDirection(Vector3.right);
		controller.SimpleMove(strafe * speed2);


		Vector3 forward = cam1.transform.TransformDirection(Vector3.forward);

		float curSpeed = speed * Input.GetAxis("Vertical");
		controller.SimpleMove(forward * curSpeed);

		if (Input.GetButtonDown("Jump")){
			transform.position += transform.up * jumpSpeed * Time.deltaTime;
		}

		//transform.rotation = Quaternion.LookRotation(movement, Vector3.up);

	}
}
