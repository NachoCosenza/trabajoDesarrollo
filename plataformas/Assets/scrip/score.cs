using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score 
{
	static public int puntos = 0;

	void Start () 
	{
		
	}

	static public void contador(int a)
	{
		puntos = puntos + a;
		Debug.Log (puntos);
	}

	void Update () 
	{
		
	}
}
