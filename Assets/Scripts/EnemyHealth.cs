using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class EnemyHealth : MonoBehaviour {
	private Image enemyHealthBar;
	private float enemyHealth;
	
	GameObject sword;


	void Start () {
	enemyHealth = 100;
	sword = GameObject.Find("Sword");

	enemyHealthBar = sword.GetComponent<Damage>().bar;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void takeDMG( float damageTaken)
    {
        enemyHealth = enemyHealth - damageTaken;
        
        enemyHealthBar.fillAmount = enemyHealth / 100f;
        if (enemyHealth <= 0f)
        {
        	Destroy();
        }
    }

    void Destroy()
    {
    	Destroy(this.gameObject);
    	
    }
}
