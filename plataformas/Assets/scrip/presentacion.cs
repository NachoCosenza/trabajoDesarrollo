using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class presentacion : MonoBehaviour {

    float contador = 0;
    public Text uno;
    public Text dos;
    public Text tres;
    public Text go;


    void Start ()
    {
		
	}
	
	void Update ()
    {
        contador = contador + Time.deltaTime;

        if (contador > 0.5f)
        {
            tres.gameObject.SetActive(true);
                        
        }

        if (contador > 1f)
        {
            dos.gameObject.SetActive(true);
            tres.gameObject.SetActive(false);
        }

        if (contador > 1.5f)
        {
            uno.gameObject.SetActive(true);
            dos.gameObject.SetActive(false);
        }

        if (contador > 2f)
        {
            go.gameObject.SetActive(true);
           uno.gameObject.SetActive(false);

        }

        if (contador > 2.5f)
        {
            go.gameObject.SetActive(false);

        }

    }
}
