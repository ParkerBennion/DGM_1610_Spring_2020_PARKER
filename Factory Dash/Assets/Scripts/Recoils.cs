using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoils : MonoBehaviour
{
    public int bounce=1, punchBack = 5;
    public Transform body;
    public float time, delay;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartCoroutine(recoil());
        }
    }
    IEnumerator recoil()
    {
        transform.Translate(Vector3.right*punchBack*Time.deltaTime);
        yield return new WaitForSeconds(delay);
        body.Rotate(Vector3.left * bounce);
        StartCoroutine(Reorientation());
    }
    IEnumerator Reorientation()
    {
        yield return new WaitForSeconds(time);
        body.Rotate(Vector3.right * bounce);
    }
}
