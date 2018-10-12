﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextTunnel : MonoBehaviour {

	public Tunnel straightTunnel;
	public Tunnel leftTunnel;
	public Tunnel rightTunnel;
	public Tunnel exit;
	
	
	Vector3 thisObjectsPosition;

	public float rng = 0f;
	void Start () {
        if( Manager.singleton.currentTunnel == null ) Manager.singleton.currentTunnel = Manager.singleton.startingTunnel;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Player")
		{
				Vector3 relativePos = transform.InverseTransformPoint(col.transform.position);
				if (relativePos.y > 0)
				{
                    if (Manager.singleton.exitSpawn >= 5)
                    {

                        Tunnel newExit = Instantiate<Tunnel>(exit);
                    newExit.transform.position = new Vector3(currentTunnel.socket.transform.position.x, currentTunnel.socket.transform.position.y, currentTunnel.socket.transform.position.z);
                }
                    else
                    {
                    
                        rng = Random.Range(0f, 3f);
                        if (rng >= 2f)
                        {
                            Tunnel newStraight = Instantiate<Tunnel>(straightTunnel);
                        newStraight.transform.position = new Vector3(currentTunnel.socket.transform.position.x, currentTunnel.socket.transform.position.y, currentTunnel.socket.transform.position.z);
                        newStraight.transform.localRotation = currentTunnel.socket.transform.localRotation;
                        Manager.singleton.exitSpawn += 1;
                        currentTunnel = newStraight;
                        newStraight.socket.transform.rotation = Quaternion.Euler(0f, Manager.singleton.currentRotation, 0f);
                        
                        }

                        else if (rng >= 1f)
                        {
                            Tunnel newLeft = Instantiate<Tunnel>(leftTunnel);
                        newLeft.transform.position = new Vector3(currentTunnel.socket.transform.position.x, currentTunnel.socket.transform.position.y, currentTunnel.socket.transform.position.z);
                        newLeft.transform.localRotation = currentTunnel.socket.transform.localRotation;
                        Manager.singleton.exitSpawn += 1;
                        currentTunnel = newLeft;
                        Manager.singleton.currentRotation += -90f;
                        newLeft.socket.transform.rotation = Quaternion.Euler(0f, Manager.singleton.currentRotation, 0f);
                        
                        }

                        else if (rng >= 0f)
                        {
                            Tunnel newRight = Instantiate<Tunnel>(rightTunnel);
                        newRight.transform.position = new Vector3(currentTunnel.socket.transform.position.x, currentTunnel.socket.transform.position.y, currentTunnel.socket.transform.position.z);
                        newRight.transform.localRotation = currentTunnel.socket.transform.localRotation;
                        Manager.singleton.exitSpawn += 1;
                        currentTunnel = newRight;
                        Manager.singleton.currentRotation += 90f;
                        newRight.socket.transform.rotation = Quaternion.Euler(0f, Manager.singleton.currentRotation, 0f);

                        
                        }
                    }
                    
                    Destroy();
                }

            
        }

		

	}

	void Destroy()
	{
		Destroy(this.gameObject);
        
	}
	
    public Tunnel currentTunnel
    {
        get { return Manager.singleton.currentTunnel; }
        set { Manager.singleton.currentTunnel = value; }
    }
}
