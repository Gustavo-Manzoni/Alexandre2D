using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float timeToDestroy; 
    // Start is called before the first frame update
    IEnumerator Start()
    {  
         yield return new WaitForSeconds(timeToDestroy);
         Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
