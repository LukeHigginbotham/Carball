using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bluegoalscript : MonoBehaviour
{
    private GameObject ballObject;
    private GameManagerScript gameManagerScript;


    // Use this for initialization
    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider enterObjColl)
    {
        if (enterObjColl.CompareTag("Ball"))
        {
            gameManagerScript.GetComponent<GameManagerScript>().AddpointsOrange();
        }
    }

}
