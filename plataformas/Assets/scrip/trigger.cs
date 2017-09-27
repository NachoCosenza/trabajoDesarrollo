using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class trigger : MonoBehaviour {

    public string nombreDeEscena;


    void Start () {
		
	}
	
	void Update () {
		
	}


    void OnTriggerEnter(Collider col)
    {
        print("entro al trigger");
        Debug.Log(col.name + " has entered the trigger zone of " + this.name);

        if (col.CompareTag("jugador"))
        {
           // gameObject.SetActive(false);
            print("se apaga");

            SceneManager.LoadScene(nombreDeEscena);
        }


    }
}
