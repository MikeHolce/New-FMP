using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{


    public CharacterController charController;

    //public Transform playerSpawn;
    public Transform Player;

    float moveSpeed = 4f; //Change in inspector to adjust move speedVector3 forward, right; // Keeps track of our relative forward and right vectorsvoid Start()

    

    public static bool transformPlayer;



    // Player Health
    // call data script
    static public float playerHealth;
    public float healthCheck;

    static public bool mouseClicked;

    // Start is called before the first frame update
    void Start()
    {

        //CharacterController charController = gameObject.GetComponent<CharacterController>();


        //transformPlayer = true;

        playerHealth = 2;
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

        if (Input.GetMouseButtonDown(0) && mouseClicked == false)
        {
            mouseClicked = true;
        }


    }

    /**
    void Move()
    {

    }
    **/


}
