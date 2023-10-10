using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Quaternion initialRotation;
    public Transform shipFacingDirection;
    public float shipRotattionSpeed;
    float shipAngle;

    public float boatMovementSpeed;
    float horizontalInput;
    float verticalInput;
    Vector3 moveDirection;
    Rigidbody rb;
    public Transform orientation;
    void Start()
    {
        //initialRotation = transform.rotation;
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }
    private void FixedUpdate()
    {
        MoveBoat();
    }
    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }
    // Update is called once per frame
    void Update()
    {

        // shipAngle += Input.GetAxis("Mouse Y") * shipRotattionSpeed * -Time.deltaTime;
        //shipAngle = Mathf.Clamp(shipAngle, 0, 360);
        //shipFacingDirection.localRotation = Quaternion.AngleAxis(shipAngle, Vector3.up);

        float mouseHorizontal = Input.GetAxis("Mouse X");

        if (Mathf.Abs(mouseHorizontal) > 0)
        {
            transform.Rotate(0, mouseHorizontal * shipRotattionSpeed * Time.deltaTime, 0);
        }
        //else
        //{
        //    transform.rotation = initialRotation;
        //}
        MyInput();

    }
    private void MoveBoat()
    {
        moveDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(moveDirection.normalized * boatMovementSpeed, ForceMode.Force);

    }

}
