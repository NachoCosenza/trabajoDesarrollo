using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pj : MonoBehaviour
{

    private Rigidbody rb;
	private BoxCollider box;
	private MeshRenderer ren;
    public int fuerza;
    public int inpulsoDesendiente = 40;

	int contador = 0;
	int inpulsoinicial = 44;
	int saltomaximo = 400;
	bool puedosaltar = false;

    float contador2 = 0;
    float gravedad = 7.5f;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
		box = GetComponent<BoxCollider>();
		ren = GetComponent<MeshRenderer>();
    }

    void Update()
    {
		// gravedad

		rb.AddForce(Vector3.down * gravedad);

        // salto
        if (puedosaltar)
        {
           
        }
		

		// forma cubito
		if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector3(1F, 1, 1);
            saltomaximo = 250;

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector3.down * inpulsoDesendiente);
            }
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            saltomaximo = 400;
            transform.localScale  = new Vector3(1F, 2.5f, 1);

        }

		// forma plano

		if (Input.GetKeyDown(KeyCode.D))
		{
			transform.localScale = new Vector3(1F, 1, 0.2f);
			saltomaximo = 0;
			gravedad = 5;
		}

		if (Input.GetKeyUp(KeyCode.D))
		{
			gravedad = 7.5f;
			saltomaximo = 400;
			transform.localScale = new Vector3(1F, 2.5f, 1);
		}
    }

	private void OnCollisionStay(Collision collisionInfo)
	{
		// salto
		puedosaltar = true;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            puedosaltar = false;
            rb.AddForce(Vector3.up * saltomaximo);
        }
    }

}
