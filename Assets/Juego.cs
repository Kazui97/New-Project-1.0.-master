using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    public GameObject pruebabloques;
    public Material buey;
    public Material dragon;
    public Material palomo;
    public Material cabeza;
    public Material hombre;
    public Material hombre1;
    public Material palomo1;
    
    public GameObject selecio1;
    public GameObject selecio2;
    public static  int[] array =new int[8];
    
    public bool rotar = false;
    

    public void OnMouseDown()
    {
        rotar = true;
        Invoke( "rotara", 5);
        if ( selecio1.gameObject.GetComponent<Juego>().buey == pruebabloques.GetComponent<Juego>().buey)
        {
            Destroy(selecio1);
            Destroy(selecio2);
        }
        
    }
    

    void Awake()
    {
        caritas = (caras)Random.Range(0,6);
    }
    void Start()
    {
        
        //int carasrandom = Random.Range(0,5);
        switch (caritas)
        {
            case caras.buey:
            pruebabloques.GetComponent<Renderer>().material = buey;
            
            break;
            case caras.dragon:
            pruebabloques.GetComponent<Renderer>().material = dragon;
            break;
            case caras.palomo:
            pruebabloques.GetComponent<Renderer>().material = palomo;
            break;
            case caras.cabeza:
            pruebabloques.GetComponent<Renderer>().material = cabeza;
            break;
            case caras.hombre:
            pruebabloques.GetComponent<Renderer>().material = hombre;
            break;
            case caras.hombre1:
            pruebabloques.GetComponent<Renderer>().material = hombre1;
            break;
            case caras.palomo1:
            pruebabloques.GetComponent<Renderer>().material = palomo1;
            break;
            default:
            break;
        }
    }

   
    void Update()
    {
        if (rotar)
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.up *180, Time.deltaTime));
        }
        else
        {
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, Vector3.zero, Time.deltaTime));
        }
    }
    public void rotara()
    {
        rotar = false;
    }
    public enum caras
    {
        buey,
        dragon,
        palomo,
        cabeza,
        hombre,
        hombre1,
        palomo1
    }
    public caras caritas;
}
