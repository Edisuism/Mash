using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldier : MonoBehaviour
{
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    
        {
            sprite.enabled = false;
        }

}
