using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunMech : MonoBehaviour
{
    public GameObject rubberBulletPrefab;
    public GameObject mag;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(rubberBulletPrefab, mag.transform.position, mag.transform.rotation);
        }
    }
}
