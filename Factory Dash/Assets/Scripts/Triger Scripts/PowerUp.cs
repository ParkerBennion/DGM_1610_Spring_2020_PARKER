using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Admin
{
    void OnTriggerEnter(Collider other)
    {
        playerJump += 1;
            Debug.Log("Jump Boost PlayerJump = "+ playerJump);
            Destroy(gameObject);
    }
}
