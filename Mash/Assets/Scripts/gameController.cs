using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gameController : MonoBehaviour
{
    GameObject player1;
    GameObject player2;
    Text win;
    Text lose;
    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag("helicopter1");
        player2 = GameObject.FindGameObjectWithTag("helicopter2");
        win = GameObject.Find("win").GetComponent<Text>();
        lose = GameObject.Find("lose").GetComponent<Text>();
        win.enabled = false;
        lose.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene("Game");
            Time.timeScale = 1;
            player1.GetComponent<playerMovement>().enabled = true;
            player2.GetComponent<playerMovement>().enabled = true;
            // set player score to 0;
            // set player carry to 0;

        }

        if (Time.timeScale == 0)
        {
            if (player1.GetComponent<playerMovement>().score + player2.GetComponent<playerMovement>().score == 6)
            {
                win.enabled = true;
            }
            else
            {
                lose.enabled = true;
            }
            player1.GetComponent<playerMovement>().enabled = false;
            player2.GetComponent<playerMovement>().enabled = false;
            
        }

        if (player1.GetComponent<playerMovement>().score + player2.GetComponent<playerMovement>().score == 6)
        {
            Time.timeScale = 0;
        }
    }
}
