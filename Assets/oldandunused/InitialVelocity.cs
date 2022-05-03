using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitialVelocity : MonoBehaviour
{
    public Vector2 force;
    public bool reset;
    Vector3 startingPosition;
    Rigidbody2D rb;
    void Awake()
    {
        startingPosition = transform.position;
        rb = this.GetComponent<Rigidbody2D>();
        // rb.AddForce(force);
    }
    void Update()
    {
        if(reset)
        {
            rb.velocity = Vector3.zero;
            this.transform.position = startingPosition;
            rb.AddForce(force,ForceMode2D.Impulse);
            reset = false;
            // Debug.Log(rb.velocity);
        }
        // Debug.Log(rb.velocity);
        
    }
}
