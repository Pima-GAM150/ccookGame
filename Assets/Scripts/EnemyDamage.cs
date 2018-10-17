using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour {

	public GameObject target;
	public HealthBar healthBar;
	public float counter;
	GameObject sword;
	
	void Start () {
		target = GameObject.Find("Player");
		counter = 0f;
		sword = GameObject.Find("Sword");

		healthBar = sword.GetComponent<Damage>().healthBar;
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
					DoDamage(15f);
				}
			}
			if (this.gameObject.name == "Ghost Boss")
			{
				if (counter > 1.25f)
				{
					DoDamage(20f);
				}
			}
			if (this.gameObject.tag == "Undead")
			{
				if (counter > 1.75f)
				{
					DoDamage(15f);
					
				}
			}
			if (this.gameObject.tag == "Undead Boss")
			{
				if (counter > 2.0f)
				{
					DoDamage(25f);
				}
			}
		}

	public void DoDamage(float damage)
	{
		Manager.singleton.health -= damage;
		counter = 0f;
		healthBar.healthRegenCounter = 0f;
		

		if (Manager.singleton.health <= 0)
		{
			Manager.singleton.GameOverScreen();
		}

	}
}
