using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControllerScript : MonoBehaviour
{
    public Transform target;

    public int moveSpeed;

    public Transform myTransform;

    public int rotationSpeed;


    // Use this for initialization
    void Start()
    {
        GameObject go = GameObject.FindGameObjectWithTag("Ball");

        target = go.transform;

    }

    // Update is called once per frame
    void Update()
    {
        //move towards other other team AI
        myTransform.LookAt(target);
        myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
        myTransform.rotation = Quaternion.Slerp(myTransform.rotation, Quaternion.LookRotation(target.position - myTransform.position), rotationSpeed * Time.deltaTime);

    }
}
