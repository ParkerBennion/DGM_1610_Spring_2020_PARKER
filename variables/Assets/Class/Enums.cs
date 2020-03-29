using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enums : MonoBehaviour
{

    public enum ColorSelector
    {
        Red,
        Blue,
        Green,
        Yellow
    }

    public ColorSelector CurrentColor;

    private void Start()
    {
        CurrentColor = ColorSelector.Blue;
        switch (CurrentColor)
        {
            case ColorSelector.Blue:
                Debug.Log("you selected blue");
                if (Time.time > 5)
                {
                    CurrentColor = ColorSelector.Yellow;
                }
                // this does not change in start because time is at 0 when the game starts and code block ends process
                break;
            case ColorSelector.Green:
                Debug.Log("you selected green");
                break;
            case ColorSelector.Red:
                Debug.Log("you selected red");
                break;
            case ColorSelector.Yellow:
                Debug.Log("you selected yellow");
                break;
        }
    }
}