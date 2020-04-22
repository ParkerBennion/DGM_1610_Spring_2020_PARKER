using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 10f, verticalInput, horizontalInput;
    public int ground=5;
    public int height=100000;
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
        if (Input.GetKeyDown(KeyCode.Space)&& ground >= 1)
        {
            rb.velocity = transform.up * height * Time.deltaTime;
            //transform.Translate(Vector3.up*height*Time.deltaTime);
            ground -= 1;
            Debug.Log(ground);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Ground")&& ground < 1)
        {
            ground += 1;
            Debug.Log(ground);
        }
    }
}