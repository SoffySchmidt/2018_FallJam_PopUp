using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSides : MonoBehaviour {
    public Rigidbody rb;
    public float sidewaysForce;

    public float moreGravity;
	
	void FixedUpdate ()
    {

        rb.AddForce(0, -moreGravity * Time.deltaTime, 0);

		if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
    }
}
