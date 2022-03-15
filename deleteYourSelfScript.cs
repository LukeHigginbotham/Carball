using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deleteYourSelfScript : MonoBehaviour 
{
    public GameObject yourSelfFool;
    public GameObject yourSelfFool2;
    public GameObject yourSelfFool3;
    public GameObject yourSelfFool4;

    public bool touching1 = false;
    public bool touching2 = false;
    public bool touching3 = false;
    public bool touching4 = false;


	// Use this for initialization
	void Start () 
    {
        if (touching1 == true)
        {
            Destroy(yourSelfFool);
        }
        if (touching2 == true)
        {
            Destroy(yourSelfFool2);
        }
        if (touching3 == true)
        {
            Destroy(yourSelfFool3);
        }
        if (touching4 == true)
        {
            Destroy(yourSelfFool4);
        }

	}
	
	// Update is called once per frame
	void FixedUpdate () 
    {
        if (touching1 == true)
        {
            Destroy(yourSelfFool);
        }
        if (touching2 == true)
        {
            Destroy(yourSelfFool2);
        }
        if (touching3 == true)
        {
            Destroy(yourSelfFool3);
        }
        if (touching4 == true)
        {
            Destroy(yourSelfFool4);
        }

	}

    void OnTriggerEnter(Collider enterObjColl)
    {
        if (enterObjColl.CompareTag("Formation Car 1"))
        {
            touching1 = true;
        }
        if (enterObjColl.CompareTag("Formation Car 2"))
        {
            touching2 = true;
        }
        if (enterObjColl.CompareTag("Formation Car 3"))
        {
            touching3 = true;
        }
        if (enterObjColl.CompareTag("Formation Car 4"))
        {
            touching4 = true;
        }
    }

}
