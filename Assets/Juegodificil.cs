using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Juegodificil : MonoBehaviour
{

    public GameObject pruebabloques;
    List<GameObject> bloques;
    public Material[] mate = new Material[24];
    int cont = 0;
    public GameObject bloque1;
    public GameObject bloque2;
    public Rotar Rotar;
    public bool rotar = false;
    public int contadorclick;
    public Text tiempocont;
    public float tiempo;
    public Text contadorintentos;

    public void CompararYmas()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {

            if (Input.GetMouseButtonDown(0))
            {


                if (bloque1 == null)
                {
                    bloque1 = hit.transform.gameObject;
                    contadorclick++;
                    ActualizaUI();

                }
                else if (bloque1 != null && bloque2 == null)
                {
                    bloque2 = hit.transform.gameObject;
                    Debug.Log("entre");

                    if (bloque1 != bloque2 && bloque1.GetComponent<Renderer>().material.ToString() == bloque2.GetComponent<Renderer>().material.ToString())
                    {
                        Debug.Log("soy igual");
                        Destroy(bloque1.gameObject);
                        Destroy(bloque2.gameObject);
                    }
                    else if (bloque1 != null && bloque2 != null)
                    {
                        Debug.Log("soy null");
                        bloque1 = null;
                        bloque2 = null;
                        Invoke("Rotara", 3);

                    }


                }


            }
        }
    }
    public void OnMouseDown()
    {
        rotar = true;

        //Invoke("Rotara", 3);
        if (bloque1 != null && bloque2 != null)
        {
            Invoke("Rotara", 3);
        }
    }

    public static void shuffle(Material[] mat)
    {
        int n = mat.Length;
        while (n > 1)
        {
            n--;
            int k = Random.Range(0, n + 1);
            Material cambiador = mat[k];
            mat[k] = mat[n];
            mat[n] = cambiador;
        }
    }

    void Start()
    {
        contadorclick = 0;
        contadorintentos.text = "intentos";
        shuffle(mate);
        bloques = new List<GameObject>();
        foreach (Rotar bloque in FindObjectsOfType<Rotar>())
        {
            bloques.Add(bloque.gameObject);
            bloques[cont].GetComponent<Renderer>().material = mate[cont];
            cont += 1;
        }

        // cont = bloques.Count;
        // Debug.Log(cont);
    }

    void Update()
    {
        CompararYmas();
        TiempoContado();
        if (rotar)
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.up * 180, Time.deltaTime));
        }
        else
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.zero, Time.deltaTime));
        }
    }
    public void Rotara()
    {
        rotar = false;
    }
    public void TiempoContado()                                  // tiempo
    {
        tiempo = tiempo + 1 * Time.deltaTime;
        tiempocont.text = "" + tiempo.ToString("f0");
    }
    public void ActualizaUI()                                   // click contados 
    {
        contadorintentos.text = "intentos " + contadorclick;
    }



    /* public bool Compararbloque(GameObject bloque1 , GameObject bloque2 )
      {
          https://www.freepik.es/iconos-gratis/japon-demonio_755187.htm
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
