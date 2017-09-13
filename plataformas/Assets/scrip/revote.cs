using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revote : MonoBehaviour
{
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {

    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        rb.AddForce(Vector3.forward * 8000);
        print("hola");
    }
}