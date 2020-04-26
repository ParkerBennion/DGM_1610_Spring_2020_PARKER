using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admin : MonoBehaviour
{
    public static int playerHealth, playerJump, playerPower; //making this a static variable makes it the same across all children scripts even after the game has started (hypothesis)
    private void Start()
    {
        playerJump = 0;
    }

    
}
