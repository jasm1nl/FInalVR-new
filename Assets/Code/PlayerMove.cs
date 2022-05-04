using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class PlayerMove : MonoBehaviour
{
    int speed = 5;
    public XRNode handRole = XRNode.RightHand;
    Rigidbody _rigidbody;
    Transform camTrans;
    public int jumpForce = 100;

    // public bool grounded;
    // public LayerMask groundLayer;
    // public Transform feetPos;


    void Start()
    {
        camTrans = Camera.main.transform;
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        InputDevices.GetDeviceAtXRNode(handRole).TryGetFeatureValue(CommonUsages.gripButton, out bool grip);
        if (grip)
        {
            _rigidbody.AddForce(new Vector3(0,jumpForce,0));
            _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0);
        }
    }

    void FixedUpdate()
    {
        //Check grounded
        // grounded = Physics2D.OverlapCircle(feetPos.position, .1f, groundLayer);
        
        //Enable moving
        InputDevices.GetDeviceAtXRNode(handRole).TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 direction);
        Vector3 moveDir = camTrans.forward * direction.y + camTrans.right * direction.x;
        moveDir = moveDir.normalized * speed;
        moveDir.y = _rigidbody.velocity.y;
        _rigidbody.velocity = moveDir;
    }
}
