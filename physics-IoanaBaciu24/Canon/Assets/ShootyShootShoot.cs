using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootyShootShoot : MonoBehaviour {

	public Rigidbody projectile ;
	public Transform pos;
	public float moveSpeed = 1000f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("space"))
        {
			GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
	
			Rigidbody shot = Instantiate(projectile, pos.position, transform.rotation) as Rigidbody;
            shot.velocity = transform.forward * moveSpeed;
            shot.AddForce(0, 6.5f, moveSpeed, ForceMode.VelocityChange);

			AudioSource quack = GetComponent<AudioSource>();
			quack.Play();

        }

    }
}
