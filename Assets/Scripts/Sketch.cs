using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;

    void Start () {

        int totalCubes = 8;
        int totalDistance = 5;

        for( int i = 0; i < totalCubes; ++i)
        {
            float percentage = (float)i / (float)totalCubes;

            float x = percentage * totalDistance;
            float y = 5;
            float z = 0;

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            Cube cubeScript = newCube.GetComponent<Cube>();
            cubeScript.SetSize((1-percentage));
            cubeScript.rotationSpeed = percentage; //Random.value;
        }

        
	}
	
	void Update () {
		
	}
}
