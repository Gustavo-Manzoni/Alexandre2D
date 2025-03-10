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
        if(transform.position.x > minX.position.x && transform.position.x < maxX.position.x)
        {
            rb.velocity = new Vector2(horizontal, 0) * speed;

        }else
        {
            rb.velocity = Vector2.zero;
        }
        // transform.position = colocar o clamp
    }
}
