using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompositeBlock : MonoBehaviour
{
    [SerializeField] Vector3 maxScale, minScale;
    [SerializeField] GameObject normalBlock;
    bool goingUp = true;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        int multiplier = 1;
        if(!goingUp)
        {

            multiplier *= -1;
        }
        transform.localScale = transform.localScale + 
        new Vector3(0.02f, 0.02f) * multiplier;
        if(maxScale.magnitude < transform.localScale.magnitude)
        {

            goingUp = false;
        }
        if(minScale.magnitude > transform.localScale.magnitude)
        {

            goingUp = true;
        }
        yield return new WaitForSeconds(0.001f);
        StartCoroutine(Start());
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonUp("Fire1"))
        {
            GameObject block = Instantiate(normalBlock, transform.position, transform.rotation);
            block.transform.localScale = transform.localScale;
            block.transform.SetParent(GameObject.FindGameObjectWithTag("Composites").transform);
            CompositeManager compositeManager = FindObjectOfType<CompositeManager>();
            compositeManager.compositesLeft--;
            compositeManager.UpdateCompositeText();
            Destroy(gameObject);
          
        }
    }
}
