using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{
    public GameObject prompt;
    [SerializeField] string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        prompt.SetActive(false);
    }

   
    public void Interact()
    {
        ChangeScene.CarregarCena(sceneName);

    }
}
