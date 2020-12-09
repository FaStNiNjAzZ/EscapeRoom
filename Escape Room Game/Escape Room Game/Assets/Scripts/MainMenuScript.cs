using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    //Variables
    public bool isEasyDifficulty = false;
    public bool isMediumDifficulty = false;
    public bool isHardDifficulty = false;

    public GameObject mainMenuCanvas;
    public GameObject difficultyCanvas;
    public GameObject difficultyCanvas1;

    void Start()
    {
        mainMenuCanvas.SetActive(true);
        difficultyCanvas.SetActive(false);
        difficultyCanvas1.SetActive(false);
    }

    

    public void PlayTestMap()
    {
        difficultyCanvas1.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    public void PlayStoryMap()
    {
        difficultyCanvas.SetActive(true);
        mainMenuCanvas.SetActive(false);
    }

    public void MainMenuScene()
    {
        SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void EasyButton()
    {
        CrossSceneVariables.isEasyDifficulty = true;
        SceneManager.LoadSceneAsync("PrisonMap", LoadSceneMode.Single);
    }

    public void MediumButton()
    {
        CrossSceneVariables.isMediumDifficulty = true;
        SceneManager.LoadSceneAsync("PrisonMap", LoadSceneMode.Single);
    }

    public void HardButton()
    {
        CrossSceneVariables.isHardDifficulty = true;
        SceneManager.LoadSceneAsync("PrisonMap", LoadSceneMode.Single);
    }

    public void EasyButton1()
    {
        CrossSceneVariables.isEasyDifficulty = true;
        SceneManager.LoadScene("PlayTestMap", LoadSceneMode.Single);
    }

    public void MediumButton1()
    {
        CrossSceneVariables.isMediumDifficulty = true;
        SceneManager.LoadScene("PlayTestMap", LoadSceneMode.Single);
    }

    public void HardButton1()
    {
        CrossSceneVariables.isHardDifficulty = true;
        SceneManager.LoadScene("PlayTestMap", LoadSceneMode.Single);
    }
}
