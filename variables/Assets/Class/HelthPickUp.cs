using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelthPickUp : Pickup
{
    public int healthAmt = 100;
    
    void Start()
    {
        print("you gained" + healthAmt + "health!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
