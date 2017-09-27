using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlMenu : MonoBehaviour {

    public string nombreDeEscena;


    void Start () {
		
	}
	
	void Update () {
		
	}

    private void OnCollisionStay(Collision collisionInfo)
    {
        SceneManager.LoadScene(nombreDeEscena);
    }
}
