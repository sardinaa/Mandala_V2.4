using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpot3 : MonoBehaviour
{
    public static bool _Spot31Started;
    // Start is called before the first frame update
    void Start()
    {
        _Spot31Started = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _Spot31Started = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _Spot31Started = false;
    }
}
