using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HipBehaviour : MonoBehaviour {

	public bool wait;
	public bool forward;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (wait)
        {
			StartCoroutine(Sleep()); 
        }
		else
        {
			if(forward)
            {
				transform.Rotate(Vector3.right, Time.deltaTime * 30);
            }
			else
            {
				transform.Rotate(Vector3.left, Time.deltaTime * 30);

			}

			if (transform.rotation.x >= 0.25f && forward)
			{
				forward = false;
				return;
			}
			if (transform.rotation.x <= -0.1f && !forward)
			{
				forward = true;
				return;
			}
		}
		
	}

	IEnumerator Sleep()
    {
		yield return new WaitForSeconds(0.5f);
		wait = false;

    }
}
