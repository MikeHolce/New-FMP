using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 4;


    //gravity
    private float verticalSpeed = 0;
    private float gravity = 9.87f;

    // Update is called once per frame
    void Update()
    {
        if (PauseMenuScript.paused == false)
        {
            Move();
        }
    }

    private void Move()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 gravityMove = new Vector3(0, verticalSpeed, 0);
        Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove;

    }
}