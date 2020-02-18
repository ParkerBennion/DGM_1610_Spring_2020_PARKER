using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.UIElements;
using Cursor = UnityEngine.Cursor;

//this code demands a character controller and will make one when this script is applied
public class Look : MonoBehaviour
{
    public float speed = 200f;
    public Vector3 position;
    public Transform Body;
    public Transform viewingBox;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        position.x = speed * Input.GetAxis("Mouse X") * Time.deltaTime;
        position.y = speed * Input.GetAxis("Mouse Y") * Time.deltaTime;

        Body.Rotate(Vector3.up * position.x);
        viewingBox.Rotate(Vector3.left * position.y);


    }
}