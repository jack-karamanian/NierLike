using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public Vector3 Rotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var rotation = transform.eulerAngles;
        rotation.z += Rotation.z;
        transform.eulerAngles = rotation;
	}
}
