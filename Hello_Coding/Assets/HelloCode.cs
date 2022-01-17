using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    public float distance;
    void Start()
    {
        distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2,2)에서 (5,6)까지의 거리:" + distance);
    }
    public float GetDistance(float x1, float y1, float x2, float y2)
    {
        float width = x2 - x1;
        float height = y2 - y1;

        distance = width * width + height * height;
        distance = Mathf.Sqrt(distance);
        return distance;
    }
    

}
