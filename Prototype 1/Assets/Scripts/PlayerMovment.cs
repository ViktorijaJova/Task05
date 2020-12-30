using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 45.0f;
    private float hortizontalInput;
    private float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moving left and right
        hortizontalInput = Input.GetAxis("Horizontal");
        //moving forward and back
        forwardInput = Input.GetAxis("Vertical");


        //same
        // transform.Translate(0, 0, 1);  
        //move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward* Time.deltaTime* speed * forwardInput);
        //  transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * hortizontalInput);

        //rotationg the vehicle based on horizontal input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * hortizontalInput);
    }
}
