using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class HealthBar : MonoBehaviour {
  public Image bar;
  
  public float healthRegenCounter;


  void Start () 
  {
		;
	}
	
	// Update is called once per frame
	void Update () 
  {
    if (health >= 100)
    {
      healthRegenCounter = 0f;
      health = 100;
    }
    bar.fillAmount = health / 100f;
    healthRegenCounter += Time.deltaTime;
		if (healthRegenCounter > 4f)
    {
      Regen();
    }

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

    public void Regen()
    {
      health = health + 10;
      healthRegenCounter = 0f;
     
    }

    public float health
    {
        get { return Manager.singleton.health; }
        set { Manager.singleton.health = value; }
    }
}
