using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthBar : MonoBehaviour {
   public Image bar;
   public float health;



    void Start () {
		health = 100f;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void takeDMG( float damageTaken)
    {
        
        health = health - damageTaken;
        
        bar.fillAmount = health / 100f;

        if (health == 0f)
        {
          //pause time and show gameover screen
        }
    }
}
