using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAnewEnemy : MonoBehaviour
{
    public float speed;
    public float stopDist;
    public float dipDist;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player").transform;


    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) > stopDist)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
        else if(Vector3.Distance(transform.position, player.position) < stopDist && Vector3.Distance(transform.position, player.position) > dipDist)
        {
            transform.position = this.transform.position;
        }
        else if (Vector3.Distance(transform.position, player.position) < dipDist)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, -speed * Time.deltaTime);
        }
    }
}
