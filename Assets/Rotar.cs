using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotar : MonoBehaviour
{
    public bool rotar = false;

    public void OnMouseDown()
    {
        rotar = true;
        Invoke( "rotara", 5);
    }
        void Start()
    {
        
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
}
