using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereEnemyShooting : MonoBehaviour {
    public float ShootTime;
    public GameObject Bullet;
    public float[] Bullets = new float[] { 
        /*new Vector2(1, 0),
        new Vector2(0, 1),
        new Vector2(-1, 0),
        new Vector2(0, -1)*/
        0,
        45,
        90,
        180
    };

    float prevTime = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print(transform.up);
        if(Time.fixedTime - prevTime > ShootTime) {
            prevTime = Time.fixedTime;
            foreach (var i in Bullets) {
                var rotation = new Quaternion();
                var angles = rotation.eulerAngles;
                /*var vector = i;
                vector.x -= transform.up.x;
                vector.y += transform.up.y;
                
                
                angles.z = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg + 45;*/
                angles.z = i + (Mathf.Atan2(transform.up.y, transform.up.x) * Mathf.Rad2Deg);
                rotation.eulerAngles = angles;
                GameObject.Instantiate(Bullet, transform.position, rotation);
            }
        }
        
	}
}
