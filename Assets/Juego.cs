using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    public GameObject pruebabloques;
    List<GameObject> bloques;
    public Material [] mate = new Material [16];
    int cont = 0;
    public bool rotar = false;
    

    public void OnMouseDown()
    {
        
    }
    


    public static void shuffle(Material [] mat)
    {
        int n = mat.Length;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0,n+1);
            Material cambiador= mat[k];
            mat[k] = mat[n];
            mat[n] = cambiador;
        }
    }




    void Start()
    {
        shuffle(mate);
       bloques = new List<GameObject>();
       foreach (Rotar bloque in FindObjectsOfType<Rotar>())
       {
           bloques.Add(bloque.gameObject);
           bloques[cont].GetComponent<Renderer>().material = mate[cont];
           cont += 1;
       }
    }

   
    void Update()
    {
        
    }
   
    
}
