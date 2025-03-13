using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuiceDispencer : MonoBehaviour
{
    [SerializeField] GameObject ball;
    SpriteRenderer spriteRenderer;
 [SerializeField] float cooldownForEachBall;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    
    void OnMouseDown()
    {
        StartCoroutine(StartDroppingBalls());

    }
    void OnMouseUp()
    {
            StopAllCoroutines();


    }
    IEnumerator StartDroppingBalls()
    {
        Instantiate(ball, new Vector2(Random.Range(transform.position.x - spriteRenderer.bounds.size.x/2, transform.position.x + spriteRenderer.bounds.size.x/2), transform.position.y), transform.rotation);
        yield return new WaitForSeconds(cooldownForEachBall);
        StartCoroutine(StartDroppingBalls());
    }
}
