using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicTrigger : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        Adminium.floor += 1;
    }
}
