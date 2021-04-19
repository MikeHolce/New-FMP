using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{ 
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        if (GetAxis("HorizontalKey"))
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
        }
        else
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);
        }

        if (GetAxis("VerticalKey"))
        {
            animator.SetBool("isWalking", true);
            animator.SetBool("isIdle", false);
        }
        else
        {
            animator.SetBool("isWalking", false);
            animator.SetBool("isIdle", true);
        }

    }

    private bool GetKey(string v)
    {
        throw new NotImplementedException();
    }

    private bool GetAxis(string v)
    {
        throw new NotImplementedException();
    }
}



