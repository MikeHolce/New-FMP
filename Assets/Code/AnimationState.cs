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
        //starts in idle state

        anim.SetBool("isWalking", false);

        //attack

        if (Input.GetMouseButtonDown(0))
        {
            anim.SetBool("isAttacking", true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            anim.SetBool("isAttacking", false);
        }

        //walk and run

        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey("w")))
        {
            anim.SetBool("isRunning", true);
        }
        else
        
        if(Input.GetKey("w"))
        {
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp("w"))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
        }


        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey("a")))
        {
            anim.SetBool("isRunning", true);
        }
       
        else
        
        if (Input.GetKey("a"))
        {
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp("a"))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
        }


        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey("s")))
        {
            anim.SetBool("isRunning", true);
        }

        else

        if (Input.GetKey("s"))
        {
            anim.SetBool("isWalking", true);
            anim.SetBool("isRunning", false);
        }

        if (Input.GetKeyUp("a"))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
        }


        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey("d")))
        {
            anim.SetBool("isRunning", true);
        }

        else

     if (Input.GetKey("d"))
        {
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp("d"))
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isRunning", false);
        }

    }
}
