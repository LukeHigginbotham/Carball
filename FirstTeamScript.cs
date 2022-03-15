using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.SceneManagement;


public class FirstTeamScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Vector3 originalPos;

    private bool mouseDown = false;
    private Vector3 startMousePos;
    private Vector3 startPos;

	// Use this for initialization
    public void OnPointerDown(PointerEventData ped)
    {
        mouseDown = true;
        startPos = transform.position;
        startMousePos = Input.mousePosition;
    }

    public void OnPointerUp(PointerEventData ped)
    {
        mouseDown = false;

    }

	void Start () 
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (mouseDown)
        {
            Vector3 currentPos = Input.mousePosition;
            Vector3 diff = currentPos - startMousePos;
            Vector3 pos = startPos + diff;
            transform.position = pos;
        }
        else
        {
            gameObject.transform.position = originalPos;
        }
	}

    void OnTriggerEnter(Collider enterObjColl)
    {
        if (enterObjColl.CompareTag("First Team"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
            {
                print("it worked");
            }
        }
    }
}
