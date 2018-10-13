using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour {

    public Tunnel startingTunnel;
	
	public int bossCounter;
	public int health;
	public int exitSpawn;
	public float currentRotation;
	
	public static Manager singleton;

    public Tunnel currentTunnel;

	void Awake()
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
			GameObject enter = GameObject.Find("NewSceneTrigger");
			enter.SetActive(true);
			exitSpawn = 0;
			currentTunnel = null;
			
		}




	}		

	
	




}
