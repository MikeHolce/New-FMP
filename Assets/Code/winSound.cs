using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winSound : MonoBehaviour
{


    static public int count;
    public bool play;
    public bool check;
    public AudioSource win;


    // Start is called before the first frame update
    void Start()
    {
        play = false;
        check = true;

        count = 0;

        win = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        

        if(count >= 1 && check == true)
        {
            play = true;


        }



        if(play == true)
        {
            check = false;
            win.Play();
            count = 0;
        }


    }


}
