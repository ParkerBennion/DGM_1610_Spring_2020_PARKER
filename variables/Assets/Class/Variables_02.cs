using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_02 : MonoBehaviour
{
    public int apple = 1, orange = 5, blueberry = 10;

    void OnMouseDown()
    {
        Gooseberry();
    }

    public void Gooseberry()
    {
        Debug.Log(apple + orange + blueberry);
    }
    //click on it and i does math for you.
}
