using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyController : MonoBehaviour {
	
	public GameObject target;
	private Animator anim;
	public bool attackingPlayer;
	public EnemyDamage enemyDMG;
	public Image bar;
	public GameObject enemyHPBar;
	
	void Start()
	{
		target = GameObject.Find("Player");
		anim = GetComponent<Animator>();
		
	}

	void Update() 
	{
		
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
				
			}
			else
			{
				
					anim.SetBool("isAttacking",true);
					anim.SetBool("isIdle",false);
					
			}
		}
		
	}
}