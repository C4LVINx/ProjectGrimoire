using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroNoteBookText : MonoBehaviour
{
    [SerializeField] private GameObject nextText;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            nextText.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
