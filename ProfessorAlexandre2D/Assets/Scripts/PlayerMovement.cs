using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
    PlayerSounds playerSounds;
    bool canPlayTouchGroundSfx;
    void Start()
    {
        canPlayTouchGroundSfx = true;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        playerSounds = GetComponent<PlayerSounds>();
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
if(rb.velocity.y < -2f && groundCheck &&canPlayTouchGroundSfx)
{
    playerSounds.PlaySound(playerSounds.touchGroundSfx, 0.75f);
    canPlayTouchGroundSfx = false;
    StartCoroutine(ResetSfxCooldown());
}

          if(Input.GetButtonDown("Jump") && groundCheck)
         {
            rb.velocity = new Vector2(rb.velocity.x, 0);
             rb.AddForce(new Vector2(0, jumpStrength * 100));
            playerSounds.PlaySound(playerSounds.jumpSfx, 0.35f);
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
    void OnTriggerEnter2D(Collider2D collision)
    {
            if(collision.gameObject.CompareTag("Lose"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                
            }


    }
    IEnumerator ResetSfxCooldown()
    {
        yield return new WaitForSeconds(0.5f);
        canPlayTouchGroundSfx = true;

    }
    

    
}
