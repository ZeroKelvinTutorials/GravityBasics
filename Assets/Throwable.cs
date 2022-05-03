using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(LineRenderer))]
public class Throwable : MonoBehaviour
{
    Vector3 throwVector;
    Rigidbody2D _rb;
    [SerializeField] Vector3 throwVelocity;
    public Vector3 velocity;
    void Update()
    {
        velocity = _rb.velocity;
    }
    void Awake()
    {
        _rb = this.GetComponent<Rigidbody2D>();
    }
    //onmouse events possible thanks to monobehaviour + collider2d
    void OnMouseDown()
    {
        CalculateThrowVector();
        // Path.StartVisualizingPath(this.gameObject);
        PathHandler.StartVisualizingPath(this.gameObject);
    }
    void OnMouseDrag()
    {
        CalculateThrowVector(); 
        //Call after CalculateThrowVector() to work with updated throwVector value
        PathHandler.VisualizePath(this.gameObject,throwVector);
    }
    void CalculateThrowVector()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //doing vector2 math to ignore the z values in our distance.
        Vector2 distance = mousePos - this.transform.position;

        throwVector = -distance;    
        
        throwVelocity = throwVector;
    }
    void OnMouseUp()
    {
        //Has to be called before Throw() since simulation settings are reset in there
        PathHandler.StopVisualizingPath(this.gameObject);
        Throw();
    }
    public void Throw()
    {
        Debug.Log(_rb.velocity);
        _rb.AddForce(throwVector,ForceMode2D.Impulse);
        Debug.Log(_rb.velocity);
        this.GetComponent<Graviton>().IsAttractee = true;
    }
}
