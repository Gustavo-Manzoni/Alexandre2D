using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CompositeManager : MonoBehaviour
{
    [SerializeField] GameObject compositeBlock;
    public int compositesLeft;
    [SerializeField] TMP_Text compositesLeftTxt;
    // Start is called before the first frame update
    void Start()
    {
        UpdateCompositeText();
    }
    public void UpdateCompositeText()
    {
        compositesLeftTxt.text = "Blocos Restantes: " + compositesLeft.ToString();

    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && compositesLeft > 0)
        {
            Instantiate(compositeBlock, (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition), transform.rotation);


        }
    }
    
}
