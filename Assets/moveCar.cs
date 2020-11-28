using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCar : MonoBehaviour
{
    private Rigidbody rb;
    const int speed = 5000;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        if (Input.GetKey("w")) { 
            // rb.AddForce(0, 0, speed * Time.deltaTime);
            rb.AddRelativeForce(0, 0, speed * Time.deltaTime);
        }

        if(Input.GetKey("s")) {
            rb.AddRelativeForce(0, 0, -1 * speed * Time.deltaTime);
        }
        if(Input.GetKey("a")) {
            transform.Rotate(0, -2, 0);
        }
        if(Input.GetKey("d")) {
            transform.Rotate(0, 2, 0);
        }

    }
}
