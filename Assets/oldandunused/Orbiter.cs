using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbiter : MonoBehaviour
{
    // public Rigidbody2D _rb;
    // static GameObject clone = null;

    // static Rigidbody2D planetRB;
    // public static List<Orbiter> orbiters = new List<Orbiter>();
    // Vector3 throwForce;
    // Vector3 velocity;
    // public static bool isBeingAimed;
    // void Awake()
    // {
    //     _rb = this.GetComponent<Rigidbody2D>();
    //     orbiters.Add(this);
    // }
    // // void Start()
    // // {

    // // }
    // // void OnEnable()
    // // {
    // //     orbiters.Add(this);
    // // }
    // // void OnDisable()
    // // {
    // //     orbiters.Remove(this);
    // // }
    // void Update()
    // {
    //     velocity = _rb.velocity;
    //     if(Input.GetMouseButtonDown(0))
    //     {
    //         Debug.Log("But down" + this.gameObject);
    //         StartVisualizingPath();
    //         isBeingAimed = true;
    //     }
    //     else if(Input.GetMouseButton(0))
    //     {
    //         Debug.Log("But press" + this.gameObject);
    //         Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //         Vector2 distance = mousePos - this.transform.position;
    //         throwForce = -distance.normalized;    
    //         VisualizePath(throwForce);
    //     }
    //     else if(Input.GetMouseButtonUp(0))
    //     {
    //         Debug.Log("But released" + this.gameObject);
    //         // _rb.velocity = Vector3.zero;
    //         _rb.AddForce(throwForce);
    //         if(!orbiters.Contains(this))
    //         orbiters.Add(this);
    //         StopVisualizingPath();
    //         isBeingAimed = false;
    //     }
    // }
    // public void VisualizeOrbit()
    // {
    //     StartVisualizingPath();
    //     VisualizePath(Vector3.zero);
    //     StopVisualizingPath();
    // }
    // void StartVisualizingPath()
    // {
    //     GameObject throwable = this.gameObject;

    //     throwable.GetComponent<Rigidbody2D>().simulated = false;

    //     clone = Instantiate(throwable,throwable.transform.position,Quaternion.identity);
    //     clone.GetComponent<SpriteRenderer>().enabled = false;
    //     Physics2D.simulationMode = SimulationMode2D.Script;
        
    // }
    // void VisualizePath(Vector3 force)
    // {  
    //     // Physics2D.Simulate(Time.fixedDeltaTime);
    //     clone.transform.position = this.transform.position;
    //     Rigidbody2D cloneRigidBody = clone.GetComponent<Rigidbody2D>();

    //     Orbiter cloneOrbiter = clone.GetComponent<Orbiter>();
    //     cloneOrbiter.enabled = false;
    //     cloneRigidBody.velocity = _rb.velocity;
    //     cloneRigidBody.AddForce(force);////////////
    //     clone.GetComponent<Rigidbody2D>().simulated = true;
        
    //     // clone.transform.GetComponentInChildren<LineRenderer>().enabled = false;
    //     List<Vector3> pathPoints = new List<Vector3>();
    //     int simulationSteps = 500;
    //     List<Graviton> gravitons = Graviton.gravitons;
    //     for(int i = 1; i<simulationSteps; i++)
    //     {
    //         foreach(Graviton graviton in gravitons)
    //         {
    //             graviton.Attract(cloneOrbiter);
    //         }
    //         Physics2D.Simulate(Time.fixedDeltaTime);
    //         pathPoints.Add(cloneRigidBody.transform.position);
    //         // cloneOrbiter.velocity = cloneRigidBody.velocity;
    //     }
    //     //set stored positions from simulation as linerenderer positions
    //     LineRenderer linePath = GetComponentInChildren<LineRenderer>();
    //     linePath.enabled = true;
    //     linePath.positionCount = pathPoints.Count;
    //     linePath.SetPositions(pathPoints.ToArray());
    // }
    // void StopVisualizingPath()
    // {   
    //     this.GetComponent<Rigidbody2D>().simulated = true;
    //     Physics2D.simulationMode = SimulationMode2D.FixedUpdate;
    //     Destroy(clone);
    // }

}
