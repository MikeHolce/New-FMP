using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    

    private bool startTimer;
    public static float timer = 3.5f;
    public float minusTime = 0.5f;

    public static bool spawnPlayer;
    public static bool begin;


    public float teleTimer;

    void Start()
    {
        startTimer = true;
        teleTimer = 0;
    }

    void Update()
    {
        if (startTimer == true)
        {
            timer -= Time.deltaTime * minusTime;
        }
        if (timer == 0)
        {
            startTimer = false;
        }
        if (timer <= 0)
        {
            begin = true;
            this.transform.position = new Vector3(0, 120, 0);
            minusTime = 0;
        }

        if (begin == true)
        {
            teleTimer += 0.5f * Time.deltaTime;
            if(teleTimer >= 1)
            {
                spawnPlayer = true;
                begin = false;
                timer = 1;
            }
        }

        if (spawnPlayer == true)
        {
            teleTimer = 0;
        }



    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

    }

}
