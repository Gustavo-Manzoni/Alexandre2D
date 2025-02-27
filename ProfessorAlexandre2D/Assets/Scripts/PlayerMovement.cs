using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speedX;
    [SerializeField] float jumpStrength;
    [SerializeField] float swimStrength;
    float horizontal;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void FixedUpdate()// fisica
    {
       rb.velocity = new Vector2(horizontal * speedX, rb.velocity.y);

    }
    void Update()
    {
    horizontal = Input.GetAxisRaw("Horizontal"); 
    if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector2(0, jumpStrength * 100));
        }   
         if(Input.GetButtonDown("Fire3"))
        {
            rb.AddForce(new Vector2(0, swimStrength * -100));
        }   
    }
    void LateUpdate()
    {
        //camera 
    
    }

    
}
