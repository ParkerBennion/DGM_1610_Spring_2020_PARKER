using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpManager : MonoBehaviour
{
 public static bool jumper;

 private void Start()
 {
  jumper = false;
 }

 public static void resetJump(bool jumpFalse)
 {
  jumper = true;
  Debug.Log("i can jump again.");
 }
}
