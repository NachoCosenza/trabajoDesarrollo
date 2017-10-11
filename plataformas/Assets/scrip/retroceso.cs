using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class retroceso : MonoBehaviour {

    private Rigidbody rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	void Update ()
    {
        //print(rb.velocity.z + " z");
        print(rb.velocity.x + " x");
       // print(rb.velocity.y + " y "  );

	}

    private void OnCollisionEnter(Collision collisionInfo)
    {
        

    }
}
