using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pj : MonoBehaviour
{

    private Rigidbody rb;
    private BoxCollider box;
    private MeshRenderer ren;
    public int fuerza;
    public int inpulsoDesendiente = 28;

    int contador = 0;
    float inpulsoinicial = 44;
    float saltomaximo = 6.3f;
    bool puedosaltar = false;

    float contador2 = 0;
    float gravedad = 7.5f;

    bool salto = false;
    bool saltando = false;
    int cont = 0;



    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        box = GetComponent<BoxCollider>();
        ren = GetComponent<MeshRenderer>();
    }


    void Update()
    {

        if (!saltando)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                salto = true;
                saltando = true;
            }
        }

    }

    void FixedUpdate()
    {
        FormaCubo();
        FormaPlano();
        FormaNormal();

        rb.AddForce(Vector3.down * gravedad);
        

        if ((salto && !saltando))
        {
            salto = false;
            saltando = false;
            rb.AddForce(Vector3.up * saltomaximo, ForceMode.Impulse);
           
           
        }

        
    }

    private void OnCollisionStay(Collision collisionInfo)
    {
        
        // salto
       salto = true;
       saltando = false;
       // print("asd");

    }

    public void FormaCubo()
    {
        if (Input.GetKey(KeyCode.S))
        {
            transform.localScale = new Vector3(1F, 1, 1);
            saltomaximo = 3.5f;

            if (Input.GetKey(KeyCode.S))
            {
                rb.AddForce(Vector3.down * inpulsoDesendiente);
            }
        }

        
    }

    public void FormaPlano()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.localScale = new Vector3(1F, 1, 0.2f);
            saltomaximo = 0;
            gravedad = 5;
        }

        
    }


    public void FormaNormal()
    {
        if (Input.GetKey(KeyCode.A))
        {
            gravedad = 7.5f;
            saltomaximo = 6.3f;
            transform.localScale = new Vector3(1F, 2.5f, 1);
        }


    }
}
