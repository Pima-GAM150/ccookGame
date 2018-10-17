using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour {
	
    public float lookYAngleLimit;
    Quaternion startingRot;
    Quaternion startingPlayerRot;

    public float sensitivity { get; set; }
    GameObject player;
    Animator anim;
    
    void Start()
    {
        sensitivity = PlayerPrefs.GetFloat("Camera Sensitivity", 5f);
        Cursor.visible = false;
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
        player = this.transform.parent.gameObject;
 
        startingRot = transform.localRotation;
        startingPlayerRot = player.transform.localRotation;
    }

    void LateUpdate() {
        float mouseX = Input.GetAxis( "Mouse X" ) * sensitivity;
        float mouseY = Input.GetAxis( "Mouse Y" ) * sensitivity;

        Quaternion xRot = Quaternion.AngleAxis( mouseX, Vector3.up );
        Quaternion yRot = Quaternion.AngleAxis( -mouseY, Vector3.right );

        Quaternion deltaRotY = startingRot * transform.localRotation * yRot;
        float angleRange = Quaternion.Angle( startingRot, deltaRotY );

        player.transform.localRotation = startingPlayerRot * player.transform.localRotation * xRot;

        if( angleRange < lookYAngleLimit ) {
            transform.localRotation = deltaRotY;
        }
    }
}
