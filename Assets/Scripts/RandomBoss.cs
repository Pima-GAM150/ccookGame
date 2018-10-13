using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBoss : MonoBehaviour {

	public float rng = 0f;
	public GameObject ghostBoss;
	public GameObject undeadBoss;


	void Start () {
		rng = Random.Range(0f, 2f);

		if (rng >= 1f)
        {
        	GameObject newGhostBoss = Instantiate<GameObject>(ghostBoss);
        	newGhostBoss.transform.position = new Vector3(45, -5, 6);

        }
        else if (rng >= 0f)
        {
        	GameObject newUndeadBoss = Instantiate<GameObject>(undeadBoss);
        	newUndeadBoss.transform.position = new Vector3(45, -5, 6);

        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
