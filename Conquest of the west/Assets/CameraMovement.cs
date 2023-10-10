using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivityX;
    public float sensitivityY;
    public Transform orientation;
    float xRotation;
    float yRotation;

    private void Start()
    {

        //UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        //UnityEngine.Cursor.visible = false;
    }

    private void Update()
    {
        //float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivityY;
        //xRotation -= mouseY; // invert the sign of mouseY
        //yRotation += mouseX;
        //xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        //transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        //orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
