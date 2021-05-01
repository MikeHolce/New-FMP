using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour

{
    /**
    //colour changeing
    public Material Regular;
    public Material Charge;
    public Material Attack;
    public bool regBool;
    public bool chargeBool;
    public bool attackBool;
    public GameObject[] changeable;
    **/
    public Transform Checkpoint1;
    public Transform Checkpoint2;

    public int rand;

    public bool lookPlayer;
    public bool lookCheck1;
    public bool lookCheck2;

    //movement
    public Transform Player;
    public Transform Enemy;

    private float dist;
    public float moveSpeed;
    public float howclose;


    public bool startAttack1;
    public bool startAttack2;

    public GameObject beam;
    public GameObject beamCollide;

    public bool shoot;
    public bool move; // true = 2 false = 1


    public float step;

    public int stopRepeat;

    //public Transform currentCheckpoint;


    // Start is called before the first frame update
    void Start()
    {
        startAttack1 = false;
        startAttack2 = false;

        beam.SetActive(false);
        beamCollide.SetActive(false);

        Player = GameObject.FindGameObjectWithTag("player").transform;
        Checkpoint1 = GameObject.FindGameObjectWithTag("Check1").transform;
        Checkpoint2 = GameObject.FindGameObjectWithTag("Check2").transform;


        //walk about
        moveSpeed = 5;
        step = moveSpeed * Time.deltaTime; // calculate distance to move

        move = true;

    }

    // Update is called once per frame
    void Update()
    {


        if (lookPlayer == true)
        {
            transform.LookAt(Player);
        }

        if (lookCheck1 == true)
        {
            transform.LookAt(Checkpoint1);
        }

        if (lookCheck2 == true)
        {
            transform.LookAt(Checkpoint2);
        }

        //Input.GetKeyDown("space")
        if (startAttack1 == true)
        {
            stopRepeat = 1;
            //rand = Random.Range(0, Checkpoints.Length);
            //bhInstantiate(Checkpoints[rand], transform.position, Quaternion.identity);
            if (stopRepeat == 1)
            {
                stopRepeat = 0;
                StartCoroutine(Attack1());
;
            }
        }

        if (startAttack2 == true)
        {
            stopRepeat = 1;
            if(stopRepeat == 1)
            {
                stopRepeat = 0;
                StartCoroutine(Attack2());

            }

        }

        if (move == true) // move2
        {
            //currentCheckpoint = Checkpoint2;
            lookCheck2 = true;
            transform.position = Vector3.MoveTowards(transform.position, Checkpoint2.position, step);
            if (Enemy.position == Checkpoint2.position)
            {
                lookCheck2 = false;
                startAttack2 = true;
            }
        }

        if (move == false ) // move1
        {
            //currentCheckpoint = Checkpoint1;
            lookCheck1 = true;
            transform.position = Vector3.MoveTowards(transform.position, Checkpoint1.position, step);
            if (Enemy.position == Checkpoint1.position)
            {
                lookCheck1 = false;
                startAttack1 = true;
            }
        }
        
    }


    IEnumerator Attack1()
    {
        startAttack1 = false;
        //Enemy.position = currentCheckpoint.position;;
        Debug.Log("looking at player");
        lookPlayer = true;
        Debug.Log("attacking player");
        //attack player
        beam.SetActive(true); // false to hide, true to show
        beamCollide.SetActive(true);
        yield return new WaitForSeconds(1);
        beam.SetActive(false);
        beamCollide.SetActive(false);
        lookPlayer = false;
        move = true;
        StopCoroutine(Attack1());
    }

    IEnumerator Attack2()
    {
        startAttack2 = false;
        //Enemy.position = currentCheckpoint.position;;
        Debug.Log("looking at player");
        lookPlayer = true;

        //attack player
        beam.SetActive(true); // false to hide, true to show
        beamCollide.SetActive(true);

        yield return new WaitForSeconds(1);
        beam.SetActive(false);
        beamCollide.SetActive(false);
        lookPlayer = false;
        move = false;
        StopCoroutine(Attack2());
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "attackZone")
        {
            Debug.Log("dead aliens");
            Destroy(this.gameObject);
            SpawningEnemy.Kills += 1;
        }
    }



    /**
private Vector3 Movement;
private Rigidbody rb;
public float moveSpeed = 8f;
**/
    /**
    //attack loop
    public float loopCounter;
    public bool canAttack;
    public bool runTimer;
    public float redCounter;
    **/









    /**
//howclose = 8;
//dist = 8;
changeable = GameObject.FindGameObjectsWithTag("Change");
Player = GameObject.FindGameObjectWithTag("player").transform;
canAttack = false;
**/











    /**
    IEnumerator Anticipation()
    {
        //show charge colours


        chargeBool = true;

        yield return new WaitForSeconds(3);

        //attack colours and remove player health


        attackBool = true;
       
        Character.playerHealth -= 1;
        Debug.Log("damage recieved");

        yield return new WaitForSeconds(1);

        regBool = true;

        StopCoroutine(Anticipation());
        // attack reset

    }
    **/



}



/**
 dist = Vector3.Distance(Player.position, transform.position);
 if (dist <= howclose)
 {
     transform.LookAt(Player);
     GetComponent<Rigidbody>().AddForce(transform.forward * moveSpeed * Time.deltaTime);
     runTimer = false;
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




if (canAttack == true)
{
    
    runTimer = true;
    canAttack = false;
    


    //regBool = false;
    //chargeBool = true;
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
        //attackBool = false;
        //regBool = true;
        redCounter = 0;
    }

}
        else
        {
            if(runTimer == false)
            {
                regBool = true;
            }
        }
        



if (runTimer == true)
{
    StartCoroutine(Anticipation());
}
else
{
    StopCoroutine(Anticipation());
}



//anticipation


if(chargeBool == true)
{
    attackBool = false;
    regBool = false;

    for (int i = 0; i < changeable.Length; i++)
    {
        changeable[i].GetComponent<MeshRenderer>().material = Charge;
    }
}
if (attackBool == true)
{
    chargeBool = false;
    regBool = false;

    for (int i = 0; i < changeable.Length; i++)
    {
        changeable[i].GetComponent<MeshRenderer>().material = Attack;
    }
}
if (regBool == true)
{
    chargeBool = false;
    attackBool = false;

    for (int i = 0; i < changeable.Length; i++)
    {
        changeable[i].GetComponent<MeshRenderer>().material = Regular;
    }
}

**/