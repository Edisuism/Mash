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
    public int carry = 0;
    public AudioClip pickup;
    public AudioClip rescue;
    public AudioClip death;
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        audio = GetComponent<AudioSource>();
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
            audio.clip = death;
            audio.Play();

        }
        else if (collision.gameObject.CompareTag("soldier"))
        {
            if (carry < 3)
            {
                carry++;
                collision.gameObject.SetActive(false);
                audio.clip = pickup;
                audio.Play();
            }
            
        }
        else if (collision.gameObject.CompareTag("hospital"))
        {
            if (this.CompareTag("helicopter1"))
            {
                score += carry;
                carry = 0;
                audio.clip = rescue;
                audio.Play();
            }
            
        }
        else if (collision.gameObject.CompareTag("hospital2"))
        {
            if (this.CompareTag("helicopter2"))
            {
                score += carry;
                carry = 0;
                audio.clip = rescue;
                audio.Play();
            }

        }

    }


}
