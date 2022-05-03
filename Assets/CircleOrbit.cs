using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using System;
public class CircleOrbit : MonoBehaviour
{
    public float radius;
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
            // if(!Orbiter.orbiters.Contains(this.GetComponent<Orbiter>()))
            // Orbiter.orbiters.Add(this.GetComponent<Orbiter>());
            if(!GravityHandler.attractees.Contains(this.GetComponent<Rigidbody2D>()))
            {
                GravityHandler.attractees.Add(this.GetComponent<Rigidbody2D>());
            }
            rb.velocity = Vector3.zero;
            this.transform.position = SetPosition(radius);
            // Time.timeScale = radius;
            // Time.fixedDeltaTime = Time.fixedDeltaTime*Time.timeScale;
            rb.AddForce(CalculateForce(radius),ForceMode2D.Impulse);
            reset = false;
            // Debug.Log(rb.velocity);
        }
        // Debug.Log(rb.velocity);
    }
    Vector3 SetPosition(float num)
    {
        return new Vector3(0,-num,0);
    }
    Vector3 CalculateForce(float num)
    {
        // float v1 = ((float)Math.Sqrt((double)1/num));
        float v2 = (Mathf.Sqrt((float)1/num));
        // return new Vector3(v1,0,0);
        return new Vector3(v2,0,0);
    }
}
