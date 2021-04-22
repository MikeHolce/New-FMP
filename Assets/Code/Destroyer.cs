using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    

    private bool startTimer;
    public float timer = 3;
    public float minusTime = 0.5f;

    public static bool spawnPlayer;


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
        if (timer == 0)
        {
            startTimer = false;
        }
        if (timer <= 0)
        {
            this.transform.position = new Vector3(0, 120, 0);
            minusTime = 0;
            spawnPlayer = true;
        }






    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

    }

}
