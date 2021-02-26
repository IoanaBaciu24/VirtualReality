using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowHead : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Vector3 mouse = Input.mousePosition;
  //      // I forgot to work on git and to commit things, but here is the first attempt that didnt work: 
  //      //transform.LookAt(mouse * Time.deltaTime * 10);

 

		// this worked tho
		Vector3 mouse = Input.mousePosition;
		Vector3 mouseWorld = Camera.main.ScreenToWorldPoint(new Vector3(
															mouse.x,
															mouse.y,
															transform.position.y));
		Vector3 forward = mouseWorld - transform.position;
		transform.rotation = Quaternion.LookRotation(forward, Vector3.up);

	}
}
