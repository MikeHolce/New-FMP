using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningEnemy : MonoBehaviour
{

    public GameObject Enemy;
    public Transform spawnZone;

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

    public int Counter;


    // Start is called before the first frame update
    void Start()
    {
        Activate = false;
        Spawn = false;
        Counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Activate == true)
        {
            Counter += 1;
            Activate = false;

        }

        if (Counter == 1)
        {
            Spawn = true;
            Activate = false;
            Counter += 1;


        }


        if (Spawn == true)
        {
            Spawn = false;
            Instantiate(Enemy, spawnZone.position, Quaternion.identity);

            Instantiate(doorT, T.position, Quaternion.identity);
            Instantiate(doorB, B.position, Quaternion.identity);
            Instantiate(doorL, L.position, L.rotation);
            Instantiate(doorR, R.position, R.rotation);
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Activate = true;
        }
    }
}
