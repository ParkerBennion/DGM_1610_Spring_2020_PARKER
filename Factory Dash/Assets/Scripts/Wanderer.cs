using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.AI;

/*public class Wanderer : MonoBehaviour
{
    public float wanderRadius, wanderTimer, alertDist, attackDist;
    private float timer, distance;
    public Transform target;
    private NavMeshAgent agent;
    private Vector3 heading;

    private int speed;
    // Start is called before the first frame update
    private void OnEnable()
    {
        agent = GetComponent<NavMeshAgent>();
        timer = wanderTimer;
    }

    private void Start()
    {
        distance = Vector3.Distance(target.position, transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(target.position, transform.position);

        if (distance < alertDist && distance > attackDist)
        {
            print("Enemy Is Coming");
            speed += 2;
            transform.LookAt(target);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (distance<= alertDist)
        {
         print("Enemy is following you");
         heading = target.position - transform.position;
         heading.y = 0;
         speed += 5;
         transform.LookAt(target);
         transform.LookAt(target);
         transform.Translate(Vector3.forward*speed*Time.deltaTime);
         if (heading.magnitude <= attackDist)
         {
             print("Your in his space");
         }
        }
        else if (distance> )
        {
            
        }
    }
}*/
