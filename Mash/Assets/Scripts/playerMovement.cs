using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public KeyCode up;
    public KeyCode down;
    public KeyCode left;
    public KeyCode right;

    private float speed = 1;

    private SpriteRenderer sprite;
    public int score = 0;
    private int carry = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
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
            sprite.flipX = true;
        }
        if (Input.GetKey(right))
        {
            transform.Translate(new Vector2(1 * speed * Time.fixedDeltaTime, 0));
            sprite.flipX = false;
        }


    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            Time.timeScale = 0;

        }
        else if (collision.gameObject.CompareTag("soldier"))
        {
            if (carry < 3)
            {
                carry++;
                collision.gameObject.SetActive(false);
            }
            
        }
        else if (collision.gameObject.CompareTag("hospital"))
        {
            if (this.CompareTag("helicopter1"))
            {
                score += carry;
                carry = 0;
            }
            
        }
        else if (collision.gameObject.CompareTag("hospital2"))
        {
            if (this.CompareTag("helicopter2"))
            {
                score += carry;
                carry = 0;
            }

        }

    }


}
