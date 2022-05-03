using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{
    [SerializeField] Vector3 desiredPosition;
    [SerializeField] bool move;

    [SerializeField] Rigidbody2D attractor;
    [SerializeField] Rigidbody2D target;
    void Start()
    {
        GravityHandler.AddGravityForce(attractor,target);
        Debug.Log(target.velocity.magnitude);
        Vector3 test = new Vector3(-5,-3,0);
        Debug.Log(test.normalized);
    }
    void Update()
    {
        if(move)
        {
            StartCoroutine(MoveTransformTo(desiredPosition,3));
            move=false;
        }
    }
    IEnumerator MoveTransformTo(Vector3 targetPosition, float time)
    {
        float timer = 0;
        Vector3 startingPosition = transform.position;
        while(timer<time)
        {
            timer+=Time.deltaTime;
            Debug.Log(timer);
            float progress = timer/time;
            progress = SineProgress(progress);
            transform.position = Vector3.Lerp(startingPosition,targetPosition,progress);
            yield return null;
        }
        transform.position = targetPosition;
        yield return null;
    }

    float SineProgress(float progress)
    {
        float valueToSine = Mathf.Lerp(1.5f,2.5f,progress)*Mathf.PI;
        float sineValue = Mathf.Sin(valueToSine);
        float scaledSineValue = (sineValue/2f)+.5f;
        return scaledSineValue;
    }
}
