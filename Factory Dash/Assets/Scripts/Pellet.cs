using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pellet : MonoBehaviour
{
    public int damage = 1;
    public int time = 5;
    public int zoom = 20;
    private Rigidbody rbp;
    
    void Start()
    {
        StartCoroutine(DestroyBullet());
        rbp = GetComponent<Rigidbody>();
        rbp.velocity = transform.forward * zoom * Time.deltaTime;
    }

   /* private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            var hit = other.gameObject;
            var health = hit.GetComponent<EnemyHealth>();

            if (health != null)
            {
                health.TakeDamage(damage);
            }
            Debug.Log("you hit me for "+damage+" damage i have "+ health +"left");
        }
    }*/

    private void Update()
    {
       // transform.Translate(Vector3.up* zoom * Time.deltaTime);
       // rbp.velocity = transform.forward * zoom * Time.deltaTime;
    }

    IEnumerator DestroyBullet()
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }
} 
