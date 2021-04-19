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
        if (Input.GetKeyDown("p"))
        {
            PauseMenu.enabled = !PauseMenu.enabled;
            if (PauseMenu.enabled == true)
                
            {
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }
    void PauseGame()
    {
        Time.timeScale = 0;
        paused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        paused = false;
    }
}
