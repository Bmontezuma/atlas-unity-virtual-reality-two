using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectStacking : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 initialPosition;
    private bool isBeingHeld = false;
    private bool hasFallen = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        initialPosition = transform.position; // Save the initial position
    }

    void Update()
    {
        if (isBeingHeld)
        {
            // Allow player to move the object (implement mouse or VR hand controls here)
            rb.isKinematic = true;  // Disable physics while held
        }
        else if (!isBeingHeld && !hasFallen)
        {
            rb.isKinematic = false;  // Enable physics when released
        }

        // Detect if the object has fallen off the platform
        if (transform.position.y < -5f)  // Arbitrary height to detect fall
        {
            hasFallen = true;
            // Optional: Play crash sound effect here
            ResetPosition();
        }
    }

    // Call this method to pick up the object
    public void PickUp()
    {
        isBeingHeld = true;
    }

    // Call this method to release the object
    public void Release()
    {
        isBeingHeld = false;
    }

    private void ResetPosition()
    {
        // Reset the object back to its initial position if it falls
        transform.position = initialPosition;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
