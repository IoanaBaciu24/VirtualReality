using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElbowBehaviour : MonoBehaviour {

	GameObject shoulder;
	HandBehaviour1 shoulderRotation;
	// Use this for initialization
	void Start () {

		shoulder = transform.parent.gameObject.transform.parent.gameObject;
		shoulderRotation = shoulder.GetComponent<HandBehaviour1>();
        transform.rotation.Set(0.2f, 0.0f, 0.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {
		
		if(shoulderRotation != null)
        {
			if(shoulderRotation.goUp)
            {
				transform.Rotate(Vector3.right, Time.deltaTime*20);
			}
            else
            {
                transform.Rotate(Vector3.left, Time.deltaTime*20);

			}

		}


	}
}
