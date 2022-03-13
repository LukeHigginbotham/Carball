using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    public Texture scoreBoard;
    private GameObject emptyObject;

    private GameObject ballObject;
    public GameObject coins;

    int bluepoints = 0;
    int orangepoints = 0;

    private float theTimer = 0.0f;
    private float theOverTimer = 30.0f;
    public float theStartTimer = 120.0f;
    float displayMinutes;
    float displaySeconds;

    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;


    private NameplatesScript npScript;

    private GUIStyle guiStyle = new GUIStyle();
    private GUIStyle guistyle = new GUIStyle();

    void Start()
    {
        theTimer = theStartTimer;

        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);

        npScript = FindObjectOfType<NameplatesScript>();

        guiStyle.normal.textColor = Color.black;
        guistyle.normal.textColor = Color.white;
    }

    void Update()
    {
        theTimer -= Time.deltaTime;

        if (theTimer <= 0)
        {
            theTimer = 0;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }

    public void Reset()
    {
        ResetCars("Orange Car");
        ResetCars("Blue Car");
        ResetCars("Orange Car Rank A");
        ResetCars("Blue Car Rank A");
        ResetCars("Orange Car Rank S");
        ResetCars("Blue Car Rank S");

    }

    void ResetCars(string carType)
    {
        GameObject[] cars = GameObject.FindGameObjectsWithTag(carType);

        int n = cars.Length;
        for (int i = 0; i < n; i++)
        {
            var car = cars[i];
            car.GetComponent<NewCarControlScript>().Reset();
        }
    }

    void OnGUI()
    {
        GUI.color = Color.white;
        GUI.DrawTexture(new Rect(20, -850, 800, 2100), scoreBoard, ScaleMode.ScaleToFit, true, 2);

        guiStyle.fontSize = 30;
        GUI.Label(new Rect(515, 15, 100, 100), "" + bluepoints, guiStyle);
        GUI.Label(new Rect(310, 15, 100, 100), "" + orangepoints, guiStyle);

        guistyle.fontSize = 30;
        displayMinutes = Mathf.FloorToInt(theTimer / 60.0f);
        displaySeconds = Mathf.FloorToInt(theTimer % 60.0f);
        string text = string.Format("{0:00}:{1:00}", displayMinutes.ToString("0"), displaySeconds.ToString("00"));
        GUI.Label(new Rect(387, 7, 100, 100), "" + text, guistyle);

        if (theTimer == 0)
        {
            if (bluepoints > orangepoints)
            {
                Invoke("ResetBall", 5f);
                Destroy(ballObject);
                GameOverBlue();
            }
            else if (orangepoints > bluepoints)
            {
                Invoke("ResetBall", 5f);
                Destroy(ballObject);
                GameOverOrange();
            }
            else if (bluepoints == orangepoints)
            {
                OverTime();
            }
        }
    }

    void OverTime()
    {
        Invoke("ResetBall", 5f);
        GUI.color = Color.black;
        string gameOT = string.Format("Overtime!");
        GUI.Label((new Rect(390, 55, 100, 100)), "" + gameOT);
    }

    public void GameOverBlue()
    {
        coins.GetComponent<CoinScript>().WonCoins();
    }

    public void GameOverOrange()
    {
        coins.GetComponent<CoinScript>().LostCoins();
    }

    public void AddpointsBlue()
    {
        bluepoints = bluepoints + 1;
    }

    public void AddpointsOrange()
    {
        orangepoints = orangepoints + 1;
    }

}


// Generic
public class SuperList<T>
{
    T[] myArray;
}
