using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameManagerScript myTeamManScript;
    public Texture store;

    public void PlayGame()
    {
        SceneManager.LoadScene("new map");

    }

    public void MyTeam()
    {
        SceneManager.LoadScene("NewTeamPage");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void FirstTeam()
    {
        SceneManager.LoadScene("NewTeamPage");

    }

    private void OnGUI()
    {
        if (GUI.Button(new Rect(2400, 20, 130, 70), store))
        {
            SceneManager.LoadScene("Store");
        }
    }
	// Use this for initialization
	void Start ()
    {
        
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }
}
