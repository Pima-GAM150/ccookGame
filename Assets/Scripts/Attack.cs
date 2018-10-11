using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {

	
	
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))
		{
			Attacking();
			Debug.Log("I am attacking");
		}

		if(Input.GetMouseButtonDown(1))
		{
			Magic();
			Debug.Log("I am shooting Fireballs");
		}
	}

	void Attacking()
	{
		//if (closeToEnemy == true)
		//{
			//do damage to enemy
		//}
	}

	void Magic()
	{
		//instantiate a fireball at mouse position and do dmg when the fireball hits
	}
}
