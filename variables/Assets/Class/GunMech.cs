using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class GunMech : MonoBehaviour
{
    public GameObject rubberBulletPrefab;
    public GameObject mag;
    public GameObject gunCam;

    public Quaternion trajectory;

    private void Start()
    {
        trajectory = Quaternion.identity;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(rubberBulletPrefab, mag.transform.position, trajectory);
            Debug.Log(gunCam.transform.rotation);
        }
    }
}
