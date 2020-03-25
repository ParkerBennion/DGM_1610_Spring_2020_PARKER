using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour
{
    public string superHero;
    
    //switches can be used to more eficeintly do if and else if statements
    
    void Start()
    {
        switch (superHero)
        {
            case "superman" :
                print("wrong!");
                break;
                
            case "Thor" :
                print("correct");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
