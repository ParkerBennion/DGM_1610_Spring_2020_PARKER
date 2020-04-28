using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.UIElements;

public class JumpTest : MonoBehaviour
{
    public int playerJump;
    public int height=30;
    public Rigidbody rb;
    //Rigidbody Char;

    private void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space))
               {
                   rb.velocity = transform.up * height * Time.deltaTime;
                   Debug.Log(playerJump + " A jump was used");
               }
    }
}
