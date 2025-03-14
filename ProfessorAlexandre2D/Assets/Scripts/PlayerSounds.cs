using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSounds : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip jumpSfx, touchGroundSfx;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlaySound(AudioClip clip, float volume)
    {
       audioSource.volume = volume;
        audioSource.PlayOneShot(clip);

    }
    

}
