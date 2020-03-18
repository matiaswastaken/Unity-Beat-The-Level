using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLife : MonoBehaviour
{

    public int life = 4;
    public Transform ExplosionEffect;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(life <= 0)
        {
            Instantiate(ExplosionEffect, transform.position, transform.rotation);
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gameObject")
        {
            life--;
        }
    }
}
