﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : Admin
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Speed Boost. Speed = "+ speed);
        speed += 2;
    }
}