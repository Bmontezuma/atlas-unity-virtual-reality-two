using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DominoTriggerScript : MonoBehaviour
{
    public GameObject firstDomino; // Assign the first domino here
    public float activationForce = 5f; // Force to apply to the first domino

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // Replace with VR controller input
        {
            TriggerDominoEffect();
        }
    }

    void TriggerDominoEffect()
    {
        Rigidbody rb = firstDomino.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(Vector3.forward * activationForce, ForceMode.Impulse);
        }
    }
}

