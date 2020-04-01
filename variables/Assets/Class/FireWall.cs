using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
public enum Difficulty{Easy, Medium, Hard, Insane,}
public class FireWall : MonoBehaviour
{
    private int Timer = 3;
    public int Judge = 0;

    private int power;
    //private int Difficulty = 1;
    
    
        void Start()
        {
            switch (Difficulty.Easy) //need way to change switch
            
        {
            case Difficulty.Easy:
                print("Easy Mode");
                power = 10;
                break;
                
            case Difficulty.Medium:
                print("Normal Mode");
                power = 15;
                break;
            
            case Difficulty.Hard :
                print("Hard Mode");
                power = 20;
                break;
            
            case Difficulty.Insane:
                power = 30;
                break;
            
            default:
                print("test game");
                power = 0;
                break;
        }
        StartCoroutine(bringTheFire());
    }

    IEnumerator bringTheFire()
    {
        yield return new WaitForSeconds(Timer);
        Debug.Log("Begin!");
        transform.Translate(Vector3.forward*power*Time.deltaTime);
        
        //only moves for a brief moment.
    }
}
