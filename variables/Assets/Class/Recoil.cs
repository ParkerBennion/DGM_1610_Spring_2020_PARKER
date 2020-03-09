using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recoil : MonoBehaviour
{
    public int bounce=3, punchBack = 5;
    public Transform body, viewingBox;
    public float time;

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            transform.Translate(Vector3.right*punchBack*Time.deltaTime);
            body.Rotate(Vector3.left * bounce);
            StartCoroutine(Reorientation());
        }
    }
    IEnumerator Reorientation()
    {
        yield return new WaitForSeconds(time);
        body.Rotate(Vector3.right * bounce);
    }
}
