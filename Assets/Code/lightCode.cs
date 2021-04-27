using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightCode : MonoBehaviour
{
    public Light L1;
    public Light L2;
    public Light L3;
    public Light L4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        L1.intensity = Mathf.PingPong(Time.time, 1);
        L2.intensity = Mathf.PingPong(Time.time, 1);
        L3.intensity = Mathf.PingPong(Time.time, 1);
        L4.intensity = Mathf.PingPong(Time.time, 1);
    }
}
