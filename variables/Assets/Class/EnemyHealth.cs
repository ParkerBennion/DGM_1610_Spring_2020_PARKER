using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int currentHealth, maxHealth = 3;
    public Transform spawnPoint;
    public int points = 10;
    void Start()
    {
        currentHealth = maxHealth;
        spawnPoint = GameObject.Find("SpawnArea").transform;
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0)
        {
            currentHealth = 0;
            print("Enemy is Killed");
            transform.position = spawnPoint.position;
            transform.rotation = spawnPoint.rotation;
            currentHealth = maxHealth;
        }
    }
}
