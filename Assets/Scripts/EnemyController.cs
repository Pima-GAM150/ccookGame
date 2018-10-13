using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public Transform target;
	public float speed;
	public bool isTriggered;

	void Start () {
		speed = 4;

	}
	

	void Update()
	{
		if (isTriggered == true)
		{
		float step = speed * Time.deltaTime;

		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		}
		
	}
	// Update is called once per frame
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.name == "Player")
		{
			isTriggered = true;
		}	

	}
}
