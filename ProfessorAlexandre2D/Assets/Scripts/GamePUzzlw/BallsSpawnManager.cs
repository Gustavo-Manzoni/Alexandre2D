using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsSpawnManager : MonoBehaviour
{
    [SerializeField] float cooldownForEachBall;
    [SerializeField] float cooldownToStart;
    [SerializeField] GameObject[] balls;
    [SerializeField] Transform minX, maxX;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(cooldownToStart);
        cooldownToStart = 0;
        yield return new WaitForSeconds(cooldownForEachBall);
        Instantiate(balls[Random.Range(0, balls.Length)], new Vector3(Random.Range(minX.transform.position.x, maxX.transform.position.x), minX.transform.position.y), transform.rotation);
        StartCoroutine(Start());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
