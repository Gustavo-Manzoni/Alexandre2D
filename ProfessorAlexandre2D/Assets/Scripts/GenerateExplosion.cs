using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateExplosion : MonoBehaviour
{
    [SerializeField] GameObject explosion;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {  
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;

            Instantiate(explosion, mousePos, transform.rotation);
        
        
        
        }
    }
}
