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
        if(Input.GetButtonDown("Fire1")){Instantiate(explosion, transform.position, transform.rotation);}
    }
}
