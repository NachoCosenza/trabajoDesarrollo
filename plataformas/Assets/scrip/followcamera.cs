    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour {

	public Transform jugador;
		

	void Start () 
	{
		jugador = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	void Update ()
	{
		transform.position = transform.TransformVector (jugador.position.x,jugador.position.y,-10);
	}
}
