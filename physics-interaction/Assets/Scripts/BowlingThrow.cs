using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BowlingThrow : MonoBehaviour
{
    public XRController xrController;      // Reference to the controller
    public Rigidbody bowlingBall;          // The bowling ball object (RigidBody)
    public Transform handTransform;        // The transform of the hand or controller

    private Vector3 previousPosition;      // To track the controller's position from the last frame
    private Quaternion previousRotation;   // To track angular velocity

    private Vector3 velocity;              // Calculated velocity
    private Vector3 angularVelocity;       // Calculated angular velocity

    private bool isHoldingBall = false;    // Whether the player is holding the ball

    public float releaseVelocityMultiplier = 1.5f;   // To tweak throw strength
    public float releaseAngularVelocityMultiplier = 1.0f; // To tweak spin strength

    void Start()
    {
        // Initialize previousPosition and previousRotation
        previousPosition = handTransform.position;
        previousRotation = handTransform.rotation;
    }

    void Update()
    {
        if (isHoldingBall)
        {
            // Calculate velocity based on change in position over time
            velocity = (handTransform.position - previousPosition) / Time.deltaTime;

            // Calculate angular velocity based on change in rotation over time
            Quaternion deltaRotation = handTransform.rotation * Quaternion.Inverse(previousRotation);
            angularVelocity = new Vector3(deltaRotation.x, deltaRotation.y, deltaRotation.z) / Time.deltaTime;

            // Update previous values for the next frame
            previousPosition = handTransform.position;
            previousRotation = handTransform.rotation;

            // Release the ball if the trigger is released
            if (xrController.inputDevice.TryGetFeatureValue(UnityEngine.XR.CommonUsages.triggerButton, out bool triggerPressed) && !triggerPressed)
            {
                ReleaseBall();
            }
        }
    }

    // Function to pick up the ball
    public void GrabBall()
    {
        isHoldingBall = true;
        bowlingBall.isKinematic = true;  // Disable physics while holding the ball
        bowlingBall.transform.SetParent(handTransform);  // Attach the ball to the hand
        previousPosition = handTransform.position;  // Reset previous position to current
        previousRotation = handTransform.rotation;  // Reset previous rotation to current
    }

    // Function to release the ball
    public void ReleaseBall()
    {
        isHoldingBall = false;
        bowlingBall.transform.SetParent(null);  // Detach the ball from the hand
        bowlingBall.isKinematic = false;  // Enable physics on the ball

        // Apply the calculated velocity and angular velocity to the ball
        bowlingBall.velocity = velocity * releaseVelocityMultiplier;
        bowlingBall.angularVelocity = angularVelocity * releaseAngularVelocityMultiplier;
    }
}
