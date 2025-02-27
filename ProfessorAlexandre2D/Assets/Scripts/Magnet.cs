using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    PointEffector2D magnet;
    float force;
    // Start is called before the first frame update
    void Start()
    {
        magnet = GetComponent<PointEffector2D>();   
        force = magnet.forceMagnitude; 
      
    }

    // Update is called once per frame
    void Update()
    {

         Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            transform.position = mousePos;
       magnet.enabled = Input.GetButton("Fire1") || Input.GetButton("Fire2");
       if(Input.GetButtonDown("Fire1"))
       {
            magnet.forceMagnitude = force;

       }
       if(Input.GetButtonDown("Fire2"))
       {
            magnet.forceMagnitude = -force;

       }
    }
}
