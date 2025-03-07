using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
 [SerializeField] AudioClip gameTheme;
    // Start is called before the first frame update
    void Start()
    {
        #if UNITY_EDITOR
        if(MusicController.instance){
        MusicController.SetMusic(gameTheme);
        }
        
        #endif
         MusicController.SetMusic(gameTheme);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
