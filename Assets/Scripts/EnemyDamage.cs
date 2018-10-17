using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	public GameObject target;
	public HealthBar healthBar;
	public float counter;

	
	void Start () {
		target = GameObject.Find("Player");
		counter = 0f;
	}
	
	
	void Update () {
		counter += Time.deltaTime;
	}

	void OnTriggerEnter(Collider col)
		{
			
			if (this.gameObject.name == "Ghost")
			{
				if (counter > 1.25f)
				{
					DoDamage(5f);
				}
			}
			if (this.gameObject.name == "Ghost Boss")
			{
				if (counter > 1.25f)
				{
					DoDamage(10f);
				}
			}
			if (this.gameObject.tag == "Undead")
			{
				if (counter > 1.75f)
				{
					DoDamage(5f);
					
				}
			}
			if (this.gameObject.tag == "Undead Boss")
			{
				if (counter > 1.8f)
				{
					DoDamage(15f);
				}
			}
		}

	public void DoDamage(float damage)
	{
		Manager.singleton.health -= damage;
		counter = 0f;
		healthBar.healthRegenCounter = 0f;
		

		if (Manager.singleton.health < 0)
		{
			//Manager.singleton.GameOverScreen();
		}

	}
}
