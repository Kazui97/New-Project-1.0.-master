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
    public GameObject bloque1;
    public GameObject bloque2;
    

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

        cont = bloques.Count;
        Debug.Log(cont);
    }

   
    void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, Mathf.Infinity))
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("ledi raycast");
                if (bloque1 == null)
                {
                    bloque1 = gameObject.GetComponent<Juego>().bloques.Equals(mat[].ToString);
                    Debug.Log("entre aqui >:v");
                }
            }
        }

    }
  /* public bool Compararbloque(GameObject bloque1 , GameObject bloque2 )
    {
        bool resultado;
        if(bloque1.GetComponent<Juego>().bloques.ToString == bloque2.GetComponent<Juego>().bloques.ToString)
        {
            resultado = true;
        }
        else
        {
            resultado = false;
        }
    }*/
    
}
