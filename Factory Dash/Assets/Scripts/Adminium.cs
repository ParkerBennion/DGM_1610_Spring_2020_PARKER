using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Admin",menuName = "Karen")]
public class Adminium : ScriptableObject
{
    public int jump, ammo, stamina, health;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //sets cursor mode.
    }
    
}
