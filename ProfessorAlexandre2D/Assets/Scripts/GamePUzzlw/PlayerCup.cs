using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCup : MonoBehaviour
{
    [SerializeField] Transform minX, maxX;
     [SerializeField] float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        
            rb.velocity = new Vector2(horizontal, 0) * speed;

         float newXPos = Mathf.Clamp(transform.position.x,minX.transform.position.x, maxX.transform.position.x);
         transform.position = new Vector2(newXPos, transform.position.y);
    }
    
}
