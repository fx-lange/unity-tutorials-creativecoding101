using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sketch : MonoBehaviour {

    public GameObject myPrefab;

    void Start () {

        for( int i = 0; i < 3; ++i)
        {
            float x = 3;
            float y = 5;
            float z = 0;

            var newCube = (GameObject)Instantiate(myPrefab, new Vector3(x, y, z), Quaternion.identity);
            Cube cubeScript = newCube.GetComponent<Cube>();
            cubeScript.SetSize(1.5f);
        }

        
	}
	
	void Update () {
		
	}
}
