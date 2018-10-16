using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class EnemyHealth : MonoBehaviour {
	public Image bar;
	public float enemyHealth;
	public GameObject enemyHPBar;
	


	void Start () {
	enemyHealth = 100;
	enemyHPBar = GameObject.Find("EnemyHP BG");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void takeDMG( float damageTaken)
    {
        enemyHealth = enemyHealth - damageTaken;
        bar.fillAmount = enemyHealth / 100f;
        if (enemyHealth <= 0f)
        {
        	Destroy();
        }
    }

    void Destroy()
    {
    	Destroy(this.gameObject);
    	enemyHPBar.SetActive(false);
    }
}
