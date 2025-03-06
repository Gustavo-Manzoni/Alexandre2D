using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoVolei : MonoBehaviour
{
    Bola bola;
    [SerializeField] float speed;
    bool canJump;
    [SerializeField] float distanceToJump;
    [SerializeField] float jumpCooldown;
    [SerializeField] float jumpForce;
    Rigidbody2D rb;
    bool canMove;
    // Start is called before the first frame update
    void Start()
    {
        bola = FindObjectOfType<Bola>();
        rb = GetComponent<Rigidbody2D>();
        canJump = true;
    }

void FixedUpdate()
{
        if (canMove)
        {
            Vector2 targetPosition = new Vector2(bola.transform.position.x, transform.position.y);
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.fixedDeltaTime);
        }

    }
    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, rb.velocity.y);
        if(bola.isRight)
        {
           canMove = true;
if(bola.transform.position.y - transform.position.y < distanceToJump && canJump )
{
canJump = false;
StartCoroutine(ResetJumpCooldown());
rb.AddForce(new Vector2(0, jumpForce *  100));

}

        }else{canMove = false;}
    }
    IEnumerator ResetJumpCooldown()
    {
yield return new WaitForSeconds(jumpCooldown);
canJump = true;
    }
}
