using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	

	private Camera cam1;

    public float speed = 10.0F;
    public float jumpSpeed = 10.0F;
    public float gravity = 20.0F;
	private Vector3 slideDirection = Vector3.zero;
    private Vector3 moveDirection = Vector3.zero;


    // Use this for initialization
    void Start () {
		cam1 = GameObject.FindWithTag("Camera1").GetComponent<Camera>();
	
	}
	
	


	void Update() {
		

        CharacterController controller = GetComponent<CharacterController>();

		if (slideDirection == Vector3.zero) {
			if (controller.isGrounded && controller.isGrounded) {
				moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));

				moveDirection = transform.TransformDirection (moveDirection);

				moveDirection *= speed;

				if (Input.GetButton ("Jump"))
					moveDirection.y = jumpSpeed;

			}

			moveDirection.y -= gravity * Time.deltaTime;

			controller.Move (moveDirection * Time.deltaTime);
		} else {
			moveDirection = gravity * Time.deltaTime * slideDirection;
			moveDirection.y -= gravity * Time.deltaTime*10;

			controller.Move (moveDirection * Time.deltaTime);
		}
    }

	void OnControllerColliderHit(ControllerColliderHit hit) {
		Debug.Log (hit.normal.y);
		if (hit.normal.y < .7 && hit.normal.y>.001) {
			slideDirection = hit.normal;
		}
		else
			slideDirection = Vector3.zero;
	}

	void OnTriggerEnter (Collider other)
	{
		//Destroy (other.gameObject);

		//De-activate other object
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			other.gameObject.SetActive (false);
		}
	}
}
