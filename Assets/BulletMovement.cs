using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour {
    public float Speed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var position = transform.position;
        var up = transform.up;

        position.x += up.x * Speed;
        position.y += up.y * Speed;

        transform.position = position;
	}
}
