using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabSystem : MonoBehaviour
{
    public Transform grabPointHilt;
    public Transform grabPointPommel;
    public Transform grabPointBlade;
    
    private Rigidbody swordRigidbody;
    private Rigidbody firstHandRigidbody;
    private Rigidbody secondHandRigidbody;
    
    void Start() {
        swordRigidbody = GetComponent<Rigidbody>();
    }

    public void GrabWithOneHand(Rigidbody handRigidbody) {
        AttachHandToGrabPoint(handRigidbody, grabPointHilt);
    }

    public void GrabWithTwoHands(Rigidbody hand1Rigidbody, Rigidbody hand2Rigidbody) {
        firstHandRigidbody = hand1Rigidbody;
        secondHandRigidbody = hand2Rigidbody;
        AttachHandToGrabPoint(firstHandRigidbody, grabPointPommel);
        AttachHandToGrabPoint(secondHandRigidbody, grabPointBlade);
    }

    void AttachHandToGrabPoint(Rigidbody handRigidbody, Transform grabPoint) {
        FixedJoint joint = handRigidbody.gameObject.AddComponent<FixedJoint>();
        joint.connectedBody = swordRigidbody;
        joint.breakForce = Mathf.Infinity;  // Set appropriate values
        joint.breakTorque = Mathf.Infinity;
    }

    void Update() {
        // Handle transition between one-handed and two-handed grab here
    }
}
