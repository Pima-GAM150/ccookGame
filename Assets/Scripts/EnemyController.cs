using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyController : MonoBehaviour {
	

	public GameObject target;
	static Animator anim;
	public bool attackingPlayer;
	public float counter;
	public Image bar;
	public HealthBar healthBar;
	public GameObject enemyHPBar;

	void Start()
	{
		target = GameObject.Find("Player");
		anim = GetComponent<Animator>();
		

		counter = 0f;
	}


	void Update() 
	{
		counter += Time.deltaTime;
		if(Vector3.Distance(target.transform.position, this.transform.position) < 30)
		{
			enemyHPBar.SetActive(true);
			
			Vector3 direction = target.transform.position - this.transform.position;
			direction.y = 0;

			this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);

			if (direction.magnitude > 3)
			{
				this.transform.Translate(0,0,0.05f);
				anim.SetBool("isAttacking",false);
				anim.SetBool("isIdle",true);
				counter = 0f;
				
			}
			else
			{
				anim.SetBool("isIdle",false);
				anim.SetBool("isAttacking",true);
				
			
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
			if (this.gameObject.name == "Undead Knight")
			{
				if (counter > 1.8f)
				{
					DoDamage(5f);
				}
			}
			if (this.gameObject.name == "Undead Knight Boss")
			{
				if (counter > 1.8f)
				{
					DoDamage(15f);
				}
			}

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
