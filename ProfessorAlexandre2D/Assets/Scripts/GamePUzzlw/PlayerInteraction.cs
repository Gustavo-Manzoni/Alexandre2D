using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    IInteractable interaction;
    bool canInteract;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canInteract && Input.GetKeyDown(KeyCode.E))
        {
            interaction?.Interact();


        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out IInteractable target))
        {
                interaction = target;
canInteract = true;
        }
        if(collision.TryGetComponent(out Door door))
        {


            door.prompt.SetActive(true);
        }
         if(collision.TryGetComponent(out Bomb bomb))
        {


            bomb.prompt.SetActive(true);
        }



    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out IInteractable target))
        {
            
interaction = null;
canInteract = false;

        }
if(collision.TryGetComponent(out Door door))
        {


            door.prompt.SetActive(false);
        }
         if(collision.TryGetComponent(out Bomb bomb))
        {


            bomb.prompt.SetActive(false);
        }


    }
}
