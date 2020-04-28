using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Admin : MonoBehaviour
{
    public static int playerHealth, playerJump, playerPower;
    protected static float speed = 10f;//making this a static variable makes it the same across all children scripts even after the game has started (hypothesis)
    public Rigidbody player;
    private void Start()
    {
        playerJump = 0;
        speed = 10;
    }
    
}
