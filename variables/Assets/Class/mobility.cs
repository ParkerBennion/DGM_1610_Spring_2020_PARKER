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
   public float speed, verticalInput, horizontalInput, jumpsdis = 3f;

   void Update()
   {
      verticalInput = Input.GetAxis("Vertical");
      transform.Translate(Vector3.forward*speed*Time.deltaTime*horizontalInput);
      //vertical movement
      
      horizontalInput = Input.GetAxis("Horizontal");
      transform.Translate(Vector3.left*speed*Time.deltaTime*verticalInput);
      //horizontal movement
      
     if (Input.GetKeyDown(KeyCode.X) && (JumpManager.jumper = true))
      {
         transform.Translate(Vector3.up*jumpsdis*Time.deltaTime);
         JumpManager.jumper = false;
      }
//added conditional jump script but the script is based on wrong condition.
   }
   
}
