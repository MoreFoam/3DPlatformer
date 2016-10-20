using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    Transform player_tr;
    float rotateSpeed = 3.0f, moveSpeed = 3.0f, gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;

	// Use this for initialization
	void Start () {

        player_tr = GameObject.FindGameObjectWithTag("Player").transform;

	}
	
	// Update is called once per frame
	void Update () {
        

        //Look at player
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player_tr.position - transform.position), rotateSpeed * Time.deltaTime);

        //Move towards player
        transform.position += transform.forward * moveSpeed * Time.deltaTime;



        //Set gravity so AI can't fly :^)
        CharacterController controller = GetComponent<CharacterController>();

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

        

        

	}
}
