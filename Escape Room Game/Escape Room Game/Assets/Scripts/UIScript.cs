using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{
    public GameObject buttonOTronCanvas;
    public GameObject powerLevelCanvas;

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
        }

        
    }

    public void ExitButton()
    {
        if (checkCanvas == true)
        {
            buttonOTronCanvas.SetActive(false);
            powerLevelCanvas.SetActive(false);
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
    }


}
