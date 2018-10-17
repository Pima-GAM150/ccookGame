using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextTunnel : MonoBehaviour {

	public Tunnel straightTunnel;
	public Tunnel leftTunnel;
	public Tunnel rightTunnel;
	public Tunnel exit;
	
 
	
	Vector3 thisObjectsPosition;

	public float rng = 0f;
	
	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == "Player")
		{
				Vector3 relativePos = transform.InverseTransformPoint(col.transform.position);
				if (relativePos.y > 0)
				{

                    if (Manager.singleton.exitSpawn >= 5)
                    {

                        Tunnel newTunnel = Instantiate<Tunnel>(exit);
                    	newTunnel.transform.position = new Vector3(currentTunnel.socket.transform.position.x, currentTunnel.socket.transform.position.y, currentTunnel.socket.transform.position.z);
                    	newTunnel.transform.localRotation = currentTunnel.socket.transform.localRotation;
                    	
                	}
                    else
                    {
                    
                        rng = Random.Range(0f, 3f);
                        if (rng >= 2f)
                        {
                        Tunnel newTunnel = Instantiate<Tunnel>(straightTunnel);

                        newTunnel.transform.position = new Vector3(currentTunnel.socket.transform.position.x, currentTunnel.socket.transform.position.y, currentTunnel.socket.transform.position.z);
                        newTunnel.transform.localRotation = currentTunnel.socket.transform.localRotation;
                        Manager.singleton.exitSpawn += 1;
                        currentTunnel = newTunnel;
                        newTunnel.socket.transform.localEulerAngles = new Vector3(0f, Manager.singleton.currentRotation, 0f);
                            if (rng >= 2.5f)
                            {
                                Transform newGhost = currentTunnel.transform.Find("Ghost");
                                GameObject ghost = newGhost.gameObject; 
                                ghost.SetActive(true);                               
                            }
                            else
                            {
                                Transform newUndead = currentTunnel.transform.Find("Undead Knight");
                                GameObject undead = newUndead.gameObject; 
                                undead.SetActive(true);
                            }
                        }

                        else if (rng >= 1f)
                        {
                        Tunnel newTunnel = Instantiate<Tunnel>(leftTunnel);

                        newTunnel.transform.position = new Vector3(currentTunnel.socket.transform.position.x, currentTunnel.socket.transform.position.y, currentTunnel.socket.transform.position.z);
                        newTunnel.transform.localRotation = currentTunnel.socket.transform.localRotation;
                        Manager.singleton.exitSpawn += 1;
                        currentTunnel = newTunnel;
                        Manager.singleton.currentRotation += -90f;
                        newTunnel.socket.transform.localEulerAngles = new Vector3(0f, Manager.singleton.currentRotation, 0f);
                            if (rng >= 1.5f)
                            {
                                Transform newGhost = currentTunnel.transform.Find("Ghost");
                                GameObject ghost = newGhost.gameObject; 
                                ghost.SetActive(true);                               
                            }
                            else
                            {
                                Transform newUndead = currentTunnel.transform.Find("Undead Knight");
                                GameObject undead = newUndead.gameObject; 
                                undead.SetActive(true);
                            }
                        }

                        else if (rng >= 0f)
                        {
                        Tunnel newTunnel = Instantiate<Tunnel>(rightTunnel);

                        newTunnel.transform.position = new Vector3(currentTunnel.socket.transform.position.x, currentTunnel.socket.transform.position.y, currentTunnel.socket.transform.position.z);
                        newTunnel.transform.localRotation = currentTunnel.socket.transform.localRotation;
                        Manager.singleton.exitSpawn += 1;
                        currentTunnel = newTunnel;
                        Manager.singleton.currentRotation += 90f;
                        newTunnel.socket.transform.localEulerAngles = new Vector3(0f, Manager.singleton.currentRotation, 0f);
                            if (rng >= 0.5f)
                            {
                                Transform newGhost = currentTunnel.transform.Find("Ghost");
                                GameObject ghost = newGhost.gameObject; 
                                ghost.SetActive(true);                               
                            }
                            else
                            {
                                Transform newUndead = currentTunnel.transform.Find("Undead Knight");
                                GameObject undead = newUndead.gameObject; 
                                undead.SetActive(true);
                            }
                        
                        }
                    }
                    
                    Disable();
                }

            
        }

		

	}

	void Disable()
	{
		GameObject trigger = this.gameObject;
		trigger.SetActive(false);
        
	}
	
    public Tunnel currentTunnel
    {
        get { return Manager.singleton.currentTunnel; }
        set { Manager.singleton.currentTunnel = value; }
    }
}
