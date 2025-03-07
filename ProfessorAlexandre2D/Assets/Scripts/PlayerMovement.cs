using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speedX;
    [SerializeField] float jumpStrength;
    //[SerializeField] float swimStrength;
    bool groundCheck;
    float horizontal;
    [SerializeField] Transform foot;
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
        groundCheck = Physics2D.OverlapCircle(foot.position, 0.1f );
         horizontal = Input.GetAxisRaw("Horizontal"); 
         if(Input.GetButtonDown("Jump") && groundCheck)
         {
            rb.velocity = new Vector2(rb.velocity.x, 0);
             rb.AddForce(new Vector2(0, jumpStrength * 100));
         }   
        //   if(Input.GetButtonDown("Fire3"))
        //  {
        //      rb.AddForce(new Vector2(0, swimStrength * -100));
        //  }   

    





    }
    void LateUpdate()
    {
        //camera 
    
    }

    
}
