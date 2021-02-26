using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaiseWall : MonoBehaviour {


    // Use this for initialization
    void Start () {

        Vector3 pos = new Vector3(0.0f, 0.51f, 12.0f);

        var aux = 0;

        for (int i = 5; i >= 1; i--)
        {
            pos.x += 0.5f;
            for (int k = 2; k <= 10; k++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.localScale = new Vector3((float)1, (float)0.7, (float)0.7);
                cube.GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.Lerp(Color.red, Color.yellow, (float)0.1), Color.green, (float)0.3);
                Rigidbody gameObjectsRigidBody = cube.AddComponent<Rigidbody>(); // Add the rigidbody.
                gameObjectsRigidBody.mass = 3; // Set the GO's mass to 5 via the Rigidbody.
                cube.transform.position = pos;
                //cube.transform.position.x += (1.01f)/ 2;
                aux += 1;

                pos.x += 1.01f;
            }
            pos.y += 0.701f;
            pos.x = 0.0f;
            if (i == 1)
                return;
            for (int j = 1; j <= 10; j++)
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.localScale = new Vector3((float)1, (float)0.7, (float)0.7);
                cube.GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.Lerp(Color.red,Color.yellow, (float)0.1), Color.green, (float)0.3);
                Rigidbody gameObjectsRigidBody = cube.AddComponent<Rigidbody>(); // Add the rigidbody.
                gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.
                cube.transform.position = pos;
         
                aux += 1;

                pos.x += 1.01f;
            }
            pos.y += 0.701f;
            pos.x = 0.0f;
        }

        print(aux);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
