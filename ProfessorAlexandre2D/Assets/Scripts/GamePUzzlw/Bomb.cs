using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour, IInteractable
{
    [SerializeField] float secondsToExplode;
    [SerializeField] GameObject explosion, explosionCollider, bombExplosionSound;
    [SerializeField]public  GameObject prompt;
    Rigidbody2D rb;
    [SerializeField] float maxSpeed;
    Animator anim;
    AudioSource audioSource;
    [SerializeField] AudioClip startExplosion;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    rb = GetComponent<Rigidbody2D>();
    audioSource = GetComponent<AudioSource>();

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
        audioSource.PlayOneShot(startExplosion);
         yield return new WaitForSeconds(secondsToExplode);
Explosion();
    }
    public void Explosion()
    {

        Instantiate(explosion, transform.position, Quaternion.Euler(0,0,0));
        Instantiate(explosionCollider, transform.position, transform.rotation);
        Instantiate(bombExplosionSound, transform.position, transform.rotation);
        Destroy(gameObject);
        CameraController cameraController = FindObjectOfType<CameraController>();
        cameraController.StartCoroutine(cameraController.Shake(0.3f, 0.4f));
    }
    void OnCollisionStay2D(Collision2D collision)
    {
        if(rb.velocity.x > maxSpeed)
        {
            rb.velocity = new Vector3(maxSpeed,rb.velocity.y);

        }


    }
}
