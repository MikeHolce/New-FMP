using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteWall : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Walls")
        {
            Destroy(other.gameObject);
        }
    }
}
