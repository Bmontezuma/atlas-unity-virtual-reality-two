using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GazeReticle : MonoBehaviour
{
    public Transform reticleTransform;
    public float maxDistance = 10.0f;

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance))
        {
            reticleTransform.position = hit.point;
        }
        else
        {
            reticleTransform.position = transform.position + transform.forward * maxDistance;
        }
    }
}
