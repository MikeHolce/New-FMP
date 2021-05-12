using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnCode : MonoBehaviour
{
    public Transform forward;
    public Transform left;
    public Transform right;
    public Transform backward;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // only needed if animations dont workm for all directions

        if(Character.move == true)
        {
            if (Input.GetKey("w"))
            {
                transform.LookAt(forward);
            }
            if (Input.GetKey("a"))
            {
                transform.LookAt(left);
            }
            if (Input.GetKey("s"))
            {
                transform.LookAt(backward);
            }
            if (Input.GetKey("d"))
            {
                transform.LookAt(right);
            }
        }   
    }
}
