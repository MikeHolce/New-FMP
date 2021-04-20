using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    public Sprite HealthBarFull;
    public Sprite HealthBar2;
    public Sprite HealthBar3;
    public Sprite HealthBar4;
    public Sprite HealthBar5;
    public Sprite HealthBar6;
    public Image HealthBarImage;
    public static int curHealth;
    public static int curmana;
    public int Counter;
    public Canvas DeathCanvas;
    public Canvas HealthCanvas;
    public Canvas EndCanvas;

    // Start is called before the first frame update
    void Start()
    {
        HealthBarImage.sprite = HealthBarFull;
        curHealth = 5;
        DeathCanvas.enabled = false;
        EndCanvas.enabled = false;
        Counter = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (curHealth == 0)
        {
            HealthBarImage.sprite = HealthBar5;
            DeathCanvas.enabled = true;
        }
        if (curHealth == 5)
        {
            HealthBarImage.sprite = HealthBarFull;
        }
        if (curHealth == 4)
        {
            HealthBarImage.sprite = HealthBar2;
        }
        if (curHealth == 3)
        {
            HealthBarImage.sprite = HealthBar3;
        }
        if (curHealth == 2)
        {
            HealthBarImage.sprite = HealthBar4;
        }
        if (curHealth == 1)
        {
            HealthBarImage.sprite = HealthBar5;
        }
        if (curHealth == 0)
        {
            HealthBarImage.sprite = HealthBar6;
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "DangerEnd")
        {
            curHealth -= 5;
        }
        else
        if (other.name == "Trap")
        {
            curHealth -= 1;
        }
        if (other.tag == "Enemy")
        {
            curHealth -= 2;
        }
        {
            if (other.name == "Potion")
            {
                Destroy(other.gameObject);
                curHealth += 1;
            }
        }
        if (other.name == "End")
        {
            EndCanvas.enabled = true;
        }
    }
}
