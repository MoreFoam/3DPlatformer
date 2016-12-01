using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour {

    public int life = 0;
    public AudioClip hit;

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "fireball")
        {
            life += 1;
            GetComponent<AudioSource>().PlayOneShot(hit);
            if(life == 10)
                Destroy(gameObject);

        }
    }
}
