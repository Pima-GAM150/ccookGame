using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tunnel : MonoBehaviour {

    public GameObject socket;

    void Start() {
    	if( Manager.singleton.startingTunnel == null ) {
    		Manager.singleton.startingTunnel = this;
    	}

    	if( Manager.singleton.currentTunnel == null ) {
    		Manager.singleton.currentTunnel = this;
    	}
    }
}
