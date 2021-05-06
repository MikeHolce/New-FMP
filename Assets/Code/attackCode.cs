using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackCode : MonoBehaviour
{
    public AudioSource alienDeath;

    void Start()
    {
        alienDeath = GetComponent<AudioSource>();
    }


    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Alien")
        {
            Debug.Log("alien hit");
            Destroy(other.gameObject);
            alienDeath.Play();
            SpawningEnemy.Kills += 1;
        }
    }
}
