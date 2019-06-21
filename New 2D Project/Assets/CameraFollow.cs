using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public GameObject target;
    public float speed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (target != null)
        {
            Vector3 desiredPosition = new Vector3(target.transform.position.x, target.transform.position.y, transform.position.z);
            if (transform.position != desiredPosition)
            {
                transform.position = Vector3.Lerp(transform.position, desiredPosition, speed);
            }
        }
        

        //Debug.Log(target.transform.position);
	}

  
}
