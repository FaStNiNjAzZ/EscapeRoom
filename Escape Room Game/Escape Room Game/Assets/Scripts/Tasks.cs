using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tasks : MonoBehaviour
{
    //Game Objects
    //Objects relating to button o tron
    public GameObject buttonOTronButtonGameObject1;
    public GameObject buttonOTronButtonGameObject2;
    public GameObject buttonOTronButtonGameObject3;

    public GameObject tickTask1;
    public GameObject crossTask1;

    //Objects relating to power level
    public Slider powerLevelSlider;

    public GameObject tickTask2;
    public GameObject crossTask2;

    //Objects relating to power switches
    public Slider powerSwitchSlider;
    public GameObject powerSwitchonOffIndicator;

    public GameObject tickTask3;
    public GameObject crossTask3;

    //Objects relating to shield activation
    public GameObject shieldButton;

    public GameObject tickTask4;
    public GameObject crossTask4;


    //Variables
    //Variables relating to button o tron
    bool buttonOTronButtonPressed1 = false;
    bool buttonOTronButtonPressed2 = false;
    bool buttonOTronButtonPressed3 = false;
    bool buttonOTronButtonTaskCompleted = false;

    //Variables relating to power level
    bool powerLevelTaskCompleted = false;

    //Variables relating to power switch
    bool powerSwitchTaskCompleted = false;

    //Variables relating to shield button
    bool shieldTaskCompleted = false;

    // Start is called before the first frame update
    void Start()
    {
        powerSwitchSlider.value = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        //If statements for button o tron
        if (buttonOTronButtonPressed1 == true && buttonOTronButtonPressed2 == true && buttonOTronButtonPressed3 == true)
        {
            buttonOTronButtonTaskCompleted = true;
            tickTask1.SetActive(true);
            crossTask1.SetActive(false);
        }

        //If statements for power switch
        if (powerSwitchSlider.value == 1f)
        {

            tickTask3.SetActive(true);
            crossTask3.SetActive(false);
            powerSwitchonOffIndicator.GetComponent<Image>().color = Color.green;
            powerSwitchTaskCompleted = true;
        }

        else //if (powerSwitchSlider.value != 1f)
        {

            tickTask3.SetActive(false);
            crossTask3.SetActive(true);
            powerSwitchonOffIndicator.GetComponent<Image>().color = Color.red;
            powerSwitchTaskCompleted = false;
        }

        //If statements to check if the player has done all the tasks
        if (powerLevelTaskCompleted == true && powerSwitchTaskCompleted == true && buttonOTronButtonTaskCompleted == true && shieldTaskCompleted == true)
        {

        }

    }

    //Button-O-Tron Task script
    public void ButtonOTronButton1()
    {
        buttonOTronButtonPressed1 = true;
        buttonOTronButtonGameObject1.GetComponent<Image>().color = Color.green;
    }

    public void ButtonOTronButton2()
    {
        buttonOTronButtonPressed2 = true;
        buttonOTronButtonGameObject2.GetComponent<Image>().color = Color.green;
    }

    public void ButtonOTronButton3()
    {
        buttonOTronButtonPressed3 = true;
        buttonOTronButtonGameObject3.GetComponent<Image>().color = Color.green;
    }

    public void TurnOffShieldButton()
    {
        shieldTaskCompleted = true;
        shieldButton.GetComponent<Image>().color = Color.red;
        tickTask4.SetActive(true);
        crossTask4.SetActive(false);
    }

    //Power Level
    public void PowerLevelButtonCheck()
    {
        if (0.6f <= powerLevelSlider.value && powerLevelSlider.value <= 0.8f)
        {
            tickTask2.SetActive(true);
            crossTask2.SetActive(false);
            powerLevelTaskCompleted = true;
        }
    }
}