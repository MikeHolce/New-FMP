using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject Map;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player.gameObject.SetActive(true);
        Map.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("m"))
        {
            Map.gameObject.SetActive(true);
            Player.gameObject.SetActive(false);
        }
        if (Input.GetKeyUp("m"))
        {
            Player.gameObject.SetActive(true);
            Map.gameObject.SetActive(false);
        }
    }
}
