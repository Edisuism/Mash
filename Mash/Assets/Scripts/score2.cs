using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score2 : MonoBehaviour
{
    public Text scoreText;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("helicopter2");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Player 2 Score: " + target.GetComponent<playerMovement>().score;
    }
}
