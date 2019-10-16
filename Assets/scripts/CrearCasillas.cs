using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearCasillas : MonoBehaviour
{
    public GameObject Bloque;
    public int ancho;
   
    public List<GameObject> bloques = new List<GameObject>();

    public Material[] material;
    public int contadorclik;
    public Text clicks;


    void Start()
    {
        Crear();
    }

    public void Crear()
    {
        int cont = 0;
        for (int i = 0; i < ancho; i++)
        {
            for (int x = 0; x < ancho; x++)
            {
                GameObject bloquestemp = Instantiate(Bloque, new Vector3(x, i, 0), Quaternion.identity);
                bloques.Add(bloquestemp);



                bloquestemp.GetComponent<Bloque>().posicionoriginal = new Vector3(x, i, 0);
                bloquestemp.GetComponent<Bloque>().NumCarta = cont;
                cont++;
            }
        }
        Asignarmaterial();
        Randombloques();
    }

    void Asignarmaterial ()
    {
        for (int i = 0;i < bloques.Count; i++)
        {
            bloques[i].GetComponent<Bloque>().PonerColor(material[i / 2]);
        }
    }
    void Randombloques()
    {
        int aleatorio;
        for (int i = 0; i < bloques.Count; i++)
        {
            aleatorio = Random.Range(i, bloques.Count);

            bloques[i].transform.position = bloques[aleatorio].transform.position;
            bloques[aleatorio].transform.position = bloques[i].GetComponent<Bloque>().posicionoriginal;

            bloques[i].GetComponent<Bloque>().posicionoriginal = bloques[i].transform.position;
            bloques[aleatorio].GetComponent<Bloque>().posicionoriginal = bloques[aleatorio].transform.position;
        }
    }

  /* public void hacercli()
    {
        contadorclik++;
        actualizadorUi();
    }
    public void actualizadorUi()
    {
        clicks.text = "intentos " + contadorclik;
    }*/
    
    void Update()
    {
        
    }
}
