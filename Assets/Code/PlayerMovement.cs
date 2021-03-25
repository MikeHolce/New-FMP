using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //VARIABLES
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;

    private Vector3 moveDirection;
    private Vector3 velocity;

    //REFERENCES
    private CharacterController controller;

    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float Gravity;

    private void start()
    {
        controller = GetComponent<CharacterController>(); 

    }

    private void update()
    {
        Move();
    }

    private void Move()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);

        float moveZ = Input.GetAxis("Virticle");

        moveDirection = new Vector3(0, 0, moveZ);
       
        if(moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
        {
            Walk();

        }
        else if (moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
        {
            Run();
        }
        else if (moveDirection == Vector3.zero)
        {
            Idle();
        }

        moveDirection *= moveSpeed;
        controller.Move(moveDirection * Time.deltaTime);
    }

    private void Idle()
    {

    }
    private void Walk()
    {
        moveSpeed == walkSpeed;
    }
    private void Run()
    {
        moveSpeed == runSpeed;
    }
}
