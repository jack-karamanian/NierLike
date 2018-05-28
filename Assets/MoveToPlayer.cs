using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour {
	public float Speed = 1.0f;
	public Transform PlayerTransform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// Face the player
		transform.right = PlayerTransform.position - transform.position;
		transform.Rotate(0, 0, -90);

		transform.position = Vector2.MoveTowards(transform.position, PlayerTransform.position, Time.fixedDeltaTime * Speed);
	}
}
