using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class uibuttons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
    }

    public void QuitGame()
    {
        Debug.Log("OYUNDAN ÇIKTIK");
        Application.Quit();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}

