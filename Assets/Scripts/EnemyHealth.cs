using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour {
	public Image bar;
	public float health;
	public GameObject parent;
	void Start () {
	health = 100;	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void takeDMG( float damageTaken)
    {
        health = health - damageTaken;
        bar.fillAmount = health / 100f;
        if (health <= 0f)
        {
        	Destroy();
        }
    }

    void Destroy()
    {
    	Destroy(this.gameObject);
    }
}
