using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    public bool isRight;
    [SerializeField] Transform center;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isRight = transform.position.x < center.position.x ? false : true;
    }
}
