using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int apple = 1, orange = 5, blueberry = 10;

    void Start()
    {
        Debug.Log(apple + orange + blueberry - apple - apple);
        //algebra is fun
        
    }
}
