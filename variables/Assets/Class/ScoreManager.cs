using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    private void Start()
    {
        score = 0;
    }
    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        Debug.Log("Game Score: " + score);
    }
}
