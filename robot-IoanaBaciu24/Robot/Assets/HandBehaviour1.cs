using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class HandBehaviour1 : MonoBehaviour {
	public bool goUp;
	// Use this for initialization
	void Start () {
        transform.rotation.Set(0.2f, 0.0f, 0.0f, 0.0f);

    }
	
	// Update is called once per frame
	void Update () {

		if (goUp)
		{
			transform.Rotate(Vector3.right, Time.deltaTime*45);
		}

		else  
		{ 
			transform.Rotate(Vector3.left, Time.deltaTime * 45f); 

		}

		if (transform.rotation.x >=0.25f && goUp)
        {
			goUp = false;
			return;
        }
		if (transform.rotation.x <= -0.25f && !goUp)
        {
			goUp = true;
			return;
        }			

		

	}
}
