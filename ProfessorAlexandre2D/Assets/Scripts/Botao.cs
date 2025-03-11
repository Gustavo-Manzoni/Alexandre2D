using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Botao : MonoBehaviour
{
  
    int howMuchIsColliding;
    float starterPos;
    public UnityEvent OnActive, OnDesactive;
    [SerializeField] float activePos;
    // Start is called before the first frame update
    void Start()
    {
        starterPos = transform.position.y;
        activePos+= transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {

        howMuchIsColliding++;
        OnActive.Invoke();
        ChangeYPos(activePos);


        
    }
     void OnTriggerExit2D(Collider2D collision)
    {
       
        howMuchIsColliding--;
        if(howMuchIsColliding == 0){
        OnDesactive.Invoke();
        ChangeYPos(starterPos);
     
        }
        

    }
    void ChangeYPos(float pos)
    {
transform.position = new Vector3(transform.position.x, pos, transform.position.z);


    }
    
    

}
