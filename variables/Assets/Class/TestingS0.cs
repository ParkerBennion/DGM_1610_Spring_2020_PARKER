using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingS0 : MonoBehaviour
{
    public SO data;

    private GameObject model;

    private void Start()
    {
        model = data.model;

        var modelRend = model.GetComponent<Renderer>();
        modelRend.sharedMaterial.SetColor("_Color",data.color);
        
        print(data.nametag);
        print(data.description);
    }

    private void Update()
    {
        
    }
}
