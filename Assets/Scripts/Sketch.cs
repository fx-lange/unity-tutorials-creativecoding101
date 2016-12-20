using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;

    void Start () {

        int totalCubes = 12;
        float totalDistance = 2.8f;

        for( int i = 0; i < totalCubes; ++i)
        {
            float percentage = (float)i / (float)totalCubes;

            float sin = Mathf.Sin(percentage * Mathf.PI/2.0f);

            float x = 1.8f + sin * totalDistance;
            float y = 5;
            float z = 0;

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            Cube cubeScript = newCube.GetComponent<Cube>();
            cubeScript.SetSize(.5f * (1-percentage));
            cubeScript.rotationSpeed = .2f + percentage * 3.0f; //Random.value;
        }

        
	}
	
	void Update () {
		
	}
}
