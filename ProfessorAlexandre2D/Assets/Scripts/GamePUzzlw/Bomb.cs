using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IInteractable
{
    [SerializeField] float secondsToExplode;
    [SerializeField] GameObject explosion, explosionCollider;
    [SerializeField] GameObject prompt;
    Rigidbody2D rb;
    [SerializeField] float maxSpeed;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    rb = GetComponent<Rigidbody2D>();

        prompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Interact()
    {
StartCoroutine(StartExplosion());

    }
    IEnumerator StartExplosion()
    {
       
        anim.SetBool("Explode", true);
         yield return new WaitForSeconds(secondsToExplode);
Explosion();
    }
    public void Explosion()
    {

        Instantiate(explosion, transform.position, Quaternion.Euler(0,0,0));
        Instantiate(explosionCollider, transform.position, transform.rotation);
        Destroy(gameObject);
        CameraController cameraController = FindObjectOfType<CameraController>();
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if(rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector3(maxSpeed,rb.velocity.y);

        }


    }
}
