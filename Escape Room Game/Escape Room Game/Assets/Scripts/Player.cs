﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public static bool buttonOTronInteract = false;
    public static bool powerLevelInteract = false;
    public static bool powerSwitchInteract = false;
    public static bool shieldInteract = false;
    public static bool tractorBeamInteract = false;
    public static bool canLeaveExitDoor = false;
    public static bool crateInteract = false;
    public static bool cameraInteract = false;
    public bool isSprinting = false;
    public float sprintEnergy = 5f;
    public Slider sprintBar;
    bool mainCameraStatus = true;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;

    public GameObject button;

    public GameObject cameraCanvas;
    public GameObject gameCanvas;

    public GameObject mainCamera;
    public GameObject mapCamera;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        enemy1.SetActive(false);
        enemy2.SetActive(false);
        enemy3.SetActive(false);
        enemy4.SetActive(false);
        enemy5.SetActive(false);
        enemy6.SetActive(false);

        if (CrossSceneVariables.isEasyDifficulty == true)
        {
            enemy1.SetActive(true);
            enemy2.SetActive(true);
        }

        else if (CrossSceneVariables.isMediumDifficulty == true)
        {
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            enemy5.SetActive(true);
        }

        else if (CrossSceneVariables.isHardDifficulty == true)
        {
            enemy1.SetActive(true);
            enemy2.SetActive(true);
            enemy3.SetActive(true);
            enemy4.SetActive(true);
            enemy5.SetActive(true);
            enemy6.SetActive(true);
        }

        mapCamera.SetActive(false);
        mainCamera.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            if (isSprinting == false)
            {
                transform.Translate(Vector3.right * Time.deltaTime * 5);
            }
            if (isSprinting == true)
            {
                transform.Translate(Vector3.right * Time.deltaTime * 10);
            }

        }

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            if (isSprinting == false)
            {
                transform.Translate(Vector3.left * Time.deltaTime * 5);
            }
            if (isSprinting == true)
            {
                transform.Translate(Vector3.left * Time.deltaTime * 10);
            }
        }

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            if (isSprinting == false)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 5);
            }
            if (isSprinting == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * 10);
            }
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            if (isSprinting == false)
            {
                transform.Translate(Vector3.down * Time.deltaTime * 5);
            }
            if (isSprinting == true)
            {
                transform.Translate(Vector3.down * Time.deltaTime * 10);
            }
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (sprintEnergy > 0)
            {
                sprintEnergy -= Time.deltaTime * 2;
                isSprinting = true;
            }
            if (sprintEnergy <= 0)
            {
                sprintEnergy += Time.deltaTime;
                isSprinting = false;
            }
        }

        if (!Input.GetKey(KeyCode.LeftShift))
        {
            isSprinting = false;
            if (sprintEnergy < 5)
            {
                sprintEnergy += Time.deltaTime;
            }
        }
        sprintBar.value = sprintEnergy;

        if (Input.GetKey(KeyCode.P))
        {
            enemy1.SetActive(true);
            enemy2.SetActive(true);
        }
        /*
        if (UIScript.cameraButtonCheck == true)
        {
            if (mainCameraStatus == false)
            {
                mainCamera.SetActive(true);
                mapCamera.SetActive(false);
                mainCameraStatus = true;
            }

            else if (mainCameraStatus == true)
            {
                mainCamera.SetActive(false);
                mapCamera.SetActive(true);
                mainCameraStatus = false;
            }
        }
        */
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu", LoadSceneMode.Single);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ButtonOTronTrigger")
        {
            buttonOTronInteract = true;
            button.SetActive(true);
        }

        if (collision.gameObject.tag == "PowerLevelTrigger")
        {
            powerLevelInteract = true;
            button.SetActive(true);
        }

        if (collision.gameObject.tag == "PowerSwitchTrigger")
        {
            powerSwitchInteract = true;
            button.SetActive(true);
        }

        if (collision.gameObject.tag == "ShieldTrigger")
        {
            shieldInteract = true;
            button.SetActive(true);
        }

        if (collision.gameObject.tag == "TractorBeamTrigger")
        {
            tractorBeamInteract = true;
            button.SetActive(true);
        }

        if (collision.gameObject.tag == "Crate")
        {
            crateInteract = true;
            button.SetActive(true);
        }

        if (collision.gameObject.tag == "ExitDoorTrigger")
        {
            if (Tasks.allTasksCompleted == true)
            {
                button.SetActive(true);
                canLeaveExitDoor = true;
                Debug.Log("allTasksCompleted = " + Tasks.allTasksCompleted);
            }
        }

        if (collision.gameObject.tag == "CameraTrigger")
        {
            cameraInteract = true;
            button.SetActive(true);
            Debug.Log(cameraInteract);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ButtonOTronTrigger")
        {
            buttonOTronInteract = false;
            button.SetActive(false);
        }

        if (collision.gameObject.tag == "PowerLevelTrigger")
        {
            powerLevelInteract = false;
            button.SetActive(false);
        }

        if (collision.gameObject.tag == "PowerSwitchTrigger")
        {
            powerSwitchInteract = false;
            button.SetActive(false);
        }

        if (collision.gameObject.tag == "ShieldTrigger")
        {
            shieldInteract = false;
            button.SetActive(false);
        }

        if (collision.gameObject.tag == "TractorBeamTrigger")
        {
            tractorBeamInteract = false;
            button.SetActive(false);
        }

        if (collision.gameObject.tag == "Crate")
        {
            crateInteract = false;
            button.SetActive(false);
        }

        if (collision.gameObject.tag == "ExitDoorTrigger")
        {
            if (Tasks.allTasksCompleted == true)
            {
                button.SetActive(false);
                canLeaveExitDoor = false;
                Debug.Log("allTasksCompleted = " + Tasks.allTasksCompleted);
            }
        }

        if (collision.gameObject.tag == "CameraTrigger")
        {
            cameraInteract = false;
            button.SetActive(false);
            Debug.Log(cameraInteract);
            ExitCameraCanvas();
        }
    }

    public void CameraButton()
    { /*
        if (cameraInteract == false)
        {
            if (mainCameraStatus == false)
            {
                mainCamera.SetActive(true);
                mapCamera.SetActive(false);
                mainCameraStatus = true;
            }
        }
*/


        if (cameraInteract == true)
        {
            mainCamera.SetActive(false);
            mapCamera.SetActive(true);
            gameCanvas.SetActive(false);
            cameraCanvas.SetActive(true);
            mainCameraStatus = false;
        }
    }

    public void ExitCameraCanvas()
    {
        mainCamera.SetActive(true);
        mapCamera.SetActive(false);
        gameCanvas.SetActive(true);
        cameraCanvas.SetActive(false);
        mainCameraStatus = true;
        UIScript.checkCanvas = false;
    }
}