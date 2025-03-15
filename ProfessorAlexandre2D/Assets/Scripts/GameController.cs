using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
 [SerializeField] AudioClip gameTheme;
    // Start is called before the first frame update
    void Start()
    {
       if(PadController.instance != null){
       PadController.CheckScenes();
       }
     
         StartCoroutine(MusicController.SetMusic(gameTheme, 1));
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
