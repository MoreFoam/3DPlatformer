
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

    private Vector3 temp;

    //private Vector3 direction;

    public float distance = 15f;

    public float height = 7.5f;



    void Start ()
    {
        

    }

    void FixedUpdate()
    {
        //Keeps the camera fixed on the object
        transform.LookAt(player.transform.position);
        float speed = 10.0f;

        //Enables the use of the right thumbstick or arrow keys to control the camera position
        transform.RotateAround(player.transform.position, Vector3.up, Input.GetAxis("Horizontal2") * speed);

        //Debug.Log("Offset: " + offset.x.ToString());
        //Debug.Log("XAxis2: " + camHorizontal.ToString());


    }
    
    void LateUpdate ()
    {

        float camY = Input.GetAxis("Vertical2");
        height += camY * 0.05f;
        if (height >= player.transform.position.y + 15.0f){
            height = 15.0f + player.transform.position.y;
        }else if (height <= 7.5f + player.transform.position.y){
            height = 7.5f + player.transform.position.y;
        }

        //To keep a fixed position from the player object
        offset = transform.position - player.transform.position;
        temp = offset.normalized * distance + player.transform.position;
        temp.y = height;
        transform.position = temp;
    }
}