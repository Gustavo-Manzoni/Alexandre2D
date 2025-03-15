using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PadController : MonoBehaviour
{

    public static PadController instance;
    static AudioSource audioSource;
    [SerializeField] string[] scenesThatICanGo;
    // Start is called before the first frame update
    void Awake()
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

    // Update is called once per frame
    void Update()
    {

    }
    public static void CheckScenes()
    {
        foreach(string scene in instance.scenesThatICanGo)
        {
            if(SceneManager.GetActiveScene().name == scene)
            {
                return;
            }
            



        }
Destroy(instance.gameObject);
    }
}
