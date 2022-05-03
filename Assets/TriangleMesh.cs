using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class TriangleMesh : MonoBehaviour
{
    public List<Transform> bodys;
    [SerializeField] Vector3[] points;
    [SerializeField] int[] triangleIndexes;
    Mesh mesh;
    void Awake()
    {
        //initialize points and triangles
        points = new Vector3[bodys.Count];
        triangleIndexes = new int[bodys.Count];
        for(int i = 0; i<bodys.Count; i++)
        {
            points[i] = bodys[i].position;
            triangleIndexes[i] = i;
        }
        mesh = new Mesh();
        this.GetComponent<MeshFilter>().mesh = mesh;
    }
    void Update()
    {
        for(int i = 0; i<bodys.Count; i++)
        {
            points[i] = bodys[i].position;
            triangleIndexes[i] = i;
        }
        mesh.Clear();
        //still not used to calling points vertices and triangles triangles
        //vertices too similar to vector to avoid confusion
        //triangles is really a list of index points not triangles
        mesh.vertices = points;
        mesh.triangles = triangleIndexes;
    }
}
