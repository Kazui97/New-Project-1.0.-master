using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaRaycast : MonoBehaviour
{
    
    void Start()
    {
        
    }

   
    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray,out hit, Mathf.Infinity))
        {
            if (Input.GetMouseButtonDown(0))
            {
                print("le di");
                Debug.DrawRay(transform.position, ray.direction, Color.yellow);
            }
           
        }
       /* if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
            {

            }
        }*/
    }
}
