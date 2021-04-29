using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public Canvas PauseMenu;
    public static bool paused;
    // Start is called before the first frame update
    void Start()
    {
        PauseMenu.enabled = false;
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (paused == true)
            {
                Time.timeScale = 1.0f;
                PauseMenu.enabled = false;
                paused = false;
            }
            else
            {
                Time.timeScale = 0.0f;
                PauseMenu.enabled = true;
                paused = true;
            }
        }
    }
}
