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
    public static int playerHealth;
    public Canvas DeathCanvas;
    public Canvas HealthCanvas;
    public Canvas EndCanvas;
    public static bool paused;

    public GameObject Health;

    // Start is called before the first frame update
    void Start()
    {
        HealthBarImage.sprite = HealthBarFull;
        Character.playerHealth = 2;
        DeathCanvas.enabled = false;
        paused = false;
        EndCanvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Character.playerHealth == 0)
        {
            HealthBarImage.sprite = HealthBar5;
            DeathCanvas.enabled = true;
            if (DeathCanvas.enabled == true)
            {
                PauseGame();
            }
        }
        if (Character.playerHealth == 5)
        {
            HealthBarImage.sprite = HealthBarFull;
        }
        if (Character.playerHealth == 4)
        {
            HealthBarImage.sprite = HealthBar2;
        }
        if (Character.playerHealth == 3)
        {
            HealthBarImage.sprite = HealthBar3;
        }
        if (Character.playerHealth == 2)
        {
            HealthBarImage.sprite = HealthBar4;
        }
        if (Character.playerHealth == 1)
        {
            HealthBarImage.sprite = HealthBar5;
        }
        if (Character.playerHealth == 0)
        {
            HealthBarImage.sprite = HealthBar6;
        }

        if (Input.GetKeyDown("space"))
        {
            Character.playerHealth -= 1;
        }
        if (playerHealth >= 1)
        {
            Debug.Log("player died");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "DangerEnd")
        {
            Character.playerHealth -= 5;
        }
        else
        if (other.name == "Trap")
        {
            Character.playerHealth -= 1;
        }
        if (other.tag == "Enemy")
        {
            Character.playerHealth -= 1;
        }
        {
            if (other.name == "Health")
            {
                Character.playerHealth += 1;
                Destroy(other.gameObject);
            }
        }
        if (other.name == "End")
        {
            EndCanvas.enabled = true;
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        paused = true;
    }
}
