using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfAware : MonoBehaviour
{
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
