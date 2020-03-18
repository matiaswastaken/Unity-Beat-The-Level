using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuicideHelp : MonoBehaviour {

    public float lifeTime = 0;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0)
            Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D colliderobject)
   {
       
       if (colliderobject.gameObject.tag != "Player")
           Destroy(gameObject);
    }

    


}
