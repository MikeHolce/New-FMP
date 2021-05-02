using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAnewEnemy : MonoBehaviour
{
    public float speed;
    public float stopDist;
    public float dipDist;

    public bool canMove;
    public bool canAttack;

    public Transform player;
    //public Transform forward;

    public GameObject beam;
    public GameObject beamCollide;

    public int stopRepeat;

    //colour change
    public Material Regular;
    public Material Charge;
    public Material Attack;
    public int changeThat;
    public GameObject[] changeable;



    // Start is called before the first frame update
    void Start()
    {
        stopRepeat = 0;
        speed = 2;

        player = GameObject.FindGameObjectWithTag("player").transform;
        changeable = GameObject.FindGameObjectsWithTag("Change");

        canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);

        if (canMove == true)
        {
            //transform.LookAt(forward);
            //move toward
            if (Vector3.Distance(transform.position, player.position) > stopDist)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            }
            //stop
            else if (Vector3.Distance(transform.position, player.position) < stopDist && Vector3.Distance(transform.position, player.position) > dipDist)
            {
                transform.position = this.transform.position;
                canMove = false;

            }
            //move away
            else if (Vector3.Distance(transform.position, player.position) < dipDist)
            {
                transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
            }
        }
        else
        {
            canAttack = true;            
        }

        if(canAttack == true)
        {
            stopRepeat = 1;
        }

        if(canAttack == true && stopRepeat == 1)
        {
            stopRepeat = 3;
        }
        if(stopRepeat == 3)
        {
            StartCoroutine(Attacking());
            stopRepeat = 5;
        }

        //anticipation
        if (changeThat == 2)
        {


            for (int i = 0; i < changeable.Length; i++)
            {
                changeable[i].GetComponent<MeshRenderer>().material = Charge;
            }
        }
        if (changeThat == 3)
        {


            for (int i = 0; i < changeable.Length; i++)
            {
                changeable[i].GetComponent<MeshRenderer>().material = Attack;
            }
        }
        if (changeThat == 1)
        {

            for (int i = 0; i < changeable.Length; i++)
            {
                changeable[i].GetComponent<MeshRenderer>().material = Regular;
            }
        }
    }

    IEnumerator Attacking()
    {
        //charge cannon
        changeThat = 2;
        yield return new WaitForSeconds(1);
        //attack
        changeThat = 3;
        //Enemy.position = currentCheckpoint.position;;
        Debug.Log("looking at player");
        //transform.LookAt(player);
        Debug.Log("attacking player");
        //attack player
        //shoot cannon
        beam.SetActive(true); // false to hide, true to show
        beamCollide.SetActive(true);
        yield return new WaitForSeconds(1);
        // reg
        changeThat = 1;
        beam.SetActive(false);
        beamCollide.SetActive(false);
        //cannon cooldown
        yield return new WaitForSeconds(1);
        //lookPlayer = false;
        canMove = true;
        stopRepeat = 1;
        StopCoroutine(Attacking());
    }
}
