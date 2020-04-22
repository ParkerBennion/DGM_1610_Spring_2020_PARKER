using System;
using System.Collections;
using UnityEngine;

public class FireWall : MonoBehaviour
{
    private int Timer = 3;
    public int response;
    private int power;

// this script may be better served going through the game manager to recieve the variables and the changing 
// of menus only refering to this script as the menue itself where the changing of modes is needed.
    void Start()
    {
        response = 4; //need way to change switch
        
        bringTheFire();
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            //opens pause menu;
            bringTheFire();
        }
        
    }

    IEnumerator bringTheFire()
    {
        Debug.Log("Select Mode" );//add graphic on hud for modes
        int  = Convert.ToInt32(Console.ReadLine());
        if ( == )
        switch (FireWall.input)
        {
            case 1:
                print("PLAY");
                power = 10;
                break;
                
            case 2:
                print("TEST");
                power = 0;
                break;
            
            case 42:
                print("WIN");
                power = 0;
                break;
            
            case 4:
                print("Pause");
                power = 0;
                break;
            
            default:
                print("Game Over");
                power = 0;
                break;
        }
    }
}
