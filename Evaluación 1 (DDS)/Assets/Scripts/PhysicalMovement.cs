using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    private Vector3 velocity;
    [SerializeField] private float gravityScale;
    private bool cJump;
    private bool dJump = true;
    [SerializeField] private float jumpForce;
    [SerializeField] private float disableGroundDetectionTime = 0.2f;
    private float incialGravity;



    private void Start()
    {
       incialGravity = gravityScale;
    }


    public void Move(Vector3 velocity)
    {
        this.velocity.x = velocity.x;
        this.velocity.z = velocity.z;
    }

    public void Jump()
    {
        if (cJump)
        {
            velocity.y = jumpForce;
            cJump = false;
            disableGroundDetectionTime = 0.2f;
           
        }
        else if (dJump)
        {
            velocity.y = jumpForce;
            dJump = false;
            gravityScale = gravityScale * 2;
        }
    }

    void Update()
    {
        if (controller.isGrounded && disableGroundDetectionTime <= 0)
        {
            velocity.y = 0;
            cJump = true;
            dJump = true;
            gravityScale = incialGravity;
        }
        else
        {
            velocity.y += Physics.gravity.y * gravityScale * Time.deltaTime;
            disableGroundDetectionTime -= Time.deltaTime;
            disableGroundDetectionTime = Mathf.Max(0, disableGroundDetectionTime);
        }

        controller.Move(velocity * Time.deltaTime);
    }
}
