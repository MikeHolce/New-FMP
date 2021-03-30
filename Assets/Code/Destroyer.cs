using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public Transform Destroyerer;
    public Transform Teleport;

    private bool startTimer;
    public float timer = 10;
    public float minusTime = 0.5f;


    void Start()
    {
        startTimer = true;
    }

    void Update()
    {
        if (startTimer == true)
        {
            timer -= Time.deltaTime * minusTime;
        }
        if (startTimer == false)
        {
            timer = 0;
        }
        if (timer <= 0)
        {
            timer = 0;
        }
    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        if (timer <= 0)
        {
            Destroyerer.position = Teleport.position;  
        }
    }

}
