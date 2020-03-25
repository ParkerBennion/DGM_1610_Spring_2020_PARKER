using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{
    
    enum Days{Sun,Mon,Tues,Wed,Thurs,Fri,Sat};

    private Days currentDay;
        private void Start()
        {
            currentDay = Days.sat;
        }

        private void Update()
        {
            if (currentDay == Days.Fri)
            {
                print("is break time");
            }
        }
}
