using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;    

public class WindManager : MonoBehaviour
{
    AreaEffector2D areaEffector2D;
    BoxCollider2D boxCollider;
     [SerializeField] float stateForce;
    [SerializeField] TMP_Text forceText; 
    float cooldownToChangeState;
    [SerializeField] float minCooldown, maxCooldown;
        [SerializeField] float minForce, maxForce;
    int state;
        // Start is called before the first frame update
    void Start()
    {
        areaEffector2D = GetComponent<AreaEffector2D>();
        boxCollider = GetComponent<BoxCollider2D>();
        cooldownToChangeState = 4;
        StartCoroutine(ChangeState());
    }

    // Update is called once per frame
    void Update()
    {
        print(( (areaEffector2D.forceMagnitude - minForce) / (maxForce - minForce)));
    }
    IEnumerator ChangeState()
    {   

        yield return new WaitForSeconds(cooldownToChangeState);
        cooldownToChangeState = Random.Range(minCooldown, maxCooldown);

        int lastState = state;
        while(state == lastState)
        {
             state = Random.Range(0,4);
        }
        switch(state)
        {
            case 0:
                boxCollider.enabled = false;

            break;

            case 1:
                boxCollider.enabled = true;
                areaEffector2D.forceAngle = 0;


            break;

            case 2:
                boxCollider.enabled = true;
                areaEffector2D.forceAngle = 180;

            break;
        }
       areaEffector2D.forceMagnitude = Random.Range(minForce, maxForce);




    StartCoroutine(ChangeState());


    }
}
