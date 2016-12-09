using UnityEngine;
using System.Collections;

public class ProjectileCollision : MonoBehaviour {

    public AudioClip hit;
    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            GetComponent<AudioSource>().PlayOneShot(hit);
            Destroy(col.gameObject);
        }
    }
}
