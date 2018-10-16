using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {
	public HealthBar health;
	public GameObject healthBar;
	public bool attackingPlayer;
	public float counter;
	
	
	void Start () {
		attackingPlayer = false;
		health = healthBar.GetComponent<HealthBar>();
		counter = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (attackingPlayer == true)
		{
			counter += Time.deltaTime;
			if (counter > 3f)
			{
				if (this.gameObject.name == "LumberJack")
				{
					health.takeDMG( 10f );
				}
				if (this.gameObject.name == "VillageHero")
				{
					health.takeDMG( 15f );
				}
				if (this.gameObject.name == "Enemy")
				{
					health.takeDMG( 5f );
				}
				counter = 0f;
			}
		}
	}

	void OnTriggerEnter (Collider col)
	{
		
			

			if (col.gameObject.name == "Player")
			{
				attackingPlayer = true;
				
				
				if (this.gameObject.name == "LumberJack")
				{
					health.takeDMG( 10f );
				}
				if (this.gameObject.name == "VillageHero")
				{
					health.takeDMG( 15f );
				}
				if (this.gameObject.name == "Enemy")
				{
					health.takeDMG( 5f );
				}
			}	
	}

	void OnTriggerExit (Collider col)
	{
		
			
			if (col.gameObject.name == "Player")
			{
				attackingPlayer = false;
				
			}
	}
}
