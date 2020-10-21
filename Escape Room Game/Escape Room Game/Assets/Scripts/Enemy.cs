using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public Transform target;//set target from inspector instead of looking in Update
    public float speed = 3f;
    public bool seePlayerCheck = false;
    public GameObject gameOverScreen;


    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    void Update()
    {
        if (seePlayerCheck == true)
        {
            //rotate to look at the player
            transform.LookAt(target.position);
            transform.Rotate(new Vector3(0, -90, 0), Space.Self);//correcting the original rotation


            //move towards the player
            if (Vector3.Distance(transform.position, target.position) > 1f)
            {//move if distance from target is greater than 1
                transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            seePlayerCheck = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            seePlayerCheck = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameOverScreen.SetActive(true);
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
