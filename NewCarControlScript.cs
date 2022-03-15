using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewCarControlScript : MonoBehaviour
{
    public GameObject startWaypoint;

    GameObject currentWaypoint;

    bool chaseBall = false;
   
    public GameObject chaseTarget;

    public float MoveSpeed = 2.5f;

    public float waypointSpeed = 0.45f;

    // Use this for initialization
    void Start()
    { 
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "new map")
        {
            Reset();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (chaseBall == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, currentWaypoint.transform.position, waypointSpeed);
            transform.rotation = Quaternion.LookRotation(currentWaypoint.transform.position - transform.position);
            if (transform.position == currentWaypoint.transform.position)
            {
                currentWaypoint = currentWaypoint.GetComponent<WayPointScript>().nextWaypoint;
            }
        }
        else if (chaseBall == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, chaseTarget.transform.position, MoveSpeed * Time.deltaTime * MoveSpeed);
            transform.rotation = Quaternion.LookRotation(chaseTarget.transform.position - transform.position);
        }
    }

    public void BeginChase()
    {
        chaseBall = true;
    }
    public void StopChase()
    {
        chaseBall = false;
    }
    public void Reset()
    {
        chaseBall = false;
        transform.position = startWaypoint.transform.position;
        currentWaypoint = startWaypoint.GetComponent<WayPointScript>().nextWaypoint;
        chaseTarget = GameObject.FindGameObjectWithTag("Ball");
    }
}
