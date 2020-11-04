using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public static bool buttonOTronInteract = false;
    public static bool powerLevelInteract = false;
    public static bool powerSwitchInteract = false;
    public static bool shieldInteract = false;
    public static bool tractorBeamInteract = false;
    public static bool canLeaveExitDoor = false;
    public bool isSprinting = false;
    public float sprintEnergy = 5f;
 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ExitDoorTrigger")
        {
            if (Tasks.allTasksCompleted == true)
            {
                canLeaveExitDoor = true;
                Debug.Log("Exit");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ButtonOTronTrigger")
        {
            buttonOTronInteract = true;
        }

        if (collision.gameObject.tag == "PowerLevelTrigger")
        {
            powerLevelInteract = true;
        }

        if (collision.gameObject.tag == "PowerSwitchTrigger")
        {
            powerSwitchInteract = true;
        }

        if (collision.gameObject.tag == "ShieldTrigger")
        {
            shieldInteract = true;
        }

        if (collision.gameObject.tag == "TractorBeamTrigger")
        {
            tractorBeamInteract = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ButtonOTronTrigger")
        {
            buttonOTronInteract = false;
        }

        if (collision.gameObject.tag == "PowerLevelTrigger")
        {
            powerLevelInteract = false;
        }

        if (collision.gameObject.tag == "PowerSwitchTrigger")
        {
            powerSwitchInteract = false;
        }

        if (collision.gameObject.tag == "ShieldTrigger")
        {
            shieldInteract = false;
        }

        if (collision.gameObject.tag == "TractorBeamTrigger")
        {
            tractorBeamInteract = false;
        }
    }
}
