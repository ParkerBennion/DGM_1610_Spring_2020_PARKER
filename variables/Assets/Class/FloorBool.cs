using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorBool : MonoBehaviour
{
    public bool jumpFalse;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            JumpManager.resetJump(jumpFalse);
        }
    }
}

