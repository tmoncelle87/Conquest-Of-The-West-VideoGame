using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatFloat : MonoBehaviour
{
    public float amplitude = 1f;  // the amplitude of the boat float
    public float frequency = 1f;  // the frequency of the boat float
    public float startY = 9f;     // the starting Y position of the boat float
    public float endY = 12f;      // the ending Y position of the boat float
    public float speed = 1f;      // the speed of the boat float

    private Vector3 startPos;     // the starting position of the boat
    private float offset;         // the offset for the boat float
    private Rigidbody rb;         // the rigidbody component of the boat

    private void Start()
    {
        startPos = transform.position;  // save the starting position of the boat
        offset = Random.Range(0f, 1f * Mathf.PI);  // randomize the offset for the boat float
        rb = GetComponent<Rigidbody>();  // get the rigidbody component of the boat
        rb.isKinematic = true;  // make the rigidbody kinematic
    }

    private void FixedUpdate()
    {
        // calculate the Y position of the boat based on the current time
        float posY = Mathf.Lerp(startY, endY, Mathf.PingPong(Time.time * frequency, 1f));

        // add the boat float to the Y position
        float floatY = startPos.y + Mathf.Sin(offset + Time.time * frequency) * amplitude;

        // calculate the velocity of the boat based on the speed and direction
        Vector3 direction = new Vector3(0f, 0f, speed);
        Vector3 velocity = direction.normalized * speed;

        // set the velocity of the rigidbody
        rb.velocity = velocity;

        // set the position of the boat based on the float and Y position
        transform.position = new Vector3(startPos.x, floatY + posY, startPos.z);
    }
}
