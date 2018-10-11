using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Settings : MonoBehaviour {

	public Slider mouseSensSlider;


	public GameObject playerCamera;
	public CamMovement camMove;
	// Use this for initialization
	void Start () {
		camMove = playerCamera.GetComponent<CamMovement>();

	}
	
	// Update is called once per frame
	void OnMouseDrag () {
		camMove.sensitivity = camMove.sensitivity * mouseSensSlider.value; 
	}
}
