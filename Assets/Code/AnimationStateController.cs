using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {

        // If player presses w
        if (Input.GetKey("w"))
        {
            //Then the isWalking boolean is true
            animator.SetBool("IsWalking", true);
        }
        {
            // If the player is not pressing w
            if (!Input.GetKey("w"))
            {
                //Then the is Walking boolean is false
                animator.SetBool("IsWalking", false);
            }
            if (!Input.GetKey("left shift"))
            {
                animator.SetBool("IsRunning", false);
            }
            if (Input.GetKey("left shift"))
            {
                animator.SetBool("IsRunning", true);
            }
        }
    }
}



