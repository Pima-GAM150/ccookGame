using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour {

		
	
	void Start ( )
	{
        
	}
	void OnTriggerEnter (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				Vector3 relativePos = transform.InverseTransformPoint(col.transform.position);
				if (relativePos.z > 0)
				{
					Manager.singleton.LoadNewScene();
					Manager.singleton.currentRotation = 0f;
				}
				
				
			}
	}

		
		



	}
