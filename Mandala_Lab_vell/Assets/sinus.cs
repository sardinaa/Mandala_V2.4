using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinus : MonoBehaviour
{
    float amplitudeX = 68.68f- 16.7f;
    float amplitudeY = 4.0f;
    float omegaX = 0.4f;
    float omegaY = 3.0f;
    float index;

    public void Update()
    {
        index += Time.deltaTime;
        float x = amplitudeX * Mathf.Cos(omegaX * index);
        float z = amplitudeY * Mathf.Sin(omegaY * index);
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, z+10);

    }
}
