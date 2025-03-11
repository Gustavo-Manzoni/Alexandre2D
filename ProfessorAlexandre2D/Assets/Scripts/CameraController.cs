using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float starterSize;
    public Coroutine shakeCorroutine;
    // Start is called before the first frame update
    void Start()
    {
        starterSize = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public IEnumerator Shake(float shakeDuration, float targetSize)
    {
        float pastCorroutineSize = Camera.main.orthographicSize;
        float elapsed = 0;
        targetSize = pastCorroutineSize + targetSize;
        while(elapsed < shakeDuration/2)
        {

            Camera.main.orthographicSize = Mathf.Lerp(pastCorroutineSize, targetSize, elapsed / shakeDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }
         Camera.main.orthographicSize = targetSize;
        elapsed = 0;
        pastCorroutineSize = targetSize;
        while (elapsed < shakeDuration/2)
        {

            Camera.main.orthographicSize = Mathf.Lerp(pastCorroutineSize, starterSize, elapsed / shakeDuration);
            elapsed += Time.deltaTime;
            yield return null;
        }
         Camera.main.orthographicSize = starterSize;
 
    }
}
