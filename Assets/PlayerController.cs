using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 7f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Movement
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontalInput * moveSpeed, rb.linearVelocity.y);
        rb.linearVelocity = movement;

        // Jump
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
        // ... (Movement and Jump code) ...

        // Attack Inputs
        if (Input.GetKeyDown(KeyCode.P))
        {
            PerformNormalAttack();
        }
        if (!Input.GetKeyDown(KeyCode.O))
        {
            return;
        }
        PerformSpecialAttack();

    }
    void PerformNormalAttack() => Debug.Log("Normal Attack!");// Add animation and attack logic here

    void PerformSpecialAttack() => Debug.Log("Special Attack!");// Add animation and attack logic here


    bool IsGrounded()
    {
        // Simple grounding check (you can improve this)
        return Physics2D.Raycast(transform.position, Vector2.down, 1.1f);
    }
}