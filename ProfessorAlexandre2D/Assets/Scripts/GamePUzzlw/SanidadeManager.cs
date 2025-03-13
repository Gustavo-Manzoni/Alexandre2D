using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SanidadeManager : MonoBehaviour
{
    public float sanidade;
    [SerializeField]float valorDiminuirSanidade;
    [SerializeField] TMP_Text text;
    float timer;
    // Start is called before the first frame update
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
        if(timer >= 5.5f)
        {
            valorDiminuirSanidade += 0.01f;
            timer = 0;

        }
    }
}
