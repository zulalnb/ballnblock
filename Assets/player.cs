using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, 600 * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(600 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-600 * Time.deltaTime, 0, 0);
        }
    }
}
