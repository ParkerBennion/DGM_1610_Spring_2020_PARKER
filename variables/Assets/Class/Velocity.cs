using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    public float speed = 50;
    public int goodbye = 3;
    void Update()
    {
        transform.Translate(  Vector3.left * Time.deltaTime * speed);
        //transform.rotation(Cursor);
        Destroy(gameObject, goodbye);
    }
}
