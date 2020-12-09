using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject buttonOTronCanvas;
    public GameObject powerLevelCanvas;
    public GameObject powerSwitchCanvas;
    public GameObject shieldCanvas;
    public GameObject tractorBeamCanvas;
    public GameObject gameCompletedCanvas;
    public GameObject keypadCodeCanvas;

    public static bool cameraButtonCheck = false;

    public static bool checkCanvas = false;

    public void InteractButton()
    {
        if (checkCanvas == false)
        {
            if (Player.buttonOTronInteract == true)
            {
                buttonOTronCanvas.SetActive(true);
                checkCanvas = true;
                Debug.Log("ok cunt");
            }

            if (Player.powerLevelInteract == true)
            {
                powerLevelCanvas.SetActive(true);
                checkCanvas = true;
                Debug.Log("ok cunt");
            }

            if (Player.powerSwitchInteract == true)
            {
                powerSwitchCanvas.SetActive(true);
                checkCanvas = true;
                Debug.Log("ok cunt");
            }

            if (Player.shieldInteract == true)
            {
                shieldCanvas.SetActive(true);
                checkCanvas = true;
                Debug.Log("ok cunt");
            }

            if (Player.tractorBeamInteract == true)
            {
                tractorBeamCanvas.SetActive(true);
                checkCanvas = true;
                Debug.Log("ok cunt");
            }

            if (Player.canLeaveExitDoor == true)
            {
                gameCompletedCanvas.SetActive(true);
                Debug.Log(Player.canLeaveExitDoor);
            }

            if (Player.crateInteract == true)
            {
                keypadCodeCanvas.SetActive(true);
                checkCanvas = true;
                Debug.Log(Player.crateInteract);
            }

            if (Player.cameraInteract == true)
            {
                cameraButtonCheck = true;
                checkCanvas = true;
                Debug.Log(Player.cameraInteract);
            }
        }
    }

    public void ExitButton()
    {
        if (checkCanvas == true)
        {
            buttonOTronCanvas.SetActive(false);
            powerLevelCanvas.SetActive(false);
            powerSwitchCanvas.SetActive(false);
            shieldCanvas.SetActive(false);
            tractorBeamCanvas.SetActive(false);
            keypadCodeCanvas.SetActive(false);
            cameraButtonCheck = false;
            checkCanvas = false;
            Debug.Log("ok cunt2");
        }
    }

    void Update()
    {
        if (Player.buttonOTronInteract == false)
        {
            buttonOTronCanvas.SetActive(false);
        }

        else if (Player.powerLevelInteract == false)
        {
            powerLevelCanvas.SetActive(false);
        }

        else if (Player.powerSwitchInteract == false)
        {
            powerSwitchCanvas.SetActive(false);
        }

        else if (Player.shieldInteract == false)
        {
            shieldCanvas.SetActive(false);
        }

        else if (Player.tractorBeamInteract == false)
        {
            tractorBeamCanvas.SetActive(false);
        }

        else if (Player.crateInteract == false)
        {
            tractorBeamCanvas.SetActive(false);
        }

        else if (Player.cameraInteract == false)
        {
            cameraButtonCheck = false;
        }
    }
}
