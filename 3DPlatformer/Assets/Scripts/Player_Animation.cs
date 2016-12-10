using UnityEngine;
using System.Collections;

public class Player_Animation : MonoBehaviour {

    private Animation anim;
    private int c = 0;

    void Awake() {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
            anim.Play("Player_Walk");
        else
            anim.Stop();
    }
}
