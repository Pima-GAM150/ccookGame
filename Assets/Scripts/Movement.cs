﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    private Rigidbody body;
    public float speed;
    public float rotationSpeed;
    public float jumpForce;
    private float vertical;
    private float horizontal;
    private bool isGrounded;
    GameObject player;
    public float healthRegenCounter;
    public GameObject pauseCanvas;
 
    
    void Start()
    {
        body = GetComponent<Rigidbody>();
        player = this.transform.gameObject;

    }
    
    void FixedUpdate()
    {
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");
        
        if( Input.GetButtonDown("Cancel"))
        {
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            pauseCanvas.SetActive(true);
        }
        if (Input.GetAxis("Jump") > 0)
        {
            if (isGrounded)
            {
                body.AddForce(transform.up * jumpForce);
            }
        }
        
      

        Vector3 velocity = ((transform.forward * vertical) + (transform.right * horizontal)) * speed * Time.fixedDeltaTime;

        velocity.y = body.velocity.y;
        body.velocity = velocity;
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            isGrounded = false;
        }
    }
    void Update () 
    {
        //healthRegenCounter += Time.deltaTime;
        if (healthRegenCounter > 5f)
        {
            Regen();
        }
    }

    

    public void Regen()
    {
      Manager.singleton.health = Manager.singleton.health + 10;
      healthRegenCounter = 0f;

    }       

}
