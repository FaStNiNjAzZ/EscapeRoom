using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    //Variables
    public bool isEasyDifficulty = false;
    public bool isMediumDifficulty = false;
    public bool isHardDifficulty = false;

    public GameObject mainMenuCanvas;
    public GameObject difficultyCanvas;

    void Start()
    {
        mainMenuCanvas.SetActive(true);
        difficultyCanvas.SetActive(false);
    }

    public void PlayTestMap()
    {
        difficultyCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    public void MainMenuScene()
    {
        SceneManager.LoadScene("Menu", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void EasyButton()
    {
        CrossSceneVariables.isEasyDifficulty = true;
        SceneManager.LoadScene("PlayTestMap", LoadSceneMode.Single);
    }

    public void MediumButton()
    {
        CrossSceneVariables.isMediumDifficulty = true;
        SceneManager.LoadScene("PlayTestMap", LoadSceneMode.Single);
    }

    public void HardButton()
    {
        CrossSceneVariables.isHardDifficulty = true;
        SceneManager.LoadScene("PlayTestMap", LoadSceneMode.Single);
    }
}
