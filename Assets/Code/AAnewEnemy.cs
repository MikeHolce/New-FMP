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

    static public bool destroySelf;



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
    }

    // Update is called once per frame
    void Update()
    {
        /**
        if(destroySelf == true)
        {
            Debug.Log("heard");
            Destroy(this.gameObject);
        }
        **/

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
                coroStart = false;
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


        if(Character.playerHealth <= 0)
        {
            Destroy(this.gameObject);
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

            Debug.Log("start attack");
            beam.SetActive(true);
            beamCollide.SetActive(true);
            yield return new WaitForSeconds(1);


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

            beam.SetActive(false);
            beamCollide.SetActive(false);
            canMove = true;
            Debug.Log("stop attack");
            StopCoroutine(Attacking());           
        }
       
    }

}
