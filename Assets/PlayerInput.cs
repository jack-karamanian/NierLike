using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour {
    const float DeadZone = 0.50f;

    public float Speed = 1.0f;
    public float FireDeltaTime = 0.25f;
    public GameObject Bullet;

    float prevTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DoButtonInput();
        DoMovement();
        DoRotation();
	}

    void DoButtonInput() {
        if (Input.GetButton("Fire1") && Time.fixedTime - prevTime > FireDeltaTime) {
            var position = transform.position;
            position.x += transform.up.x;
            position.y += transform.up.y;

            GameObject.Instantiate(Bullet, position, transform.rotation);
            prevTime = Time.fixedTime;
        }
    }

    void DoMovement() {
        var direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        var position = transform.position;
        
        position.x += direction.x * Speed;
        position.y += direction.y * Speed;
        transform.position = position;
    }

    void DoRotation() {
        var rightX = Input.GetAxis("RightHorizontal");
        var rightY = -Input.GetAxis("RightVertical");
        
        var direction = new Vector2(rightX, rightY);
        if (direction.magnitude >= DeadZone) {
            direction = direction.normalized * ((direction.magnitude - DeadZone) / (1 - DeadZone));
            var angle = (Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg) - 90;
            //print(angle);
            var rotation = transform.rotation;
            var angles = rotation.eulerAngles;
            angles.z = angle;
            rotation.eulerAngles = angles;
            transform.rotation = rotation;
        }
            
    }
}
