using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour
{
    public Rigidbody projectile;
	public Transform spawn;
    public int destroyTime = 2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
			Debug.Log ("Fireball cast");
            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, spawn.position, projectile.rotation);

            clone.velocity = spawn.TransformDirection(Vector3.forward * 30);
            Destroy(clone.gameObject, destroyTime);
        }
    }
}