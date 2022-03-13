using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CoinScript : MonoBehaviour 
{
    static int totalCoins = 200;
    static int heatwaves = 5;

    private GUIStyle guiStyle = new GUIStyle();

    static CoinScript instance;

	// Use this for initialization
	void Start () 
    {
        guiStyle.normal.textColor = Color.white;
	}

	void Awake()
	{
		if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
	}

	public void WonCoins()
    {
        totalCoins = totalCoins + 150;
        SceneManager.LoadScene("Transition Screen");
    }

    public void LostCoins()
    {
        totalCoins = totalCoins + 25;
        SceneManager.LoadScene("LoserScreen");
    }

	private void OnGUI()
	{
        guiStyle.fontSize = 30;
        GUI.Label(new Rect(1980, 45, 100, 100), "Coins: " + totalCoins, guiStyle);
        GUI.Label(new Rect(2170, 45, 100, 100), "Heatwaves: " + heatwaves, guiStyle);
	}
}
