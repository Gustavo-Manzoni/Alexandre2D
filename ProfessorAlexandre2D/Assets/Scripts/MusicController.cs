using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    static AudioSource audioSource;
    public static MusicController instance;
    // Start is called before the first frame update
    void Start()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
          audioSource = GetComponent<AudioSource>();
          instance = this;


          DontDestroyOnLoad(gameObject);
    }
    public static void SetMusic(AudioClip music)
    {
        if(audioSource.clip != music){
        audioSource.clip = music;
        audioSource.Play();
        }

    }

}
