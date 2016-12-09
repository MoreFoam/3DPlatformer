using UnityEngine;
using System.Collections;

public class BossProjectile : MonoBehaviour {

    public Rigidbody projectile;
    public Transform spawn;
    public int destroyTime = 3;
    private float timer = 3f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {

            Rigidbody clone;
            clone = (Rigidbody)Instantiate(projectile, spawn.position, projectile.rotation);

            clone.velocity = spawn.TransformDirection(Vector3.forward * 30);
            Destroy(clone.gameObject, destroyTime);
            timer = 3f;
        }
    }
}
