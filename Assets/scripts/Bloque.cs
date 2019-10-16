using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{
    public int NumCarta = 0;
    public Vector3 posicionoriginal;
    public Material mostramdobloque;
    public bool rotar = false;
    public bool mostrando;
   // public CrearCasillas CrearCasillas;

    public void OnMouseDown()
    {
        print(NumCarta.ToString());
        rotar = true;
        //Invoke("rotara", 5);
        Mostrabloque();
    }
    
    public void PonerColor(Material _material)
    {
        mostramdobloque = _material;
    }
    public void Mostrabloque()
    {
        if (!mostrando)
        {
            mostrando = true;
            // CrearCasillas.hacercli();
            GetComponent<MeshRenderer>().material = mostramdobloque;
            Invoke("rotara", 5);
        }
    }
    public void rotara()
    {
        mostrando = false;
        rotar = false;
    }
    void Start()
    {
        
    }



    void Update()
    {
        if (rotar)
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.up * 180, Time.deltaTime));
        }
        else
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.zero, Time.deltaTime));
        }
    }
   
}
