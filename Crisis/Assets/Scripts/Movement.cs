using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    [SerializeField] private float moveSpeed = 5;
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce = 250;
    public bool isGrounded;
    public int jumpsCount = 2;
    public int jumpsRemaining = 0;
    
    void Update()
    {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed;
        vel.y = rb.velocity.y;
        rb.velocity = vel;

        if ((Input.GetKeyDown(KeyCode.Space)) && (jumpsRemaining > 0))
        {
            rb.AddForce(Vector3.up * jumpForce);
            jumpsRemaining -= 1;
        }
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = true;
            jumpsRemaining = jumpsCount;
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isGrounded = false;
        }
    }
}
