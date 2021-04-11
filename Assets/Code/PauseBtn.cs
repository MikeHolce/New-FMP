using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBtn : MonoBehaviour
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

    }
    public void TogglePause()
    {
        paused = !paused;
        PauseMenu.enabled = false;
        paused = false;
        Time.timeScale = 1;
        paused = false;
    }
}
