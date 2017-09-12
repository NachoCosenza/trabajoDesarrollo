using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntuacion : MonoBehaviour {

	public Text valorAmostrar;
	float timer = 0;

	void Start () 
	{
		
	}
	
	void Update () 
	{

		timer = timer + Time.deltaTime;

		if (timer > 0.5f) 
		{
			score.contador (1);
			timer = 0;
		}

		valorAmostrar.text = score.puntos.ToString ();
	}
}
