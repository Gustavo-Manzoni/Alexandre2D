using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] GameObject particula;
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.CompareTag("FundoCopo")){
            Instantiate(particula, collision.transform.position, transform.rotation);
        Destroy(gameObject);
        }

    }
}
