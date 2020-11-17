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

    public GameObject buttonOTronLightRed1;
    public GameObject buttonOTronLightRed2;
    public GameObject buttonOTronLightRed3;

    public GameObject buttonOTronLightGreen1;
    public GameObject buttonOTronLightGreen2;
    public GameObject buttonOTronLightGreen3;

    //Objects relating to power level
    public Slider powerLevelSlider;

    public GameObject tickTask2;
    public GameObject crossTask2;

    //Objects relating to power switches
    public Slider powerSwitchSlider;
    public GameObject powerSwitchonOffIndicator;

    public GameObject redLightPS;
    public GameObject greenLightPS;

    public GameObject tickTask3;
    public GameObject crossTask3;

    //Objects relating to shield activation
    public GameObject shieldButton;

    public GameObject tickTask4;
    public GameObject crossTask4;

    public GameObject redLightS;
    public GameObject greenLightS;

    //Objects relating to tractor beam
    public Slider tractorBeam;

    public GameObject tractorBeamLight;

    public GameObject redLightTB;
    public GameObject greenLightTB;

    public GameObject tickTask5;
    public GameObject crossTask5;


    //Variables
    public static bool allTasksCompleted = false;

    public bool allTasksCompletedChecker = allTasksCompleted;

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

    //Variables relating to keypad
    bool keypadButton1 = false;
    bool keypadButton2 = false;
    bool keypadButton3 = false;
    bool keypadButton4 = false;
    bool keypadButton5 = false;
    bool keypadButton6 = false;
    bool keypadButton7 = false;
    bool keypadButton8 = false;
    bool keypadButton9 = false;
    bool keypadButtonEnter = false;

    int keypadCounter = 0;

    bool keypadComplete = false;

    bool tractorBeamTaskComplete = false;

    // Start is called before the first frame update
    void Start()
    {
        powerSwitchSlider.value = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        allTasksCompletedChecker = allTasksCompleted;

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
            //powerSwitchonOffIndicator.GetComponent<Image>().color = Color.green;
            powerSwitchTaskCompleted = true;
            redLightPS.SetActive(false);
            greenLightPS.SetActive(true);
        }

        else //if (powerSwitchSlider.value != 1f)
        {

            tickTask3.SetActive(false);
            crossTask3.SetActive(true);
            //powerSwitchonOffIndicator.GetComponent<Image>().color = Color.red;
            powerSwitchTaskCompleted = false;
            redLightPS.SetActive(true);
            greenLightPS.SetActive(false);
        }

        //If statements to check if the player has done all the tasks
        if (powerLevelTaskCompleted == true && powerSwitchTaskCompleted == true && buttonOTronButtonTaskCompleted == true && shieldTaskCompleted == true && tractorBeamTaskComplete == true)
        {
            allTasksCompleted = true;
        }


        //debug stuff
        if (Input.GetKey(KeyCode.O))
        {
            powerLevelTaskCompleted = true;
            powerSwitchTaskCompleted = true;
            buttonOTronButtonTaskCompleted = true;
            shieldTaskCompleted = true;
            tractorBeamTaskComplete = true;
            tickTask1.SetActive(true);
            crossTask1.SetActive(false);
            tickTask2.SetActive(true);
            crossTask2.SetActive(false);
            tickTask3.SetActive(true);
            crossTask3.SetActive(false);
            tickTask4.SetActive(true);
            crossTask4.SetActive(false);
            tickTask5.SetActive(true);
            crossTask5.SetActive(false);
            powerSwitchSlider.value = 1f;
        }
    }

    //Button-O-Tron Task script
    public void ButtonOTronButton1()
    {
        buttonOTronButtonPressed1 = true;
        buttonOTronButtonGameObject1.GetComponent<Image>().color = Color.green;
        buttonOTronLightRed1.SetActive(false);
        buttonOTronLightGreen1.SetActive(true);
    }

    public void ButtonOTronButton2()
    {
        buttonOTronButtonPressed2 = true;
        buttonOTronButtonGameObject2.GetComponent<Image>().color = Color.green;
        buttonOTronLightRed2.SetActive(false);
        buttonOTronLightGreen2.SetActive(true);
    }

    public void ButtonOTronButton3()
    {
        buttonOTronButtonPressed3 = true;
        buttonOTronButtonGameObject3.GetComponent<Image>().color = Color.green;
        buttonOTronLightRed3.SetActive(false);
        buttonOTronLightGreen3.SetActive(true);
    }

    public void TurnOffShieldButton()
    {
        shieldTaskCompleted = true;
        shieldButton.GetComponent<Image>().color = Color.red;
        tickTask4.SetActive(true);
        crossTask4.SetActive(false);
        redLightS.SetActive(false);
        greenLightS.SetActive(true);
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

    //keypad code
    public void KeypadButton1()
    {
        if (keypadCounter <= 4)
        {
            keypadButton1 = true;
        } 
    }
    public void KeypadButton2()
    {
        if (keypadCounter <= 4)
        {
            keypadButton2 = true;
            keypadCounter += 1;
        }
    }
    public void KeypadButton3()
    {
        if (keypadCounter <= 4)
        {
            keypadButton3 = true;
            keypadCounter += 1;
        }
    }
    public void KeypadButton4()
    {
        if (keypadCounter <= 4)
        {
            keypadButton4 = true;
            keypadCounter += 1;
        }
    }
    public void KeypadButton5()
    {
        if (keypadCounter <= 4)
        {
            keypadButton5 = true;
            keypadCounter += 1;
        }
    }
    public void KeypadButton6()
    {
        if (keypadCounter <= 4)
        {
            keypadButton6 = true;
            keypadCounter += 1;
        }
    }
    public void KeypadButton7()
    {
        if (keypadCounter <= 4)
        {
            keypadButton7 = true;
            keypadCounter += 1;
        }
    }
    public void KeypadButton8()
    {
        if (keypadCounter <= 4)
        {
            keypadButton8 = true;
            keypadCounter += 1;
        }
    }
    public void KeypadButton9()
    {
        if (keypadCounter <= 4)
        {
            keypadButton9 = true;
            keypadCounter += 1;
        }
    }
    public void KeypadButtonEnter()
    {
        if (keypadButton2 == true && keypadButton7 == true && keypadButton4 == true && keypadButton1 == true)
        {
            if(tractorBeam.value == 0)
            {
                tractorBeamTaskComplete = true;
                tickTask5.SetActive(true);
                crossTask5.SetActive(false);
                tractorBeamLight.GetComponent<Image>().color = Color.green;
                redLightTB.SetActive(false);
                greenLightTB.SetActive(true);
            } 
        }
        else
        {
            keypadCounter = 0;
        }
    }
}