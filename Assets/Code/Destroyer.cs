using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public Transform Destroyerer;
    public Transform Teleport;

    private bool startTimer;
    public int timer = 2;


    void Start()
    {
        startTimer = true;
    }

    void Update()
    {
        if (startTimer == true)
        {
            timer -= 1;
        }
        if (startTimer == false)
        {
            timer = 0;
        }
    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (timer <= 1)
        {
            Destroyerer.position = Teleport.position;  
        }
    }

}
