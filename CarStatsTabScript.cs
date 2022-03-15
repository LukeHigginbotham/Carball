using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CarStatsTabScript : MonoBehaviour
{
    public GameObject Target;

    Vector3 originalPos;

    public GameObject sceneNeeds;
    public GameObject sceneNeeds2;
    public GameObject sceneNeeds3;
    public GameObject sceneNeeds4;

    GameObject newBoi;
    // Use this for initialization
    void Start()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit[] hits = Physics.RaycastAll(ray);
            foreach (RaycastHit hit in hits)
            {
                if (hit.collider.gameObject.tag == "Formation Car 1")
                {
                    Target = hit.collider.gameObject;
                    GameObject formCar = GameObject.Instantiate(sceneNeeds, new Vector3(1240,650,5), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);

                }
                if (hit.collider.gameObject.tag == "Formation Car 2")
                {
                    Target = hit.collider.gameObject;
                    GameObject formCar = GameObject.Instantiate(sceneNeeds2, new Vector3(1240, 650, 5), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                }
                if (hit.collider.gameObject.tag == "Formation Car 3")
                {
                    Target = hit.collider.gameObject;
                    GameObject formCar = GameObject.Instantiate(sceneNeeds3, new Vector3(1240, 650, 5), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                }
                if (hit.collider.gameObject.tag == "Formation Car 4")
                {
                    Target = hit.collider.gameObject;
                    GameObject formCar = GameObject.Instantiate(sceneNeeds3, new Vector3(1240, 650, 5), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                }
            }
        }
    }
}
