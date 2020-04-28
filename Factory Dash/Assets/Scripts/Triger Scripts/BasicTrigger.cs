using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTrigger : Admin
{ 
    void OnTriggerEnter(Collider other)
    {
        if (playerJump < 1)
        {
            playerJump += 1;
            Debug.Log("Your in. PlayerJump = "+ playerJump); 
        }
        
    }
}
