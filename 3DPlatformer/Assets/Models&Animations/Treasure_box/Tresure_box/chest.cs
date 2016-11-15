using UnityEngine;
using System.Collections;

public class chest : MonoBehaviour
{
    public AudioClip Jingle;
    private Animator anim;
    private AudioSource ChestopenJingle;
    private float volLowRange = .5f;
    private float volHighRange = 1.0f;

    void Awake()
    {
        anim = GetComponent<Animator>();
        ChestopenJingle = GetComponent<AudioSource>();
    }

    public void chestToggle()
    {
        if (anim)
        {
            if (anim.GetBool("isClosed"))
            {
                anim.SetBool("isClosed", false);
                anim.SetBool("isOpen", true);
                float vol = Random.Range(volLowRange, volHighRange);
                ChestopenJingle.PlayOneShot(Jingle, vol);

            }
            else if (anim.GetBool("isOpen"))
            {
                anim.SetBool("isOpen", false);
                anim.SetBool("isClosed", true);
            }
        }

    }
}
