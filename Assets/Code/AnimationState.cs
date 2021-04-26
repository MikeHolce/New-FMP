using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationState : MonoBehaviour

{
    static Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isWalking", false);

        //Walk

        if (Input.GetKey("w"))
        {
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp("w"))
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetKey("a"))
        {
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp("a"))
        {
            anim.SetBool("isWalking", false);
        }


        if (Input.GetKey("s"))
        {
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp("s"))
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetKey("d"))
        {
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp("d"))
        {
            anim.SetBool("isWalking", false);
        }
        
        //Attack

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("isAttacking", true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("isAttacking", false);
        }
        
         


    }
}
