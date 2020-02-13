using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
 public int nameTag, pickupType;
 public int pointsToAdd;

 private void OnTriggerEnter(Collider other)
 {
  if (other.gameObject.CompareTag("Player"))
  {
   ScoreManager.AddPoints(pointsToAdd);
   Destroy(gameObject);
  }
 }
}
