using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string FirstScenetoPlay;

    public void Play()
    {
        SceneManager.LoadScene(FirstScenetoPlay);
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void BacktoMainMenu()
    {

        SceneManager.LoadScene("MainMenu");
    }
}
