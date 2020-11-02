using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayTestMap()
    {
        SceneManager.LoadScene("PlayTestMap", LoadSceneMode.Single);
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
