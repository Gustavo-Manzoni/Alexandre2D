using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
  
    public void SceneLoad(string sceneName)
    {
        SceneManager.LoadScene(sceneName);


    }
    public void SceneLoad(int sceneID)
    {
        SceneManager.LoadScene(sceneID);


    }
   
}
