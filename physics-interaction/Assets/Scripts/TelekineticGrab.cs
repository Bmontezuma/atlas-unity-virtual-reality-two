using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;

public class TelekineticGrab : MonoBehaviour
{
    public XRController xrController;          // The VR controller
    public float maxGrabDistance = 10f;        // Maximum distance for grabbing
    public float grabSpeed = 5f;               // Speed of the object flying towards the hand
    public float forceMultiplier = 10f;        // Multiplier for force pulse
    public Transform handTransform;            // Where the object should fly to (the hand)
    public LayerMask grabbableLayer;           // LayerMask for grabbable objects

    private LineRenderer lineRenderer;         // Laser pointer
    private GameObject hoveredObject = null;   // Object being hovered over
    private GameObject grabbedObject = null;   // Object currently grabbed
    private bool isGrabbing = false;           // Whether an object is being grabbed
    private float grabForceTime = 0f;          // Duration for which the grab button is held

    void Start()
    {
        // Set up the LineRenderer for the laser pointer
        lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = Color.green;
    }

    void Update()
    {
        // Update laser pointer
        UpdateLaserPointer();

        // Check if the controller's trigger is pressed and handle grabbing
        if (xrController.inputDevice.IsPressed(InputHelpers.Button.Trigger, out bool isPressed))
        {
            if (isPressed)
            {
                grabForceTime += Time.deltaTime; // Increment force charge time
                TryGrabObject();                // Attempt to grab the object
            }
            else if (isGrabbing)
            {
                ReleaseObject();                // Release the object when the trigger is released
            }
        }
    }

    void UpdateLaserPointer()
    {
        lineRenderer.SetPosition(0, handTransform.position);
        Ray ray = new Ray(handTransform.position, handTransform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, maxGrabDistance, grabbableLayer))
        {
            lineRenderer.SetPosition(1, hit.point);

            // Highlight the object being hovered over
            if (hoveredObject != hit.collider.gameObject)
            {
                if (hoveredObject != null)
                {
                    RemoveHighlight(hoveredObject);
                }

                hoveredObject = hit.collider.gameObject;
                HighlightObject(hoveredObject);
            }
        }
        else
        {
            lineRenderer.SetPosition(1, handTransform.position + handTransform.forward * maxGrabDistance);

            if (hoveredObject != null)
            {
                RemoveHighlight(hoveredObject);
                hoveredObject = null;
            }
        }
    }

    void TryGrabObject()
    {
        if (hoveredObject != null && !isGrabbing)
        {
            grabbedObject = hoveredObject;
            grabbedObject.GetComponent<Rigidbody>().isKinematic = true; // Disable physics while grabbing
            isGrabbing = true;
        }

        if (grabbedObject != null)
        {
            // Move the grabbed object towards the hand smoothly
            grabbedObject.transform.position = Vector3.MoveTowards(grabbedObject.transform.position, handTransform.position, grabSpeed * Time.deltaTime);
        }
    }

    void ReleaseObject()
    {
        if (grabbedObject != null)
        {
            // Re-enable physics and apply a force based on how long the button was held
            Rigidbody rb = grabbedObject.GetComponent<Rigidbody>();
            rb.isKinematic = false;

            Vector3 throwDirection = (handTransform.forward).normalized;
            float throwForce = grabForceTime * forceMultiplier;

            rb.AddForce(throwDirection * throwForce, ForceMode.VelocityChange);

            grabbedObject = null;
        }

        isGrabbing = false;
        grabForceTime = 0f; // Reset force charge time
    }

    void HighlightObject(GameObject obj)
    {
        // Change the object's color or outline to indicate it is being hovered over
        Renderer renderer = obj.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = Color.yellow; // Change color to yellow for highlighting
        }
    }

    void RemoveHighlight(GameObject obj)
    {
        // Reset the object's color or outline when no longer hovered over
        Renderer renderer = obj.GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = Color.white; // Revert color back to white
        }
    }
}
