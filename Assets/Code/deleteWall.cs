using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteWall : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Start")
        {
            Destroy(this.gameObject);
        }
    }
}
