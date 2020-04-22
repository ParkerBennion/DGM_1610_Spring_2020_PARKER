using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpeed : MonoBehaviour
{
    public float speed = 5;
    //make this variable reside within the game manager and suseptable to a switch.
    void Update()
    {
        transform.Translate(  Vector3.forward * Time.deltaTime * speed);
    }
}
