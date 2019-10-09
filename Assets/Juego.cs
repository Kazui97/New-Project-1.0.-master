using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Juego : MonoBehaviour
{
    public int varx;
    public int vary;
    public GameObject buey;
    public GameObject palomo;
    public GameObject mono;
    public GameObject dragon;
    public GameObject [,]gameObjects;


    void Start()
    {
        /*gameObjects = new GameObject[varx , vary];
        for (int x = 0; x < varx; x++)
        {
            for (int y = 0; y < vary; y++)
            {
                GameObject buuey = GameObject.Instantiate(buey) as GameObject;
                Vector3 position = new Vector3(x,y,0);
                buuey.transform.position = position;
                gameObjects[x,y]=buuey;
              
            }
        }*/

        int cambio = Random.Range(0,5)
        switch (switch_on)
        {
            
            default:
        }





    }

    
    void Update()
    {
        
    }
}
