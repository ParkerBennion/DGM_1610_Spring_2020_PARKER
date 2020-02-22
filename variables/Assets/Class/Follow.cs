using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
    public Vector3 target;
    public int moveSpeed = 5;
    void Update()
    {
        player = GameObject.Find("Sphere"); //targets the sphere by name every frame and stores data in player
        target = player.transform.position; //takes the variable player and converts cordnates into a vector 3 named "target"
        transform.LookAt(target); //rotates to look at vector 3 variable target.
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime); //moves forward constantly.
    }
}
