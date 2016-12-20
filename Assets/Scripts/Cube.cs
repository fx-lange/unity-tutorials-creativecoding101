using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public Vector3 spinSpeed;
    public Vector3 spinAxis;

	// Use this for initialization
	void Start () {
        //this.transform.position = new Vector3(0, 5, 3);
 
        //SetSize(2);

        spinSpeed = new Vector3(Random.value, Random.value, Random.value);

        spinAxis = Vector3.up;
        spinAxis.x = (Random.value - Random.value) * 0.1f;
	}

    public void SetSize(float size){
        this.transform.localScale = new Vector3(size, size, size);
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(spinSpeed);
        this.transform.RotateAround( Vector3.zero, spinAxis, 1.0f);
	}
}
