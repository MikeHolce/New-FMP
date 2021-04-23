using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickupCanvas : MonoBehaviour
{

    public Canvas lootTimer;

    public Sprite zero;
    public Sprite one;
    public Sprite two;
    public Sprite three;
    public Sprite four;
    public Sprite five;
    public Sprite six;
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
            canCount = false;
        }

        if (canCount == false)
        {
            Debug.Log("this works now");
            lootTimer.enabled = false;
        }

    }
}
