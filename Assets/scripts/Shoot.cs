using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{


    Rigidbody2D rb;
    public float Angle;
    public float Speed;
    public GameObject Bullet;
    public float bulletVelocity = 100f;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        
       

        if (rb.velocity != Vector2.zero)
            transform.eulerAngles = new Vector3(0, 0, 0);
        else
            transform.eulerAngles = new Vector3(0, 0, 0);

      
        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 worldMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 direction = (Vector2)((worldMousePos - transform.position));
            direction.Normalize();
            // Creates the bullet locally
            GameObject bullet = (GameObject)Instantiate(
                                    Bullet,
                                    transform.position + (Vector3)(direction * 0.5f),
                                    Quaternion.identity);
            // Adds velocity to the bullet
            bullet.GetComponent<Rigidbody2D>().velocity = direction * bulletVelocity;
        }

    }

    void ShootBullet(float angle, float shootSpeed)
    {

        GameObject bull = Instantiate(Bullet) as GameObject;
        bull.transform.position = transform.position;
        bull.transform.eulerAngles = Vector3.forward * angle;
        Rigidbody2D bulletRigidBody = bull.GetComponent<Rigidbody2D>();

        bulletRigidBody.AddForce(new Vector2(Mathf.Cos(angle * Mathf.Deg2Rad) * shootSpeed, Mathf.Sin(angle * Mathf.Deg2Rad) * shootSpeed));


        Physics2D.IgnoreCollision(bull.GetComponent<CircleCollider2D>(), GetComponent<CircleCollider2D>());


    }
}
