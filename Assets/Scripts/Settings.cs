using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Settings : MonoBehaviour {

	

    
	
	public CamMovement camMove;
	
	
	
	// Update is called once per frame
	public void OnMouseDrag (float value) {
        float sens;
        sens = camMove.sensitivity * value;
        PlayerPrefs.SetFloat("Camera Sensitivity", sens);

	}


}
