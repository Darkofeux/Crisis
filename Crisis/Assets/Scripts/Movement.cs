using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
   
    [SerializeField] private float moveSpeed = 5; // Vitesse de deplacement du joueur
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float jumpForce = 250; // Puissance de saut su joueur
    public bool isGrounded;
    public int jumpsCount = 2; // Nombre de saut max 
    public int jumpsRemaining = 0; // Nombre de saut restant 
    
    void Update()
    {
        var vel = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed; // Deplacements du joueur
        vel.y = rb.velocity.y;
        rb.velocity = vel;

        if ((Input.GetKeyDown(KeyCode.Space)) && (jumpsRemaining > 0)) // Si le touche Espace est utilisé et que le nombre de saut restant est superieur a 0
        {
            rb.AddForce(Vector3.up * jumpForce); // Fait sauter le joueur 
            jumpsRemaining -= 1; // Lui retire un saut 
        }
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor") // Si le joueur est en contact avec le tag Floor
        {
            isGrounded = true; // Est en contact avec le sol
            jumpsRemaining = jumpsCount; // Reinitialise le nombre de saut restant 
        }
    }
    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor") // Si le joueur n'est pas en contact avec le tag Floor
        {
            isGrounded = false; // N'est pas en contact avec le sol
        }
    }
}
