using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class CoinCounter : MonoBehaviour
{

    private int count;
    public Text countText;
    public Text winText;
    public Transform ExplosionEffect;
      
    void Start()
    {
        count = 0;
        winText.text = "";
        SetCountText();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "coin")
        {
            Instantiate(ExplosionEffect, transform.position, transform.rotation);
            Destroy(collision.gameObject);
            count = count + 1;
            SetCountText();
        }
    }

    void SetCountText()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        countText.text = "Coins Collected: " + count.ToString();

        //Check if we've collected all 12 pickups. If we have...
        if (count >= 12)
            //... then set the text property of our winText object to "You win!"
            winText.text = "You win!";
    }

}
