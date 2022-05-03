using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
    public static GameObject DrawFill(int sides, float radius, Vector3 center)
    {
        GameObject filledDrawing = new GameObject();
        filledDrawing.AddComponent<MeshRenderer>();
        filledDrawing.AddComponent<MeshFilter>();
        return filledDrawing;
    }
}
