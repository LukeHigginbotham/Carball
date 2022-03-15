using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    private GameObject ballObject;
    Vector3 ballSpawnPosition;
    public GameObject ballPrefab;

    private GameManagerScript gameManagerScript;
    // Use this for initialization
    void Start()
    {
        ballObject = GameObject.FindWithTag("Ball");
        ballSpawnPosition = ballObject.transform.position;

        gameManagerScript = FindObjectOfType<GameManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ballObject == null)
        {
            ballObject = GameObject.FindWithTag("Ball");
        }
    }
    void OnTriggerEnter(Collider enterObjColl)
    {
        if (enterObjColl.CompareTag("Ball"))
        {
            Destroy(ballObject);
            Invoke("ResetBall", 3f);
        }
    }
    private void ResetBall()
    {
        if (ballObject != null)
        {
            return;
        }
        ballObject = Instantiate(ballPrefab);
        ballObject.transform.position = ballSpawnPosition;
        var orangeCars = GameObject.FindGameObjectsWithTag("Orange Car");
        var blueCars = GameObject.FindGameObjectsWithTag("Blue Car");

        var orangeCarsRanka = GameObject.FindGameObjectsWithTag("Orange Car Rank A");
        var blueCarsRanka = GameObject.FindGameObjectsWithTag("Blue Car Rank A");

        var orangeCarsRanks = GameObject.FindGameObjectsWithTag("Orange Car Rank S");
        var blueCarsRanks = GameObject.FindGameObjectsWithTag("Blue Car Rank S");

        for (int i = 0; i < orangeCars.Length; i++)
        {
            orangeCars[i].GetComponent<NewCarControlScript>().Reset();
            blueCars[i].GetComponent<NewCarControlScript>().Reset();

        }
        for (int j = 0; j < orangeCarsRanka.Length; j++)
        {
            orangeCarsRanka[j].GetComponent<NewCarControlScript>().Reset();
            blueCarsRanka[j].GetComponent<NewCarControlScript>().Reset();

        }

        for (int k = 0; k < orangeCarsRanks.Length; k++)
        {
            orangeCarsRanks[k].GetComponent<NewCarControlScript>().Reset();
            blueCarsRanks[k].GetComponent<NewCarControlScript>().Reset();

        }
    }

}
