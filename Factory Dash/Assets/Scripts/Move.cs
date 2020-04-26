using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;

public class Move : Admin
{
    public float speed = 10f, verticalInput, horizontalInput;
    public int height=1;
    private Rigidbody rb;
    private TagField Ground;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward* speed * Time.deltaTime * verticalInput);
        if (Input.GetKeyDown(KeyCode.Space)&& playerJump >= 1)
        {
            rb.velocity = transform.up * height * Time.deltaTime;
            //transform.Translate(Vector3.up*height*Time.deltaTime);
            playerJump -= 1;
            Debug.Log(playerJump + " A jump was used");
        }
        
    }
   /* void OnTriggerEnter(Collider other)
    {
        if (CompareTag("Ground")&& playerJump < 1)
        {
            playerJump += 1;
        }
    }*/
}