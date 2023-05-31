using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class IntroSequence : MonoBehaviour
{
    [SerializeField]private Animator textAnim1;
    private Animator textAnim2;

    [SerializeField]private GameObject text2;

    private float timer;

    [SerializeField] private float timerSquence1;
    [SerializeField] private float timerSquence2;
    [SerializeField] private float timerSquence3;

    private int Sequence;

    private void Update()
    {
        /*
        timer -= Time.deltaTime;
        switch(Sequence)
        {
            case 0:
                if(timer <= 0)
                {
                    timer = timerSquence1;
                    Sequence = 1;
                }
                break;
                case 1:
                if (timer <= 0)
                {
                    timer = timerSquence2;
                    Sequence = 2;
                }
                break;
            case 2:
                if (timer <= 0)
                {
                    timer = timerSquence3;
                    SceneManager.LoadScene(1);
                }
                
                break;
        }
    
        */

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(1);
        }
    }

    private void SetText2Active()
    {
        text2.SetActive(true);
        gameObject.SetActive(false);
    }

    private void NextScene()
    {
        SceneManager.LoadScene(1);
    }
}
