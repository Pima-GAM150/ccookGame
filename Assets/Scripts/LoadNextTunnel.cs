using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextTunnel : MonoBehaviour {

	public GameObject straightTunnel;
	public GameObject leftTunnel;
	public GameObject rightTunnel;
	public GameObject exit;
    GameObject socket;
	GameObject manager;
	public Manager mngr;	
	
	Vector3 thisObjectsPosition;

	public float rng = 0f;
	void Start () {
        socket = GameObject.Find("socket");
        manager = GameObject.Find("manager");
        mngr = manager.GetComponent<Manager>();
		//thisObjectsPosition.x = this.gameObject.transform.position.x;
		//thisObjectsPosition.y = this.gameObject.transform.position.y;
		//thisObjectsPosition.z = this.gameObject.transform.position.z;
		//Debug.Log(thisObjectsPosition);

		//need to find out how to instantiate objects as a child of another to make placing them easier!
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Player")
			{
				Vector3 relativePos = transform.InverseTransformPoint(col.transform.position);
				if (relativePos.z > 0)
				{
					rng = Random.Range(0f, 3f);
					if (rng >= 2f)
					{	
						GameObject newStraight = Instantiate<GameObject>(straightTunnel);
                        newStraight.transform.position = new Vector3(socket.transform.position.x, socket.transform.position.y, socket.transform.position.z); //(4f, -9f, 46.5f);
						mngr.exitSpawn += 1;
					}

					else if (rng >= 1f)
					{
						GameObject newLeft = Instantiate<GameObject>(leftTunnel);
                        newLeft.transform.position = new Vector3(socket.transform.position.x, socket.transform.position.y, socket.transform.position.z); //(7.5f, -12f, 44f);
						mngr.exitSpawn += 1;
					}

					else if (rng >= 0f)
					{
						GameObject newRight = Instantiate<GameObject>(rightTunnel);
                        newRight.transform.position = new Vector3(socket.transform.position.x, socket.transform.position.y, socket.transform.position.z); //(0.5f, -6f, 44.5f);
						mngr.exitSpawn += 1;
					}
				}
				Destroy();
				
			}

		

	}

	void Destroy()
	{
		Destroy(this.gameObject);
	}
	

}
