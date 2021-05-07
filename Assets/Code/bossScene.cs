using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossScene : MonoBehaviour
{
    public Transform tFire;
    public Transform mFire;
    public Transform bFire;


    public GameObject[] Top;
    public GameObject[] Middle;
    public GameObject[] Bottom;


    public bool fireRain;


    public int rand;

    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(0, 2);

        tFire = GameObject.FindWithTag("SpawnZone1").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (fireRain == true)
        {
            StartCoroutine(frSection());
        }
    }
    IEnumerator frSection()
    {
        Instantiate(Top[rand], transform.position, Quaternion.identity);
        Instantiate(Middle[rand], transform.position, Quaternion.identity);
        Instantiate(Bottom[rand], transform.position, Quaternion.identity);

        yield return new WaitForSeconds(1);
    }
}
