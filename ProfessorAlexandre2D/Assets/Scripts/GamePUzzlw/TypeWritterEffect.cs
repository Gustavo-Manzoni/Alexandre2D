using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TypeWritterEffect : MonoBehaviour
{
    [SerializeField] float timePerLetter;

    // Start is called before the first frame update
    IEnumerator Start()
    {
        TMP_Text text = GetComponent<TMP_Text>();
        char[] letters = text.text.ToCharArray();
        text.text = "";
        for(int i = 0; i < letters.Length; i++)
        {
            text.text += letters[i];
yield return new WaitForSeconds(timePerLetter);

        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
