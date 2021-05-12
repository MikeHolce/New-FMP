using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public GameObject cap1;
    public GameObject cap2;
    public GameObject cap3;
    public GameObject cap4;
    public GameObject cap5;

    public GameObject blue1;
    public GameObject blue2;
    public GameObject blue3;
    public GameObject blue4;
    public GameObject blue5;


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

    static public bool move;


    // Start is called before the first frame update
    void Start()
    {
        move = true;
        cap1.SetActive(false);
        cap2.SetActive(false);
        cap3.SetActive(false);
        cap4.SetActive(false);
        cap5.SetActive(false);

        blue1.SetActive(true);
        blue2.SetActive(true);
        blue3.SetActive(true);
        blue4.SetActive(true);
        blue5.SetActive(true);

        attackArea.SetActive(false);
        //CharacterController charController = gameObject.GetComponent<CharacterController>();

        punch = GetComponent<AudioSource>();
        //transformPlayer = true;

        playerHealth = 2;

        liftMouse = false;
        canClick = true;

        punchAnim = false;
    }


    // Update is called once per frame
    void Update()
    {
        if(move == true)
        {
            float horizontal = Input.GetAxisRaw("HorizontalKey");
            float vertical = Input.GetAxisRaw("VerticalKey");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                charController.Move(direction * moveSpeed * Time.deltaTime);
            }

            if (canClick == true)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    mouseClicked = true;
                    Debug.Log("canClik");
                    liftMouse = false;
                    canClick = false;
                    StartCoroutine(killTime());
                }
            }
            if (Input.GetMouseButtonUp(0))
            {
                if (liftMouse == true)
                {
                    canClick = true;
                }
            }

            if (punchAnim == true)
            {
                punch.Play();
                punchAnim = false;
            }
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
        cap1.SetActive(false);
        cap2.SetActive(false);
        cap3.SetActive(false);
        cap4.SetActive(false);
        cap5.SetActive(false);

        blue1.SetActive(false);
        blue2.SetActive(false);
        blue3.SetActive(false);
        blue4.SetActive(false);
        blue5.SetActive(false);

        attackArea.SetActive(true);
        punchAnim = true;
        yield return new WaitForSeconds(0.2f);
        attackArea.SetActive(false);
        yield return new WaitForSeconds(0.2f);
        //1
        cap1.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        //2
        cap2.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        //3
        cap3.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        //4
        cap4.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        //5
        cap5.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        cap1.SetActive(false);
        cap2.SetActive(false);
        cap3.SetActive(false);
        cap4.SetActive(false);
        cap5.SetActive(false);

        blue1.SetActive(true);
        blue2.SetActive(true);
        blue3.SetActive(true);
        blue4.SetActive(true);
        blue5.SetActive(true);





        canClick = true;
        liftMouse = true;
        mouseClicked = false;
        StopCoroutine(killTime());
    }





    /**
    void Move()
    {

    }
    **/


}
