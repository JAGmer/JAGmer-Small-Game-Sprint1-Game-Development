using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallController : MonoBehaviour
{
    public float ballSpeed;
    private Rigidbody rb;
    private float xInput, zInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ballSpeed = 5.0f;
        rb = GetComponent<Rigidbody>();
        xInput = 0.0f;
        zInput = 0.0f;
    }

    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        xInput = movementVector.x;
        zInput = movementVector.y;
    }

    void Update()
    {
        Vector3 movement = new Vector3(xInput, 0f, zInput).normalized;
        Vector3 horizontalVelocity = new Vector3(rb.linearVelocity.x, 0f, rb.linearVelocity.z);

        if (Vector3.Dot(movement, horizontalVelocity.normalized) < 0)
        {
            rb.AddForce(movement * ballSpeed * 3.2f, ForceMode.Acceleration);
        }
        else
        {
            rb.AddForce(movement * ballSpeed, ForceMode.Acceleration);
        }

        
    }
}