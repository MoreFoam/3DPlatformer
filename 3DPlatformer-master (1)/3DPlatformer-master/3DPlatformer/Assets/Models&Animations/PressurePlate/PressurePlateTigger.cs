using UnityEngine;
using System.Collections;

public class PressurePlateTigger : MonoBehaviour
{
    private AudioSource PressureClick;
    public AudioClip ClickSound;
    public GameObject Plate;
    public GameObject PlateTarget;
    private float volHighRange = 1.0f;
    Animator anim;
    void Awake()
    {
        anim = Plate.GetComponent<Animator>();
        PressureClick = GetComponent<AudioSource>();
    }
    void OnTriggerEnter (Collider other)
    {
        pressurePlateActivate();
        Debug.Log("Entered");
    }
    public void pressurePlateActivate()
    {
        anim = Plate.GetComponent<Animator>();
        if (!anim.GetBool("IsPressed"))
        {
            anim.SetBool("IsPressed", true);
            PressureClick.PlayOneShot(ClickSound, volHighRange);
        }
        if(PlateTarget)
        {
            anim = PlateTarget.GetComponent<Animator>();
            if (!anim.GetBool("IsTriggered"))
            {
                anim.SetBool("IsTriggered", true);
            }
        }

    }
}