using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    SanidadeManager sanidadeManager;
    void Start()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.AddTorque(Random.Range(-500,500));
        sanidadeManager = FindObjectOfType<SanidadeManager>();

    }
    [SerializeField] GameObject particula;
    void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(collision.gameObject.CompareTag("FundoCopo")){
            Instantiate(particula, collision.transform.position, transform.rotation);
            Destroy(gameObject);
            CameraController cameraController = FindObjectOfType<CameraController>();
        
        if(cameraController.shakeCorroutine == null)
        {
                StopAllCoroutines();
      
        }
        
          cameraController.shakeCorroutine = cameraController.StartCoroutine(cameraController.Shake(0.3f, 0.4f));
          sanidadeManager.sanidade += Random.Range(3, 7);
          sanidadeManager.PlayCoinSound();

        }

    }
}
