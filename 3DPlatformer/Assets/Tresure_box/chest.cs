using UnityEngine;
using System.Collections;

public class chest : MonoBehaviour
{
    Animator anim;
   public void chestToggle()
    {
        print("We did it!");
        anim = GetComponent<Animator>();
        if(anim.GetBool("isClosed"))
        {
            anim.SetBool("isClosed", false);
            anim.SetBool("isOpen", true);
        }
        else if (anim.GetBool("isOpen"))
        {
            anim.SetBool("isOpen", false);
            anim.SetBool("isClosed", true);
        }

    }
}
