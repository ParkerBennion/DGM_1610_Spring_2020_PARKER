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

    private void Start()
    {
    }

    void Update()
    {
        trajectory = transform.rotation;
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Instantiate(rubberBulletPrefab, mag.transform.position, trajectory);
        }
        Debug.Log(trajectory);
    }
}
