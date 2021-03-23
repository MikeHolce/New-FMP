using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour

{
    private Transform Player;
    private float dist;
    public float moveSpeed;
    public float howclose;

    //attack loop
    public float loopCounter;


    public bool canAttack;



    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("player").transform;

        canAttack = false;



    }

    // Update is called once per frame
    void Update()
    {

        loopCounter += 0.1f;

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




        if(canAttack == true)
        {
            if (loopCounter >= 25)
            {
                Character.playerHealth -= 1;
                Debug.Log("damage");
                loopCounter = 0;
            }
        }




    }


}