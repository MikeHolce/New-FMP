using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{


    public CharacterController charController;

    public Transform playerSpawn;
    public Transform Player;

    [SerializeField]
    float moveSpeed = 4f; //Change in inspector to adjust move speedVector3 forward, right; // Keeps track of our relative forward and right vectorsvoid Start()
    Vector3 forward, right;
    

    public static bool transformPlayer;
    public GameObject Collide;


    // Player Health
    // call data script
    static public float playerHealth;
    public float healthCheck;

    public bool mouseClicked;

    // Start is called before the first frame update
    void Start()
    {

        CharacterController charController = gameObject.GetComponent<CharacterController>();


        //transformPlayer = true;



        Collide.SetActive(false);

        forward = Camera.main.transform.forward; // Set forward to equal the camera's forward vector
        forward.y = 0; // make sure y is 0
        forward = Vector3.Normalize(forward); // make sure the length of vector is set to a max of 1.0
        right = Quaternion.Euler(new Vector3(0, 90, 0)) * forward; // set the right-facing vector to be facing right relative to the camera's forward vector

        playerHealth = 2;
    }


    // Update is called once per frame
    void Update()
    {

        if (Destroyer.spawnPlayer == true)
        {

            Player.position = new Vector3(5, 0, 5);


            Destroyer.spawnPlayer = false;
        }




        healthCheck = playerHealth;


        if (playerHealth <= 1)
        {
            Debug.Log("player died");
        }

        if (Input.anyKey)
        {
            Move();
        }




        if (Input.GetMouseButtonDown(0) && mouseClicked == false)
        {
            StartCoroutine(Waiting());
            mouseClicked = true;
        }


    }


    void Move()
    {
        Vector3 direction = new Vector3(Input.GetAxis("HorizontalKey"), 0, Input.GetAxis("VerticalKey")); // setup a direction Vector based on keyboard input. GetAxis returns a value between -1.0 and 1.0. If the A key is pressed, GetAxis(HorizontalKey) will return -1.0. If D is pressed, it will return 1.0
        Vector3 rightMovement = right * moveSpeed * Time.deltaTime * Input.GetAxis("HorizontalKey"); // Our right movement is based on the right vector, movement speed, and our GetAxis command. We multiply by Time.deltaTime to make the movement smooth.
        Vector3 upMovement = forward * moveSpeed * Time.deltaTime * Input.GetAxis("VerticalKey"); // Up movement uses the forward vector, movement speed, and the vertical axis inputs.Vector3 heading = Vector3.Normalize(rightMovement + upMovement); // This creates our new direction. By combining our right and forward movements and normalizing them, we create a new vector that points in the appropriate direction with a length no greater than 1.0transform.forward = heading; // Sets forward direction of our game object to whatever direction we're moving in
        transform.position += rightMovement; // move our transform's position right/left
        transform.position += upMovement; // Move our transform's position up/down
        {
            Vector3 heading = Vector3.Normalize(rightMovement + upMovement); // This creates our new direction. By combining our right and forward movements and normalizing them, we create a new vector that points in the appropriate direction with a length no greater than 1.0transform.forward = heading; // Sets forward direction of our game object to whatever direction we're moving intransform.position += rightMovement; // move our transform's position right/left     transform.position += upMovement; // Move our transform's position up/down
        }
    }

    IEnumerator Waiting()
    {

        Collide.SetActive(true);
        yield return new WaitForSeconds(1);
        Collide.SetActive(false);
        yield return new WaitForSeconds(1);
        StopCoroutine(Waiting());
        mouseClicked = false;
    }
}
