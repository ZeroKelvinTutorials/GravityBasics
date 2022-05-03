using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CreateGrid : MonoBehaviour
{
    [SerializeField] Transform xPrefab;
    [SerializeField] Transform yPrefab;
    [SerializeField] Transform xTransform;
    [SerializeField] Transform yTransform;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 1; i<7;i++)
        {
            Transform newTransform = Instantiate(xPrefab,new Vector3(-i,0,0), Quaternion.identity, xTransform);
            newTransform.GetComponentInChildren<TextMeshPro>().text = (-i).ToString();
            newTransform.gameObject.name = (-i).ToString();
            newTransform = Instantiate(xPrefab,new Vector3(i,0,0), Quaternion.identity, xTransform);
            newTransform.GetComponentInChildren<TextMeshPro>().text = (i).ToString();
            newTransform.gameObject.name = (i).ToString();
            newTransform = Instantiate(yPrefab,new Vector3(0,-i,0), Quaternion.identity, yTransform);
            newTransform.GetComponentInChildren<TextMeshPro>().text = (-i).ToString();
            newTransform.gameObject.name = (-i).ToString();
            newTransform = Instantiate(yPrefab,new Vector3(0,i,0), Quaternion.identity, yTransform);
            newTransform.GetComponentInChildren<TextMeshPro>().text = (i).ToString();
            newTransform.gameObject.name = (i).ToString();
        }
    }
}
