using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNameScript : MonoBehaviour 
{
    public Texture buttTexture;
    //public NameplatesScript[] nameplatesScript;

    public NameplatesScript nameplatesScript;
    public NameplatesScript nameplateScript;
    public NameplatesScript nameplatScript;
    public NameplatesScript nameplaScript;
    public NameplatesScript nameplScript;
    public NameplatesScript namepScript;


	// Use this for initialization
	void Start ()
    {
        //nameplatesScript = new NameplatesScript[5];
    }
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    void OnGUI()
    {
        if (GUI.Button(new Rect(740, 15, 80, 40), buttTexture))
        {
            //nameplatesScript[0] = GetComponent<NameplatesScript>();
            nameplatesScript.GetComponent<NameplatesScript>().changeNameTag();
            nameplateScript.GetComponent<NameplatesScript>().changeNameTag();
            nameplatScript.GetComponent<NameplatesScript>().changeNameTag();
            nameplaScript.GetComponent<NameplatesScript>().changeNameTag();
            nameplScript.GetComponent<NameplatesScript>().changeNameTag();
            namepScript.GetComponent<NameplatesScript>().changeNameTag();
        }
    }

}
