using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationState : MonoBehaviour

{
    static Animator anim;
    public GameObject Collide;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        Collide.SetActive(false);
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

        if (Input.GetMouseButtonDown(0))
        { 
            StartCoroutine(Waiting());
            Character.mouseClicked = true;
            anim.SetBool("isWalking", false);
        }

    }

    IEnumerator Waiting()
    {

        Collide.SetActive(true);
        anim.SetBool("isWalking", false);
        yield return new WaitForSeconds(1);
        Collide.SetActive(false);
        anim.SetBool("isAttacking", false);
        yield return new WaitForSeconds(1);
        StopCoroutine(Waiting());
        Character.mouseClicked = false;
    }
}
