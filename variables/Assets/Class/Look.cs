using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

public class Look : MonoBehaviour
{
    public float speed = 200f;
    public Vector3 position;
    public Transform Body;
    public Transform viewingBox;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; //sets cursor mode.
    }

    void Update()
    {
        position.x = speed * Input.GetAxis("Mouse X") * Time.deltaTime; //every frome the x cordnate on positoin will equal that of the mouse.
        position.y = speed * Input.GetAxis("Mouse Y") * Time.deltaTime;

        Body.Rotate(Vector3.up * position.x); //rotates assigned unity assets with the mouse movement.
        viewingBox.Rotate(Vector3.left * position.y);


    }
}