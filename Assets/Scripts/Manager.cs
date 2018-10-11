using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

	
	public int bossCounter;
	public int health;
	public int rng;
	public static Manager singleton;

	void Start()
	{
		if (singleton == null)
		{
			singleton = this;
			DontDestroyOnLoad( this.gameObject);
		}
		else
		{
			Destroy( this.gameObject);
		}
	}

	public void LoadNewScene()
	{
		bossCounter++;
		if( bossCounter > 5)
		{
			SceneManager.LoadScene("BossScene");
		}
		else 
		{
			SceneManager.LoadScene("LevelScene");
		}


	}		

	public void LoadTunnel()
	{
		rng = new Random.Range(0, 3);
		if (rng == 2)
		{

		}

		if (rng == 1)
		{

		}

		if (rng == 0)
		{

		}



	}
	




}
