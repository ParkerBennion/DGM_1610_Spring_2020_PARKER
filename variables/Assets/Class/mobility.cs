using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

public class mobility : MonoBehaviour
{
   public float speed, verticalInput, horizontalInput, jumpspeed;

   void Update()
   {
      verticalInput = Input.GetAxis("Vertical");
      horizontalInput = Input.GetAxis("Horizontal");
      transform.Translate(Vector3.forward*speed*Time.deltaTime*horizontalInput);
      //transform.Translate(Vector3.up*jumpspeed*Time.deltaTime*OnCollisionEnter);
      transform.Translate(Vector3.left*speed*Time.deltaTime*verticalInput);
      //add translate scripts
      //fixed camera
      //fixed orientation
   }

   private void OnCollisionEnter(Collision other)
   {
      if (other.gameObject.CompareTag("Floor"))
      {
         Debug.Log("ouch!!!!");
      }
      else if (other.gameObject.CompareTag("Object"))
      {
         Debug.Log("I've been stopped");
      }
      else
      {
         Debug.Log("Its quiet");
      }
   }

   private void OnTriggerEnter(Collider other)
   {
      Debug.Log("You are in the dangerzone!");
   }
   
}
