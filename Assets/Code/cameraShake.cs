using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    static public Transform main;
    static public Transform middle;
    public Transform left;
    public Transform right;

    static public bool shake;
    public bool startShake;
    public int stopRepeat;

    public float step;
    public float moveSpeed;

    static public bool goLeft;
    static public bool goRight;





    // Start is called before the first frame update
    void Start()
    {
        shake = true;
        moveSpeed = 10;
        step = moveSpeed * Time.deltaTime; // calculate distance to move

        goLeft = false;
        goRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        /**
        if (goLeft == true)
        {
            stopRepeat = 1;
            if (stopRepeat == 1)
            {
                stopRepeat = 0;
                StartCoroutine(shakeLeft());
            }
        }

        if (goRight == true)
        {
            stopRepeat = 1;
            if (stopRepeat == 1)
            {
                stopRepeat = 0;
                StartCoroutine(shakeRight());
            }
        }
        **/

        if (Input.GetKeyDown("space"))
        {
            shake = true;
            goLeft = true;
        }
        if (Input.GetKeyUp("space"))
        {
            shake = false;
            goLeft = false;
            goRight = false;
            main.position = middle.position;
        }

        if (shake == true)
        {
            if (goLeft == true) // left
            {
                main.position = Vector3.MoveTowards(transform.position, left.position, step);
                if (main.position == left.position)
                {
                    goLeft = false;
                    goRight = true;

                }
            }
            if (goRight == true) // right
            {
                //currentCheckpoint = Checkpoint2;
                main.position = Vector3.MoveTowards(transform.position, right.position, step);
                if (main.position == right.position)
                {
                    goRight = false;
                    goLeft = true;
                }
            }
        }
        

    }
    /**
    IEnumerator shakeLeft()
    {
        startShake = false;
        Debug.Log("left");
        main.position = Vector3.MoveTowards(transform.position, left.position, step);
        yield return new WaitForSeconds(1);
        shake = true;
        StopCoroutine(shakeLeft());
    }
    IEnumerator shakeRight()
    {
        startShake = false;
        Debug.Log("right");
        main.position = Vector3.MoveTowards(transform.position, right.position, step);
        yield return new WaitForSeconds(1);
        shake = false;
        StopCoroutine(shakeRight());
    }
    **/
}
