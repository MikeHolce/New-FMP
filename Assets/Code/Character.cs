using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public bool liftMouse;
    public bool punchAnim;

    public AudioSource punch;

    public CharacterController charController;

    //public Transform playerSpawn;
    public Transform Player;

    float moveSpeed = 4f; //Change in inspector to adjust move speedVector3 forward, right; // Keeps track of our relative forward and right vectorsvoid Start()

    

    public static bool transformPlayer;
    public GameObject attackArea;


    // Player Health
    // call data script
    static public float playerHealth;
    public float healthCheck;

    static public bool mouseClicked;
    public bool canClick;

    // Start is called before the first frame update
    void Start()
    {
        attackArea.SetActive(false);
        //CharacterController charController = gameObject.GetComponent<CharacterController>();

        punch = GetComponent<AudioSource>();
        //transformPlayer = true;

        playerHealth = 2;

        liftMouse = false;
    }


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("HorizontalKey");
        float vertical = Input.GetAxisRaw("VerticalKey");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            charController.Move(direction * moveSpeed * Time.deltaTime);
        }

        if (pickupCanvas.spawnPlayer == true)
        {
            Debug.Log("spawn the player");
            Player.position = new Vector3(5, 0, 5);
            pickupCanvas.spawnPlayer = false;
        }


        healthCheck = playerHealth;


        if (playerHealth <= 1)
        {
            Debug.Log("player died");
        }

        /**
        if (Input.anyKey)
        {
            Move();
        }
        **/

        if(punchAnim == true)
        {
            punch.Play();
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (canClick == true)
            {
                liftMouse = false;
                canClick = false;
                punchAnim = true;
                
                StartCoroutine(killTime());
            }
        }


        if (Input.GetMouseButtonUp(0))
        {
            if(liftMouse == true)
            {
                canClick = true;
            }           
        }


    }

    /**
    IEnumerator Waiting()
    {
        if(canClick == true)
        {
            mouseClicked = false;
            yield return new WaitForSeconds(3);
            canClick = true;
            StopCoroutine(Waiting());
        }
    }
    **/

    IEnumerator killTime()
    {       
        attackArea.SetActive(true);
        yield return new WaitForSeconds(1);
        attackArea.SetActive(false);
        canClick = true;
        liftMouse = true;
        StopCoroutine(killTime());
    }





    /**
    void Move()
    {

    }
    **/


}
