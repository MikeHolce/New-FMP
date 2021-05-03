using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackCode : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Alien")
        {
            Destroy(other.gameObject);
            SpawningEnemy.Kills += 1;
        }
    }
}
