using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamCode : MonoBehaviour
{

    public bool attack;
    public int stopRepeat;

    void Start()
    {
        stopRepeat = 0;
    }

    void Update()
    {

        if(stopRepeat == 1)
        {
            attack = true;
        }
        else
        {
            attack = false;
        }

        if(attack == true && stopRepeat == 1)
        {
            StartCoroutine(attackDamage());
        }



    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "player")
        {
            stopRepeat = 1;

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "player")
        {
            stopRepeat = 0;

        }
    }

    IEnumerator attackDamage()
    {
        stopRepeat = 3;

        if(stopRepeat == 3)
        {
            Debug.Log("attacking player");
            Character.playerHealth -= 1;
            //begin shake
            cameraShake.shakeDatThang = true;
            yield return new WaitForSeconds(1);
            //end shake
            cameraShake.shakeDatThang = false;
            stopRepeat = 0;

        }
        
    }
}
