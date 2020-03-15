using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score1 : MonoBehaviour
{
    public Text scoreText;
    private GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("helicopter1");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Soldiers Rescued: " + target.GetComponent<playerMovement>().score + "\n" + "Soldiers in Helicopter: " + target.GetComponent<playerMovement>().carry;
    }
}
