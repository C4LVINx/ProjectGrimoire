using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueSystem : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject visualcue;

    [Header("INK")]
    [SerializeField] private TextAsset INK;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        visualcue.SetActive(false);
    }

    

    // Update is called once per frame
    void Update()
    {
        if (playerInRange)
        {
            visualcue.SetActive(true);
            if (InputManager.GetInstance().GetInteractPressed)
            {
                Debug.Log(INK)
            }
        }
        else
        {
            visualcue.SetActive(false);  
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)

}
