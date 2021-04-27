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
        StartCoroutine(Timing());
        //teleTimer = 0;
    }

    void Update()
    {
        /**
        if (startTimer == true)
        {
            StartCoroutine(Timing());
        }
        **/

    }

    IEnumerator Timing()
    {
        //startTimer = false;
        //10
        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.ten;
        yield return new WaitForSeconds(1);
        //9
        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.nine;
        yield return new WaitForSeconds(1);
        //8
        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.eight;
        yield return new WaitForSeconds(1);
        //7
        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.seven;
        yield return new WaitForSeconds(1);
        //6
        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.six;
        yield return new WaitForSeconds(1);
        //5
        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.five;
        yield return new WaitForSeconds(1);
        //4
        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.four;
        yield return new WaitForSeconds(1);
        //3
        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.three;
        yield return new WaitForSeconds(1);
        //2
        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.two;
        yield return new WaitForSeconds(1);

        Debug.Log("count");
        pickupCanvas.Countdown.sprite = pickupCanvas.one;
        yield return new WaitForSeconds(1);
        //time up
        pickupCanvas.Countdown.sprite = pickupCanvas.timeUp;
        this.transform.position = new Vector3(0, 120, 0);
        //freeze move
        yield return new WaitForSeconds(0.5f);
        //nothing
        pickupCanvas.lootTimer.enabled = false;
        //teleport player
        spawnPlayer = true;
        //unfreeze move


        StopCoroutine(Timing());
    }


    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

    }

}
