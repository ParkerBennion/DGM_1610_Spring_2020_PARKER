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
  // public GameObject rubberBulletPrefab;
   //public Camera shootCam;

   void Update()
   {
      verticalInput = Input.GetAxis("Vertical");
      transform.Translate(Vector3.forward*speed*Time.deltaTime*horizontalInput);
      //vertical movement
      
      horizontalInput = Input.GetAxis("Horizontal");
      transform.Translate(Vector3.left*speed*Time.deltaTime*verticalInput);
      //horizontal movement
      
      
     if (Input.GetKey(KeyCode.Space) && (JumpManager.jumper = true))
      {
         transform.Translate(Vector3.up*jumpsdis*Time.deltaTime);
         JumpManager.jumper = false;
      }
     // jump script

    /* if (Input.GetKeyDown(KeyCode.Mouse0))
     {
         Instantiate(rubberBulletPrefab, shootCam.transform.position, rubberBulletPrefab.transform.rotation);
     }
     */
   }
   
}
