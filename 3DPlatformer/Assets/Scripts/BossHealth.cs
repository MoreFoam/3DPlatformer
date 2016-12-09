using UnityEngine;
using System.Collections;

public class BossHealth : MonoBehaviour {

    public int life = 0;
    public AudioClip hit;
    

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "fireball")
        {
            GetComponent<AudioSource>().PlayOneShot(hit);
            life += 1;
            
            if (life == 10)
            {
                Destroy(gameObject);
                
            }
            

        }
    }
}
