using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

       public Transform followTarget;
    

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = new Vector3(followTarget.position.x, 0, transform.position.z);
        
    }
}
