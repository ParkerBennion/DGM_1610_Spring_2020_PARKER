using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTrigger : MonoBehaviour
{ 
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Your in");
    }
}