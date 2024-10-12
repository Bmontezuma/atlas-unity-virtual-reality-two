using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandGrabInteractable : XRGrabInteractable
{
    // A list to track all interactors that are grabbing the object
    private List<XRBaseInteractor> interactors = new List<XRBaseInteractor>();

    // The minimum number of interactors required to pick up the object
    [SerializeField]
    private int requiredInteractors = 2;

    // Store the original position and rotation to avoid snapping issues
    private Vector3 originalPositionOffset;
    private Quaternion originalRotationOffset;

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        // Add the interactor to the list when a new interactor grabs the object
        if (!interactors.Contains(args.interactorObject))
        {
            interactors.Add(args.interactorObject);
        }

        // Only allow pickup when both hands are grabbing
        if (interactors.Count == requiredInteractors)
        {
            base.OnSelectEntered(args); // This allows picking up the object
        }
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        // Remove the interactor when it releases the object
        if (interactors.Contains(args.interactorObject))
        {
            interactors.Remove(args.interactorObject);
        }

        // When both hands release the object, it will be dropped
        if (interactors.Count < requiredInteractors)
        {
            base.OnSelectExited(args);
        }
    }

    protected override void OnActivate(ActivateEventArgs args)
    {
        // Optional: Implement behavior when the object is activated with both hands
        base.OnActivate(args);
    }

    protected override void OnDeactivate(DeactivateEventArgs args)
    {
        // Optional: Implement behavior when the object is deactivated
        base.OnDeactivate(args);
    }
}

