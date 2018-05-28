using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var up = transform.up;

        var position = transform.position;
        position.x += up.x;
        position.y += up.y;
        transform.position = position;
	}
}
