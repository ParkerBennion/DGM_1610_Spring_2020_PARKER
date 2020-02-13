using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    public float speed = 50;
    public int goodbye = 3;
    void Update()
    {
        transform.Translate(  -transform.right * Time.deltaTime * speed);
        Destroy(gameObject, goodbye);
    }
}
