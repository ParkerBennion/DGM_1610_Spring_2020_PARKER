using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpeed : Admin
{
    void OnTriggerEnter(Collider other)
    {
        speed += 2;
        Debug.Log("Speed Boost PlayerJump = "+ speed);
        Destroy(gameObject);
    }
}