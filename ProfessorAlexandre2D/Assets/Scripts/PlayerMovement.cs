using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    [SerializeField] float speedX;
    [SerializeField] float jumpStrength;
    bool lookingRight;
     float horizontal;
    [SerializeField] Transform foot;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void FixedUpdate()// fisica
    {
       
       rb.velocity = new Vector2(horizontal * speedX, rb.velocity.y);
        

    }
    void Update()
    {

       horizontal = Input.GetAxisRaw("Horizontal"); 
        bool groundCheck = Physics2D.OverlapCircle(foot.position, 0.1f );
    


         anim.SetInteger("Speed", (int)horizontal);
         anim.SetBool("OnGround", groundCheck);

          if(Input.GetButtonDown("Jump") && groundCheck)
         {
            rb.velocity = new Vector2(rb.velocity.x, 0);
             rb.AddForce(new Vector2(0, jumpStrength * 100));
            
         }   
    
        Flip();

    }
    void LateUpdate()
    {
        //camera 
    
    }
    void Flip()
    {
        if(lookingRight && horizontal < 0 || !lookingRight && horizontal > 0)
        {
            lookingRight = !lookingRight;
            Vector3 newScale = transform.localScale;
            newScale.x *= -1;
            transform.localScale = newScale;


        }

    }

    
}
