using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_03 : MonoBehaviour
{
    public int apple = 1, orange = 5, blueberry = 10;

    void OnMouseDown()
    {
        Gooseberry();
    }

    public void Gooseberry()
    {
        frutibowl = (apple + orange + blueberry);
        
    }

    public void OnMouseUp()
    {
        frutibowl = apple + orange + blueberry;
        public 
             string = frutibowl;
    }
}
