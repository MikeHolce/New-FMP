using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupCanvas : MonoBehaviour
{
    public static bool spawnPlayer;
    public static bool teleDestroy;

    public Canvas lootTimer;

    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
    public Sprite seven;
    public Sprite eight;
    public Sprite nine;
    public Sprite ten;
    public Sprite loot;
    public Sprite timeUp;
    public Sprite nothing;


    public Image Countdown;

    public bool canCount;


    // Start is called before the first frame update
    void Start()
    {
        Countdown.sprite = loot;
        canCount = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(canCount == true)
        {
            StartCoroutine(Timing());
        }
    }

    IEnumerator Timing()
    {
        canCount = false;
        //startTimer = false;
        //10
        Debug.Log("count");
        Countdown.sprite = ten;
        yield return new WaitForSeconds(1);
        //9
        Debug.Log("count");
        Countdown.sprite = nine;
        yield return new WaitForSeconds(1);
        //8
        Debug.Log("count");
        Countdown.sprite = eight;
        yield return new WaitForSeconds(1);
        //7
        Debug.Log("count");
        Countdown.sprite = seven;
        yield return new WaitForSeconds(1);
        //6
        Debug.Log("count");
        Countdown.sprite = six;
        yield return new WaitForSeconds(1);
        //5
        Debug.Log("count");
        Countdown.sprite = five;
        yield return new WaitForSeconds(1);
        //4
        Debug.Log("count");
        Countdown.sprite = four;
        yield return new WaitForSeconds(1);
        //3
        Debug.Log("count");
        Countdown.sprite = three;
        yield return new WaitForSeconds(1);
        //2
        Debug.Log("count");
        Countdown.sprite = two;
        yield return new WaitForSeconds(1);

        Debug.Log("count");
        Countdown.sprite = one;
        yield return new WaitForSeconds(1);
        //time up
        Countdown.sprite = timeUp;
        //teleport destroyer
        teleDestroy = true;
        //freeze move
        yield return new WaitForSeconds(0.5f);
        //nothing
        lootTimer.enabled = false;
        //teleport player
        spawnPlayer = true;
        //unfreeze move


        StopCoroutine(Timing());
    }
}

/**
if(Destroyer.timer <= 3)
{
    Countdown.sprite = six;
}
if (Destroyer.timer <= 2.5f)
{
    Countdown.sprite = five;
}
if (Destroyer.timer <= 2)
{
    Countdown.sprite = four;
}
if (Destroyer.timer <= 1.5f)
{
    Countdown.sprite = three;
}
if (Destroyer.timer <= 1)
{
    Countdown.sprite = two;
}
if (Destroyer.timer <= 0.5f)
{
    Countdown.sprite = one;
}
if (Destroyer.timer <= 0)
{
    Countdown.sprite = timeUp;
}
if (Destroyer.spawnPlayer == true)
{
    //canCount = false;
}

if (canCount == false)
{
    Debug.Log("this works now");
    lootTimer.enabled = false;
}
**/
