using System.Diagnostics;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;
    [SerializeField] private bool isGrounded;
    [SerializeField] private float groundCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float Gravity;

    private Vector3 moveDirection;
    private Vector3 velocity;
    private CharacterController controller;



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

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float moveZ = Input.GetAxis("Virticle");

        moveDirection = new Vector3(0, 0, moveZ);

        if (isGrounded)
        {
            if (moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
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
        }
        else
        {
        }

        controller.Move(moveDirection * Time.deltaTime);

        velocity.y += Gravity * Time.deltaTime;
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

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}