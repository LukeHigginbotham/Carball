using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormationScript : MonoBehaviour
{
    public GameObject car;

    // Use this for initialization
    void Start ()
    {

    }


    // Update is called once per frame
    void Update ()
    {
       
	}

    void OnTriggerEnter(Collider enterObjColl)
    {

        if (enterObjColl.CompareTag("Ball"))
        {
            //car.GetComponent<NewCarControlScript>().chaseBall = true;
            car.GetComponent<NewCarControlScript>().BeginChase();
        }
    }
    private void OnTriggerExit(Collider enterObjColl)
    {
        if (enterObjColl.CompareTag("Ball"))
        {
            car.GetComponent<NewCarControlScript>().StopChase();
        }
    }
}
