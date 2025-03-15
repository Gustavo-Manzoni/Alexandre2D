using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SanidadeManager : MonoBehaviour
{
    public float sanidade;
    [SerializeField]float valorDiminuirSanidade;
    [SerializeField] TMP_Text text;
    float timer, timerForEachUp;
    AudioSource audioSource;
    [SerializeField]AudioClip[] getCoinClip;
    [SerializeField] AudioClip darkGetCoin;
    // Start is called before the first frame update
    void Awake()
    {
        timerForEachUp = 5.5f;
        audioSource = GetComponent<AudioSource>();
    }
    IEnumerator Start()
    {
        sanidade -= valorDiminuirSanidade;
        text.text = "Sanidade: " + sanidade.ToString("F2");
        if(sanidade <= 0)
        {
            ChangeScene.CarregarCena("Menu");

        }
        yield return new WaitForSeconds(0.01f);
        StartCoroutine(Start());
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timerForEachUp)
        {
            valorDiminuirSanidade += 0.01f;
            timer = 0;
            timerForEachUp += 1;

        }
    }
    public void PlayCoinSound()
    {
        audioSource.PlayOneShot(getCoinClip[Random.Range(0, getCoinClip.Length)]);
        audioSource.PlayOneShot(darkGetCoin);
    }
}
