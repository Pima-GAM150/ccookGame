using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Manager : MonoBehaviour {
	

	public static Manager singleton;
    public Tunnel startingTunnel;
	public GameObject gameOverUI;
	public GameObject winScreen;
	public int bossCounter;
	public float health;
	public int exitSpawn;
	public float currentRotation;
	public bool attackingPlayer = false;
	public AudioSource bossMusic;
	public AudioSource levelMusic;

	

    public Tunnel currentTunnel;

	void Awake()
	{
		health = 100;
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
		if( bossCounter > 2)
		{
			SceneManager.LoadScene("BossScene");
			bossMusic.volume = 0.25f;
			levelMusic.volume = 0f;
		}
		else 
		{
			bossMusic.volume = 0f;
			levelMusic.volume = 0.25f;


			SceneManager.LoadScene("LevelScene");
			GameObject enter = GameObject.Find("NewSceneTrigger");
			enter.SetActive(true);
			exitSpawn = 0;
			currentTunnel = null;
			
		}




	}

	public void GameOverScreen()
	{
		Time.timeScale = 0;
		gameOverUI.SetActive(true);
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;

	}

	public void Deactivate()
	{
		gameOverUI.SetActive(false);
		winScreen.SetActive(false);
		health = 100;
	}
	
	public void WinScreen()
	{
		Time.timeScale = 0;
		winScreen.SetActive(true);
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;

	}
	




}
