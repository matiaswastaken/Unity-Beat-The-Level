using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class walkingBehaviour : MonoBehaviour {

    Animator anim;
    Rigidbody2D rb;
    SpriteRenderer sr;
    public int jumpCount = 2;

    void Start()
    {

        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("w") && jumpCount > 0)
        {
            
            rb.AddForce(new Vector2(0, 150f));
            jumpCount--;
        }

        if (Input.GetKey("d"))
        {
            anim.SetBool("isWalking", true);
            rb.velocity = new Vector2(2, rb.velocity.y);
            sr.flipX = false;
        }

        else if (Input.GetKey("a"))
        {
            anim.SetBool("isWalking", true);
            rb.velocity = new Vector2(-2, rb.velocity.y);
            sr.flipX = true;
        }

        else
        {
            anim.SetBool("isWalking", false);
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ice")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("MainScene");
        }

        if (collision.gameObject.tag == "ground")
        {
            jumpCount = 2;
        }

        }

    }

