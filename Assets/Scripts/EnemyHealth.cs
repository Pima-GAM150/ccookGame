﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class EnemyHealth : MonoBehaviour {
	private Image enemyHealthBar;
	public float enemyHealth;
	
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
        Debug.Log("I did damage");
        if (enemyHealth <= 0f)
        {
        	Destroy();
        }
    }

    void Destroy()
    {
    	if(this.gameObject.name == "Ghost Boss")
    	{
    		Manager.singleton.WinScreen();
    	}
    	if(this.gameObject.name == "Undead Knight Boss")
    	{
    		Manager.singleton.WinScreen();
    	}
    	else
    	{
    		Destroy(this.gameObject);
    	}
    }
}
