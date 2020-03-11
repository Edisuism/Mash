using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    public float speed = 5; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.fixedDeltaTime);
        if (Input.GetKey(up))
        {
            transform.Translate(new Vector2(0, 1 * speed * Time.fixedDeltaTime));
        }
        if (Input.GetKey(down))
        {
            transform.Translate(new Vector2(0, -1 * speed * Time.fixedDeltaTime));
        }
        if (Input.GetKey(left))
        {
            transform.Translate(new Vector2(-1 * speed * Time.fixedDeltaTime, 0));
        }
        if (Input.GetKey(right))
        {
            transform.Translate(new Vector2(1 * speed * Time.fixedDeltaTime, 0));
        }


    }



}
