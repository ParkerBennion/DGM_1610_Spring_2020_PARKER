using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth;
    public int maxHealth = 3;
    //publics can be changed in inspector. privates cannot

    public Transform spawnPoint;
    public int points;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        //short hand for taking current health minus what is equal to the amound taken away;

        if (currentHealth <= 0)
        {
            currentHealth = 0;
            Debug.Log("ouch you lose");
            
            
        }
    }
    
}
