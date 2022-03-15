using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingBlockScript : MonoBehaviour 
{
    Collider enterObjColl;

    bool valid = false;
	// Use this for initialization
	void Start () 
    {
        
	}
	
	// Update is called once per frame
	void Update () 
    {
        while (valid)
        {
            if (enterObjColl.CompareTag("Formation Car 1"))
            {
                GetComponent<Collider>().enabled = false;
            }
            else if (enterObjColl.CompareTag("Formation Car 2"))
            {
                GetComponent<Collider>().enabled = false;
            }
            else if (enterObjColl.CompareTag("Formation Car 3"))
            {
                GetComponent<Collider>().enabled = false;
            }
            else if (enterObjColl.CompareTag("Formation Car 4"))
            {
                GetComponent<Collider>().enabled = false;
            }
        }
	}
    void OnTriggerEnter(Collider enterObjColl)
    {
        if (enterObjColl.CompareTag("Car Icon"))
        {
            GetComponent<Collider>().enabled = false;
            valid = true;
        }
    }
	void OnTriggerExit(Collider enterObjColl)
	{
        GetComponent<Collider>().enabled = true;
	}
}
