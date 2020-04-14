using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int damage = 2;
    public int time = 3;

    private void Start()
    {
        Destroy(gameObject, time);
        //this line of code and DestroyBullet in this scenario serve the same function. having both is redundant
        StartCoroutine(DestroyBullet());//this runs coroutene below.
    }

    private void OnCollisionEnter(Collision other)
    {
        var health = other.gameObject.GetComponent<EnemyHealth>();

        if (health != null)
        {
            health.TakeDamage(damage);
        }
        // for this to funcion a take damage and an enemyHealth coroutene and data need to be made.
    }

    IEnumerator DestroyBullet()
    {
        yield return  new WaitForSeconds(time);
        
    }
}
