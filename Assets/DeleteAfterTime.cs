using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterTime : MonoBehaviour {
    public float TimeToLive;
    float timeCreated;
	// Use this for initialization
	void Start () {
        timeCreated = Time.fixedTime;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.fixedTime - timeCreated > TimeToLive) {
            GameObject.Destroy(gameObject);
        }
	}
}
