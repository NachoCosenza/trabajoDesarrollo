using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class edificio : MonoBehaviour {

	public float speed = 0;
	float contador;

	void Start () {
		
	}
	
	void Update ()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        //DestroyObject(gameObject,33f);
		contador += Time.deltaTime;
		
		if (contador >= 11.0f) 
		{
			//print ("se activo");
			//gameObject.SetActive (false);
			contador = 0;
		}
    }

   void OnTriggerEnter(Collider col)
    {
        print("entro al trigger");
        Debug.Log(col.name + " has entered the trigger zone of " + this.name);

		DestroyObject(gameObject,3f);
           // this.gameObject.SetActive(false);
            print("se apaga");
        

            
    }
    
    
}
