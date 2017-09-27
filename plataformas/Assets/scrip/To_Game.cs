using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class To_Game : MonoBehaviour 
{
	public string nombreDeEscena;

	public void AlaEscena()
	{
		Debug.Log ("funciona");
		SceneManager.LoadScene (nombreDeEscena);
	}
}
