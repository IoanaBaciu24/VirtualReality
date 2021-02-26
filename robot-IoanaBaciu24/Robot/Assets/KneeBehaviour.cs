using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KneeBehaviour : MonoBehaviour {

	GameObject hip;
	HipBehaviour sincereHip;

	// Use this for initialization
	void Start () {
		hip = transform.parent.gameObject.transform.parent.gameObject;
		sincereHip = hip.GetComponent<HipBehaviour>(); 

	}
	
	// Update is called once per frame
	void Update () {
		if (hip!=null && !sincereHip.wait)
        {
            if (sincereHip.forward)
            {
				transform.Rotate(Vector3.left, Time.deltaTime * 40);
            }
            else
            {
				transform.Rotate(Vector3.right, Time.deltaTime * 40);
            }
        }
	}
}
