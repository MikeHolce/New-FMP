using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectUICode : MonoBehaviour
{
    public Canvas Canvas1;
    // Start is called before the first frame update
    void Start()
    {
        Canvas1.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "TaskTrigger_ON")
        {
            Canvas1.enabled = true;
        }
        if (other.name == "TaskTrigger_OFF")
        {
            TimerUp.instance.BeginTimer();
            Canvas1.enabled = false;
        }
    }
}
