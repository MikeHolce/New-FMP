using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour

{

    //colour changeing


    public Material Regular;
    public Material Charge;
    public Material Attack;


    public bool regBool;
    public bool chargeBool;
    public bool attackBool;

    public GameObject[] changeable;



    //movement

    public Transform Player;
    private float dist;
    public float moveSpeed;
    public float howclose;


    /**
    private Vector3 Movement;
    private Rigidbody rb;
    public float moveSpeed = 8f;
    **/



    //attack loop
    public float loopCounter;

    public bool canAttack;

    public float redCounter;



    // Start is called before the first frame update
    void Start()
    {

        //howclose = 8;
        //dist = 8;


        changeable = GameObject.FindGameObjectsWithTag("Change");


        Player = GameObject.FindGameObjectWithTag("player").transform;

        

        canAttack = false;






    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(Player.position, transform.position);
        if (dist <= howclose)
        {
            transform.LookAt(Player);
            GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed * Time.deltaTime);
        }


        if (dist <= 2)  //sees player is true
        {
            canAttack = true;
            Debug.Log("can attack");
        }
        else
        {
            canAttack = false;
        }
   




        /**

        Vector3 direction = Player.position - transform.position;
        //transform.LookAt(Player);
        float angle = Mathf.Atan2(direction.z, direction.x) * Mathf.Rad2Deg - 90f;
        direction.Normalize();
        Movement = direction;#
    **/



        if (canAttack == true)
        {
            regBool = false;
            chargeBool = true;
            loopCounter += 0.1f * Time.deltaTime;
            //redCounter += 0.1f * Time.deltaTime;
            if (loopCounter >= 0.5)             // counter goes up when it gets to 10 it does 1 damage to the player before u have to wait till recieving more damage
            {
                //chargeBool = false;
                //attackBool = true;
                Character.playerHealth -= 1;
                Debug.Log("damage");
                loopCounter = 0;

            }
            if (redCounter >= 0.6)
            {
                Debug.Log("change red");
                attackBool = false;
                regBool = true;
                redCounter = 0;
            }
        }

        if(canAttack == false)
        {
            regBool = true;
            loopCounter = 0;
        }






        //anticipation


        if(chargeBool == true)
        {
            for (int i = 0; i < changeable.Length; i++)
            {
                changeable[i].GetComponent<MeshRenderer>().material = Charge;
            }
        }
        if (attackBool == true)
        {
            for (int i = 0; i < changeable.Length; i++)
            {
                changeable[i].GetComponent<MeshRenderer>().material = Attack;
            }
        }
        if (regBool == true)
        {
            for (int i = 0; i < changeable.Length; i++)
            {
                changeable[i].GetComponent<MeshRenderer>().material = Regular;
            }
        }


    }


    // changed version of move
    /**
    private void FixedUpdate()
    {
        moveEnemy(Movement);
    }

    void moveEnemy(Vector3 direction)
    {
        rb.MovePosition(transform.position + (direction * moveSpeed * Time.deltaTime));
    }
    **/
}