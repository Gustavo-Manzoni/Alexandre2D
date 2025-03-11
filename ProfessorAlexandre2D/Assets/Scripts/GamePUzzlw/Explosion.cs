using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] float timeToDesactive; 
    // Start is called before the first frame update
    IEnumerator Start()
    {  
         yield return new WaitForSeconds(timeToDesactive);
         gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
