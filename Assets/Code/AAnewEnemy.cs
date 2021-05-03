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
    public bool coroStart;

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
        coroStart = false;
        beam.SetActive(false);
        beamCollide.SetActive(false);
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
                canAttack = false;
                transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
                beam.SetActive(false);
                beamCollide.SetActive(false);
            }
            //stop
            else if (Vector3.Distance(transform.position, player.position) < stopDist && Vector3.Distance(transform.position, player.position) > dipDist)
            {
                transform.position = this.transform.position;
                canAttack = true;
                //canMove = false;

            }
            //move away
            else if (Vector3.Distance(transform.position, player.position) < dipDist)
            {
                canAttack = false;
                transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
                beam.SetActive(false);
                beamCollide.SetActive(false);
            }
        }


        if (canAttack == true)
        {
            stopRepeat = 1;
            canMove = false;
        }

        if (canAttack == true && stopRepeat == 1)
        {
            stopRepeat = 3;
        }

        if (stopRepeat == 3)
        {
            stopRepeat = 5;
            StartCoroutine(Attacking());
        }



        /**
        if (Input.GetKeyDown("1"))
        {
            changeThat = 1;
        }
        if (Input.GetKeyDown("2"))
        {
            changeThat = 2;
        }
        if (Input.GetKeyDown("3"))
        {
            changeThat = 3;
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
    **/
    }

    IEnumerator Attacking()
    {
        if(coroStart == false)
        {
            coroStart = true;
            yield return new WaitForSeconds(1);
            Debug.Log("start attack");
            beam.SetActive(true);
            beamCollide.SetActive(true);
            yield return new WaitForSeconds(1);
            beam.SetActive(false);
            beamCollide.SetActive(false);
            canMove = true;
            StopCoroutine(Attacking());
            Debug.Log("stop attack");
        }
       
    }

}
