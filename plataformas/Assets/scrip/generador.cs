using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generador : MonoBehaviour {

    public GameObject edificio;
    public Transform salida;
    int indice = 0;
    public GameObject[] edificios;
    public Vector3 lugar;
    float spaun = 10.5f;

    

    float contador = 10.5f;

    void Start ()
    {
        //edificios = GameObject.FindGameObjectsWithTag("level");

    }

    void Update ()
    {
        //Debug.Log("Player Number " + i + " is named " + players[i].name);
        //float a = Random.Range(-1f, 0f);
        //float b = Random.Range(-10f, -5f);
        contador += Time.deltaTime;

        //print(contador);

        if (contador >= spaun)
        {
			
            indice = Random.Range(0, edificios.Length);
			//edificios [indice].SetActive (true);
			Instantiate(edificios[indice], lugar, salida.rotation);
            contador = 0;

        }
        
	}

    // 
}
