using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    Vector3 starterScale;
    RectTransform myTransform;
    [SerializeField] float scaleMagnitude;
    // Start is called before the first frame update
    void Start()
    {
        myTransform = GetComponent<RectTransform>();
        starterScale = myTransform.localScale;
    }

    public void Enter()
    {
        myTransform.localScale = starterScale + Vector3.one * scaleMagnitude;

    }
    public void Exit()
    {

        myTransform.localScale = myTransform.localScale - Vector3.one * scaleMagnitude;
    }
}
