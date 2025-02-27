using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestDummyController : MonoBehaviour
{
    public float moveSpeed = 3f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Apply a random initial force
        rb.AddForce(new Vector2(Random.Range(-1f, 1f), 0f) * moveSpeed, ForceMode2D.Impulse);
    }

    void FixedUpdate()
    {
        // Keep the dummy moving
        if (rb.linearVelocity.magnitude < 1f)
        {
            rb.AddForce(new Vector2(Random.Range(-1f, 1f), 0f) * moveSpeed, ForceMode2D.Impulse);
        }
    }
}