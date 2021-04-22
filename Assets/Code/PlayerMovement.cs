using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

public class PlayerMovement : MonoBehaviour
{
    private const string AxisName = "VerticalKey";
    private const string Axisname = "HorizontalKey";

    //VARIABLES
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;

    private Vector3 moveDirection;
    private Vector3 velocity;

    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private bool isGrounded;
    [SerializeField] private float gravity;

    //REFERENCES
    private CharacterController controller;

    private void Start()
    { 
        controller = GetComponent<CharacterController>();  
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);
        if(isGrounded && velocity.y <0)
        {
            velocity.y = -2f;
        }

        float moveZ = Input.GetAxis(AxisName);


        moveDirection = new Vector3(0, 0, moveZ);

        if (isGrounded)
        {
            if (moveDirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
            {
                Walk();
            }
            else if (moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
            {
                Run();
            }
            else if (moveDirection != Vector3.zero)
            {
                Idle();
            }



            moveDirection *= moveSpeed;
        }

        controller.Move(moveDirection * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    private void Idle()
    {

    }

    private void Walk()
    {
        moveSpeed = walkSpeed;
    }

    private void Run()
    {
        moveSpeed = runSpeed;
    }

}