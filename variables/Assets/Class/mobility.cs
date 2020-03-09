using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;
using Object = UnityEngine.Object;

public class mobility : MonoBehaviour
{
   public float speed = 10f, verticalInput, horizontalInput, jumpsdis = 3f;
   public Vector3 jumpVector;
   public int jumper;

   private void Start()
   {
       jumper = 1;
   }

   void Update()
   {
       horizontalInput = Input.GetAxis("Horizontal");
       transform.Translate(Vector3.forward * speed * Time.deltaTime * horizontalInput);
       //vertical movement

       verticalInput = Input.GetAxis("Vertical");
       transform.Translate(Vector3.left * speed * Time.deltaTime * verticalInput);
       //horizontal movement


       /*if (Input.GetKeyDown(KeyCode.Space) && jumper => 1)
        {
            GetComponent<Rigidbody>().AddForce(jumpVector,ForceMode.VelocityChange);
           //transform.Translate(Vector3.up*jumpsdis*Time.deltaTime);
           jumper = 0;
        }
     }
  
     private void OnCollisionEnter(Collision other)
     {
         if (other.gameObject.CompareTag("Floor"))
         {
             jumper = 1;
         }
         */
     }
     
  
   }
