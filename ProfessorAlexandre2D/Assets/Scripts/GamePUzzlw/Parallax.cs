using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length; // Comprimento do sprite
    private float startPos; // Posição inicial
    [SerializeField] private float speed; // Velocidade do efeito

    private void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        // Move o fundo para a esquerda
        transform.Translate(Vector3.left * speed * 3.5f * Time.deltaTime);

        // Se o fundo saiu totalmente da tela, reposiciona ele para a frente
        if (transform.position.x <= startPos - length)
        {
            transform.position = new Vector3(startPos, transform.position.y, transform.position.z);
        }
    }
}
