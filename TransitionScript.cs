using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour
{
    public Texture buttTexture;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(40, 20, 150, 80), buttTexture))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
