using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quits");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Game Starts a new!");
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(1);
    }
    public void BackToIntro()
    {
        SceneManager.LoadScene(0);
    }

    public void RollCredits()
    {
        SceneManager.LoadScene(3);
    }
}
