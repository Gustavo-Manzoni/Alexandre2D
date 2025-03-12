using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedLimit : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]float maxXSpeed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2( Mathf.Clamp(rb.velocity.x,-maxXSpeed, maxXSpeed ), rb.velocity.y);
    }
}
