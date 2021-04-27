using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    

    private bool startTimer;
    //public static float timer = 3.5f;
    //public float minusTime = 0.5f;

    public static bool spawnPlayer;
    //public static bool begin;


    //public float teleTimer;

    void Start()
    {
        //startTimer = true;
        //teleTimer = 0;
    }

    void Update()
    {

        if(pickupCanvas.teleDestroy == true)
        {
            this.transform.position = new Vector3(0, 120, 0);
            pickupCanvas.teleDestroy = false;
        }

        /**
        if (startTimer == true)
        {
            StartCoroutine(Timing());
        }
        **/

    }

    


    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

    }

}
