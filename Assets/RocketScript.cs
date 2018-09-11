using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketScript : MonoBehaviour {

    Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        ProcessInput();
		
	}

    private void ProcessInput()
    {
        if (Input.GetKey(KeyCode.Space))
        { 
            rigidBody.AddRelativeForce(Vector3.up); //makes ship go up look at mass in inspector 

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward); //stick your left thumb towards (forward) the screen notice
                                               // fingers curled around anti clockwise ie to the left 
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward); //thumb towards yourslef notice fingers curled round clockwise 
                                              // ie 'right' Vector 3 is your thumb ie Z axis
        }

    }
}
