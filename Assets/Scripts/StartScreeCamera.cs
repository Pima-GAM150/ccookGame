using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreeCamera : MonoBehaviour {

	public float speed;
	private Rigidbody body;
	GameObject cam;
	public float startPosition;
	void Start () {
		speed = 300f;
		body = GetComponent<Rigidbody>();
		cam = this.gameObject;
		startPosition = 10f;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		

		Vector3 velocity = (transform.forward * 1f) * speed * Time.fixedDeltaTime;
		//velocity.y = body.velocity.y;
		body.velocity = velocity;

		if (cam.transform.position.z >= 100f)
		{
			cam.transform.position = new Vector3(3f, -6f, startPosition);
		}
	}
}
