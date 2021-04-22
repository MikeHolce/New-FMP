using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickupObjects : MonoBehaviour
{
    public GameObject Health;
    public GameObject Armour;
    public GameObject Sprint;



    public bool gotArmour;
    public bool gotSprint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Health")
        {
            Character.playerHealth += 1;
            Destroy(other.gameObject);
        }

        if (other.name == "Armour")
        {
            gotArmour = true;
        }

        if (other.name == "Sprint")
        {
            gotSprint = true;
        }

    }

}
