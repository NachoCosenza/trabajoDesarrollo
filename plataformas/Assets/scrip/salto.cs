using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto : MonoBehaviour {

	int contador = 0;
	int inpulsoinicial = 44;
	int saltomaximo = 400;
	bool puedosaltar = false;
	private Rigidbody rb;



	void Start () 
	{
		rb = GetComponent<Rigidbody>();
	}
	
	void Update () 
	{
		if (puedosaltar)
		{
			/*
			if (Input.GetKey(KeyCode.Space))
			{
				contador = contador + inpulsoinicial;
				print("asdasdsadas");

				if (contador > saltomaximo)
				{
					contador = saltomaximo;
					puedosaltar = false;
				}

			}

			if (Input.GetKeyUp(KeyCode.Space))
			{
				rb.AddForce(Vector3.up * contador);
				contador = 0;
				puedosaltar = false;
			}*/

			if (Input.GetKeyUp(KeyCode.Space))
			{
				rb.AddForce(Vector3.up * saltomaximo);
				contador = 0;
				puedosaltar = false;
			}
		}
	}

	private void OnCollisionStay(Collision collisionInfo)
	{
		// salto
		puedosaltar = true;
	}
}
