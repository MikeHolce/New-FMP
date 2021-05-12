using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winSound : MonoBehaviour
{
    static public bool play;
    public bool start;

    public GameObject music;

    // Start is called before the first frame update
    void Start()
    {
        play = false;
        music.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        



        if(play == true)
        {
            start = true;
        }

        if(start == true)
        {
            StartCoroutine(playing());
        }


    }


    IEnumerator playing()
    {
        play = false;
        start = false;
        music.SetActive(true);
        yield return new WaitForSeconds(1.3f);
        music.SetActive(false);
        StopCoroutine(playing());
    }

}
