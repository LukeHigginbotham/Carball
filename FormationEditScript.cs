using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormationEditScript : MonoBehaviour 
{    
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
        if (enterObjColl.CompareTag("Formation"))
        {
            transform.GetComponent<Renderer>().material.color = Color.green;

        }
	}
}
