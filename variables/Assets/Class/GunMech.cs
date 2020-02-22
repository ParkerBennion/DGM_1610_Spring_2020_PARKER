using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class GunMech : MonoBehaviour
{
    public GameObject rubberBulletPrefab;
    public GameObject mag;

    public Quaternion trajectory;

    void Update()
    {
        trajectory = transform.rotation; //records data in qaternion of the objects rotation and updates every frame.
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(rubberBulletPrefab, mag.transform.position, trajectory); // on left click spawn (insert variable X) at (insert variable Y) with rotation matching "trajectory"
        }
        Debug.Log(trajectory); //display current trajectory
    }
}
