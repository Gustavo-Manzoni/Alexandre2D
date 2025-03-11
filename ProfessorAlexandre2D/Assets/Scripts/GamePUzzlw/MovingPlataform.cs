using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlataform : MonoBehaviour
{
    [SerializeField] Transform pointA, pointB;
    [Space]
    [SerializeField] float xA, yA, xB, yB;
    [SerializeField] float speed;
    bool usingTransforms;
     Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        if(pointA != null && target == pointA.position)
        {

            usingTransforms = true;

        }else
        {
            xA += transform.position.x;
            xB += transform.position.x;
            yA += transform.position.y;
            yB += transform.position.y;

        }
        target = pointA != null ? pointA.position : new Vector3(xA, yA);
        
    }

    // Update is called once per frame
  void FixedUpdate()
  {

    transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.fixedDeltaTime);
  }
   void Update()
   {
     
        if(Vector2.Distance(transform.position, target) < 0.4f)
        {
            if(usingTransforms)
            {
                target = target != pointB.position ? pointB.position : pointA.position;   

            }else
            {

                    target = target != new Vector3(xA, yA) ? new Vector3(xA, yA) : new Vector3(xB, yB);
            }

        }


   }
   void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
