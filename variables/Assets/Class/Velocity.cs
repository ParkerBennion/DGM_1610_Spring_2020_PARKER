using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    public float speed = 50;
    public int goodbye = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(  transform.forward * Time.deltaTime * speed);
        Destroy(gameObject, goodbye);
    }
}
