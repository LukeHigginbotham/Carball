using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RLCarControls: MonoBehaviour
{
     public int speed;
     private Rigidbody rb;
    public int jumpSpeed;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.up * jumpSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.left * speed);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().AddRelativeForce(Vector3.right * speed);
        }
      
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Turn(false);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Turn(true);
        }

    }

    void Turn(bool isClockwise)
    {
        int rotationDegrees = 3;
        if (isClockwise == false)
            rotationDegrees = rotationDegrees * -1;

        transform.Rotate(new Vector3(0, 1, 0), rotationDegrees);
    }
}
