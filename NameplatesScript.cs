using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameplatesScript : MonoBehaviour
{
    private Transform target;

    public GameObject nameTag;

    private GameObject[] nameList;

    private bool toggle = false;


    // Use this for initialization
    void Start()
    {
        nameTag.SetActive(true);
        nameList = GameObject.FindGameObjectsWithTag("nametag");

    }

    // Update is called once per frame
    void Update()
    {
        target = GameObject.FindGameObjectWithTag("MainCamera").transform;
        transform.LookAt(target);

    }

    public void changeNameTag()
    {
        if (!toggle)
        {
            nameTag.SetActive(false);
            toggle = true;
        }
        else
        {
            nameTag.SetActive(true);
            toggle = false;
        }
    }

}
