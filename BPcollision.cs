using UnityEngine;
using System.Collections;

public class BPcollision : MonoBehaviour {

    public AudioClip hit;


    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().PlayOneShot(hit);
            
        }
    }
}
