using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpikeBehaviour : MonoBehaviour {

   public float amplitude;
    public float period;
    private int frames = 0;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        frames++;
        transform.position = new Vector3(transform.position.x, (Mathf.Sin(frames / period) * amplitude) - 4, -3);
	}

   
}
