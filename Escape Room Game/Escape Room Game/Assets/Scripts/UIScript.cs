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

    bool checkCanvas = false;
    
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

        if (Player.powerLevelInteract == false)
        {
            powerLevelCanvas.SetActive(false);
        }

        if (Player.powerSwitchInteract == false)
        {
            powerSwitchCanvas.SetActive(false);
        }

        if (Player.shieldInteract == false)
        {
            shieldCanvas.SetActive(false);
        }

        if (Player.tractorBeamInteract == false)
        {
            tractorBeamCanvas.SetActive(false);
        }
    }
}
