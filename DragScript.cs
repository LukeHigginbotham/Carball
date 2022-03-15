using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.SceneManagement;


public class DragScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Vector3 originalPos;

    private bool mouseDown = false;
    private Vector3 startMousePos;
    private Vector3 startPos;

    public GameObject car3D;
    public GameObject yourselfFool;

    public GameObject carForm1;
    public GameObject carForm2;
    public GameObject carForm3;


    public GameManagerScript myTeamManScript;

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

    void Start()
    {
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }


    void Update()
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
        if (enterObjColl.CompareTag("Starting Block 1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
            {
                Instantiate(car3D, new Vector3(-4, -7, 15), Quaternion.Euler(0,180,0));
                originalPos = new Vector3(1240, 650, 5);
                carForm1 = car3D;
            }
            Destroy(yourselfFool);
        }
        else if (enterObjColl.CompareTag("Starting Block 2"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
            {
                Instantiate(car3D, new Vector3(2, -7, 19), Quaternion.Euler(0, 180, 0));
                originalPos = new Vector3(1240, 650, 5);
                carForm2 = car3D;
            }
            Destroy(yourselfFool);
        }
        else if (enterObjColl.CompareTag("Starting Block 3"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray))
            {
                Instantiate(car3D, new Vector3(-11, -7, 18), Quaternion.Euler(0, 180, 0));
                originalPos = new Vector3(1240, 650, 5);
                carForm3 = car3D;
            }
            Destroy(yourselfFool);
        }


    }
}
