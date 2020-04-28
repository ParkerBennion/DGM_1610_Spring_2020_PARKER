using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpeed : Admin
{
    private float wallspeed = 0f,delay = 9f;
    //make this variable reside within the game manager and suseptable to a switch.
    void Update()
    {
        transform.Translate(  Vector3.forward * Time.deltaTime * wallspeed);
        StartCoroutine(faster());
    }
    IEnumerator faster()
    {
        wallspeed += .01f;
        yield return new WaitForSeconds(delay);
        StartCoroutine(faster());
    }
    void OnTriggerEnter(Collider other)
    {
        if (speed > 0)
        {
            speed = 0;
            Debug.Log("Game Over "+"you scored "+ player.transform.position.z);
        }
        
    }
}
