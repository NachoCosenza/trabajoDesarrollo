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
	float inpulsoinicial = 44;
	float saltomaximo = 6.3f;
	bool puedosaltar = false;

    float contador2 = 0;
    float gravedad = 7.5f;

    bool salto = false;
    bool saltando = false;



    void Awake()
    {
        rb = GetComponent<Rigidbody>();
		box = GetComponent<BoxCollider>();
		ren = GetComponent<MeshRenderer>();
    }

    void Update()
    {
		// gravedad

		

        // salto
        
        
        // forma cubito
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.localScale = new Vector3(1F, 1, 1);
            saltomaximo = 3.5f;

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector3.down * inpulsoDesendiente);
            }
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            saltomaximo = 6.3f;
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
			saltomaximo = 6.3f;
			transform.localScale = new Vector3(1F, 2.5f, 1);
		}

        if (!saltando)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                salto = true;
                saltando = true;
            }
        }


    }

    void FixedUpdate()
    {

       

        rb.AddForce(Vector3.down * gravedad);

        if (salto && !saltando)
        {
            rb.AddForce(Vector3.up * saltomaximo, ForceMode.Impulse);
            salto = false;
            saltando = true;
            print("salto");
        }

        //rb.AddForce(Vector3.down);
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        // salto
        saltando = false;
        print ("hola"); 
    }

   



}
