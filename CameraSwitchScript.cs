using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchScript : MonoBehaviour
{   
    public Camera[] cameras;
    public int currentCameraIndex;

    public Texture buttonTexture;

	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

	private void OnGUI()
	{
        if (GUI.Button(new Rect(20, 15, 80, 40), buttonTexture))
        {
            currentCameraIndex ++;

            if (currentCameraIndex < cameras.Length)
            {
                cameras[currentCameraIndex - 1].gameObject.SetActive(false);
                cameras[currentCameraIndex].gameObject.SetActive(true);
            }
            else
            {
                cameras[currentCameraIndex - 1].gameObject.SetActive(false);
                currentCameraIndex = 0;
                cameras[currentCameraIndex].gameObject.SetActive(true);

            }
        }
	}
}
