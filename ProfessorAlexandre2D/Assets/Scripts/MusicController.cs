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
    public static IEnumerator SetMusic(AudioClip music, float timeToChangeMusic)
    {
        float starterVolume = audioSource.volume;
        float elapsed = 0;
        while(elapsed < timeToChangeMusic )
        {
            audioSource.volume = Mathf.Lerp(starterVolume, 0, elapsed / timeToChangeMusic);
            elapsed+= Time.deltaTime;
            yield return null;
        }
        audioSource.clip = music;
        audioSource.Play();
        elapsed = 0;
        while(elapsed < timeToChangeMusic )
        {
            audioSource.volume = Mathf.Lerp(0, 1,elapsed / timeToChangeMusic    );
           elapsed+= Time.deltaTime;
            yield return null; 
        }

    }

}
