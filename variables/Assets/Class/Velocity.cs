using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    public float speed = 50;
    public int goodbye = 2;
    public float timedelay= .1f;
    void Update()
    {
        //transform.Translate(Vector3.right*Time.deltaTime*timedelay); starting to make deceleratoin.
        transform.Translate(  Vector3.left * Time.deltaTime * speed);
        //transform.rotation(Cursor);
        Destroy(gameObject, goodbye);
    }
}
