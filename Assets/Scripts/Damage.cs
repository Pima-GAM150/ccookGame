using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Damage : CamMovement {
	
	public bool canAttack;
	public bool canDealDMG;
	public EnemyHealth enemyHP;
	public GameObject enemy;
	public HealthBar healthBar;
	public GameObject playerHPBar;
	public GameObject enemyHPBar;
	public Image bar;
	


	void Start () {
		
		canAttack = true;
		anim = gameObject.GetComponentInParent<Animator>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		
		if (Input.GetMouseButtonDown(0))
       {
           anim.SetTrigger("attack");
           
       }
       
       
	}

	void OnTriggerEnter (Collider col)
	{
		

			if (col.gameObject.tag == "Enemy")
			{
				enemy = col.gameObject;
				enemyHPBar.SetActive(true);

				//bar.fillAmount = enemyHealth / 100f;
				dealDMG();
				Debug.Log("I am hitting this " + enemy);
				
			
			}
		
		
	}

	

	void dealDMG()
	{
		if(enemy.tag == "Enemy")
		{
			enemyHP = enemy.GetComponent<EnemyHealth>();
			enemyHP.takeDMG(25f);
			
		}
		if(enemy.tag == "Boss")
		{
			enemyHP = enemy.GetComponent<EnemyHealth>();
			enemyHP.takeDMG(18f);
			
		}

	}
}
