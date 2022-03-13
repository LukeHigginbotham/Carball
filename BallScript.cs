using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Transform myTransform;
    public Transform bluetarget;
    public Transform orangetarget;
    //public Transform middleoffield;

    public int forwardPower;
    public int upwardPower;

    public int forwardPowerRank_a;
    public int upwardPowerRank_a;

    public int forwardPowerRank_s;
    public int upwardPowerRank_s;

    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Orange Goal");
        GameObject goes = GameObject.FindGameObjectWithTag("Blue Goal");
        //GameObject begone = GameObject.FindGameObjectWithTag("middleoffield");


        bluetarget = go.transform;
        orangetarget = goes.transform;
        //middleoffield = begone.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider enterObjColl)
    {
        if (enterObjColl.CompareTag("Blue Car"))
        {
            myTransform.LookAt(bluetarget);
            var player = enterObjColl.transform.gameObject.GetComponent<BallScript>();
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * forwardPower);
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * upwardPower);
        }

        else if (enterObjColl.CompareTag("Orange Car"))
        {
            myTransform.LookAt(orangetarget);
            var player = enterObjColl.transform.gameObject.GetComponent<BallScript>();
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * forwardPower);
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * upwardPower);
        }



        else if (enterObjColl.CompareTag("Blue Car Rank A"))
        {
            myTransform.LookAt(bluetarget);
            var player = enterObjColl.transform.gameObject.GetComponent<BallScript>();
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * forwardPowerRank_a);
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * upwardPowerRank_a);
        }

        else if (enterObjColl.CompareTag("Orange Car Rank A"))
        {
            myTransform.LookAt(orangetarget);
            var player = enterObjColl.transform.gameObject.GetComponent<BallScript>();
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * forwardPowerRank_a);
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * upwardPowerRank_a);
        }



        else if (enterObjColl.CompareTag("Blue Car Rank S"))
        {
            myTransform.LookAt(bluetarget);
            var player = enterObjColl.transform.gameObject.GetComponent<BallScript>();
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * forwardPowerRank_a);
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * upwardPowerRank_a);
        }

        else if (enterObjColl.CompareTag("Orange Car Rank S"))
        {
            myTransform.LookAt(orangetarget);
            var player = enterObjColl.transform.gameObject.GetComponent<BallScript>();
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * forwardPowerRank_s);
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * upwardPowerRank_s);
        }

        //if (enterObjColl.CompareTag("wall"))
        //{
        //    myTransform.LookAt(middleoffield);
        //    var player = enterObjColl.transform.gameObject.GetComponent<BallScript>();
        //    GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * forwardPower);
        //    GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * upwardPower);
        //}
    }
}
