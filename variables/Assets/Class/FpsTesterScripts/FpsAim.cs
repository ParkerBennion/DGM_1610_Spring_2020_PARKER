using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class FpsAim : MonoBehaviour
{
    public Vector3 vector;
    public float spin;
  
    void Update()
    {
        Debug.Log(transform.rotation);
    }
}
