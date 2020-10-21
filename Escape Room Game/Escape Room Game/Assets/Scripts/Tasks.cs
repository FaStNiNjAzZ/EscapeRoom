using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Tasks : MonoBehaviour
{
    //Game Objects
    public GameObject buttonOTronButtonGameObject1;
    public GameObject buttonOTronButtonGameObject2;
    public GameObject buttonOTronButtonGameObject3;

    public GameObject tickTask1;
    public GameObject crossTask1;


    public static Slider powerLevelSlider;

    public GameObject tickTask2;
    public GameObject crossTask2;


    //Variables
    bool buttonOTronButtonPressed1 = false;
    bool buttonOTronButtonPressed2 = false;
    bool buttonOTronButtonPressed3 = false;
    public bool buttonOTronButtonTaskCompleted = false;
    //float powerLevelValue = powerLevelSlider.value;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (buttonOTronButtonPressed1 == true && buttonOTronButtonPressed2 == true && buttonOTronButtonPressed3 == true)
        {
            buttonOTronButtonTaskCompleted = true;
            tickTask1.SetActive(true);
            crossTask1.SetActive(false);
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

    //Power Level
    public void PowerLevelButtonCheck()
    {
        if (0.6f >= powerLevelSlider.value && powerLevelSlider.value <= 0.8f)
        {
            tickTask2.SetActive(true);
            crossTask2.SetActive(false);
        }
    }
}