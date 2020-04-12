using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = System.Random;

/*public class Wanderer : MonoBehaviour
{
   public float wanderRadius;
   public float wanderTimer;

   private Transform target;
   private NavMeshAgent agent;
   private float timer;

   private void OnEnable()
   {
      agent = GetComponent<NavMeshAgent>();
      timer = wanderTimer;
   }

   private void Update()
   {
      timer += Time.deltaTime;
      if (timer>=wanderTimer)
      {
         Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
         agent.SetDestination(newPos);
         timer = 0;
      }
   }

   public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask)
   {
      Vector3 randDirection = Random.insideUnitSphere * dist; //whats wrong with this?
      randDirection += origin;
      NavMeshHit navHit;
      NavMesh.SamplePosition(randDirection, out navHit, dist, layermask);
      return navHit.position;
   }
}*/
