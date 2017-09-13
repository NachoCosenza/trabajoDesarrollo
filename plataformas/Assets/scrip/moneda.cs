using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneda : MonoBehaviour {
	public float velocidad;

	void Start () 
	{
		
	}
	
	void Update ()
	{
		transform.Rotate (Vector3.back * velocidad);
	}

	void OnTriggerEnter(Collider col)
	{
		print("entro al trigger");
		//Debug.Log(col.name + " has entered the trigger zone of " + this.name);
		score.contador (100);
		gameObject.SetActive (false);
	}
}
