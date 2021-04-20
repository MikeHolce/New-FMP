using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Sprite healthBar1;
    public Sprite healthBar2;
    public Sprite healthBar3;
    public Sprite healthBar4;
    public Sprite healthBar5;
    public Sprite healthBar6;
    public Image healthBarImage;
    public float curHealth;

    public static Canvas deathMenu;
    public static bool paused;

    // Start is called before the first frame update
    void Start()
    {
        healthBarImage.sprite = healthBar1;
        curHealth = 10.0f;
    }

    // Update is called once per frame
    void Update()
    {
        curHealth -= 0.1f;
        if (curHealth < 8 && curHealth > 6)
        {
            healthBarImage.sprite = healthBar2;
        }
        else
        {
            if (curHealth < 6 && curHealth > 4)
            {
                healthBarImage.sprite = healthBar3;
            }
            else
            {
                if (curHealth < 4 && curHealth > 2)
                {
                    healthBarImage.sprite = healthBar4;
                }
                else
                {
                    if (curHealth < 2 && curHealth > 0)
                    {
                        healthBarImage.sprite = healthBar5;
                       
                    }
                    else
                    {
                        if (curHealth < 0 && curHealth > 0.1)
                        {
                            healthBarImage.sprite = healthBar6;

                        }
                    }
                }
            }
        }
    }
}
