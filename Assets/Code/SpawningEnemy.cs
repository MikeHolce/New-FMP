using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemy : MonoBehaviour
{

    public GameObject Enemy;
    public Transform theZone1;
    public Transform theZone2;
    public Transform theZone3;


    public Transform T;
    public Transform B;
    public Transform L;
    public Transform R;

    public GameObject doorT;
    public GameObject doorB;
    public GameObject doorL;
    public GameObject doorR;

    public bool Activate;
    public bool Spawn;
    public bool Unlock;

    public int Counter;
    static public int Kills;
    public int killsView;

    public int rand;
    public GameObject[] Checkpoints;

    // Start is called before the first frame update
    void Start()
    {
        Activate = false;
        Spawn = false;
        Unlock = false;

        Counter = 0;
        Kills = 0;

        rand = Random.Range(0, Checkpoints.Length);
    }

    // Update is called once per frame
    void Update()
    {
        killsView = Kills;
        if (Activate == true)
        {
            Debug.Log("activate is true");
            Counter += 1;
            Activate = false;

        }

        if (Counter == 1)
        {
            Spawn = true;
            Activate = false;
            Unlock = false;
            Counter += 1;
        }


        if (Spawn == true)
        {
            Debug.Log("spawn is true");
            //theZone = GameObject.FindWithTag("spawnZone").transform;

            Spawn = false;
            Instantiate(doorT, T.position, Quaternion.identity);
            Instantiate(doorB, B.position, Quaternion.identity);
            Instantiate(doorL, L.position, L.rotation);
            Instantiate(doorR, R.position, R.rotation);  //this part is to rotate the doors on the left n right


            Instantiate(Checkpoints[rand], transform.position, Quaternion.identity);
            theZone1 = GameObject.FindWithTag("SpawnZone1").transform;
            theZone2 = GameObject.FindWithTag("SpawnZone2").transform;
            theZone3 = GameObject.FindWithTag("SpawnZone3").transform;
            Instantiate(Enemy, theZone1.position, Quaternion.identity);          
            Instantiate(Enemy, theZone2.position, Quaternion.identity);
            Debug.Log("enemys");
            Instantiate(Enemy, theZone3.position, Quaternion.identity);          
        }


        if (Kills >= 3)
        {
            Unlock = true;
        }


        if (Unlock == true)
        {
            Destroy(GameObject.FindWithTag("Door"));
            Spawn = false;
            Unlock = false;

        }


    }


    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("player entered");
            Activate = true;
        }


    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            AAnewEnemy.destroySelf = false;
            Counter = 0;
            Activate = false;
            Spawn = false;
            Unlock = false;
            Kills = 0;
            Destroy(this.gameObject);
            //Destroy(GameObject.FindWithTag("Check1"));
            //Destroy(GameObject.FindWithTag("Check2"));
            Destroy(GameObject.FindWithTag("checkPrefab"));
            Destroy(GameObject.FindWithTag("spawnZone"));
        }
    }


}
