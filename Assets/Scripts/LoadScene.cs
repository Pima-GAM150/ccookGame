using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour {

	public GameObject manager;
	public Manager mngr;	
	
	void Start ( )
	{
		mngr = manager.GetComponent<Manager>();
	}
	void OnTriggerEnter (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				Vector3 relativePos = transform.InverseTransformPoint(col.transform.position);
				if (relativePos.z > 0)
				{
					mngr.LoadNewScene();
				}
				
				
			}
	}

		
		



	}
