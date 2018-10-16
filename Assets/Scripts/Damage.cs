using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : CamMovement {
	
	public bool canAttack;
	public bool canDealDMG;
	public EnemyHealth enemyHP;
	public GameObject enemy;
	
	void Start () {
		
		canAttack = true;
		anim = gameObject.GetComponentInParent<Animator>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		
		if (Input.GetMouseButtonDown(0))
       {
            anim.SetTrigger("attack");
            
            if(canDealDMG == true)
            {
            	dealDMG();
            }
        	

       }
       
       
	}

	void OnTriggerEnter (Collider col)
	{
		if(canAttack == true)
		{	

			if (col.gameObject.tag == "Enemy")
			{
				enemy = col.gameObject;
				
				canDealDMG = true;
				Debug.Log("I am hitting this " + enemy);
				canAttack = false;
			
			}
		}
		else
		{
			canAttack = false;
		}	
	}

	void OnTriggerExit (Collider col)
	{
		
			
			if (col.gameObject.tag == "Enemy")
			{
				
				canDealDMG = false;
				canAttack = true;
			}
	}

	void dealDMG()
	{
		if(enemy.tag == "Enemy")
		{
			enemyHP = enemy.GetComponent<EnemyHealth>();
			enemyHP.takeDMG(25f);
			
		}
		else
		{
			enemyHP = enemy.GetComponent<EnemyHealth>();
			enemyHP.takeDMG(18f);
			
		}

	}
}
