using UnityEngine;
using System.Collections;

public class Player_Animation : MonoBehaviour {

    private Animator anim;
    private int c = 0;

    void Awake() {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
            anim.Play("Player_Walk");
        else
            anim.Play("Idle");
    }
}
