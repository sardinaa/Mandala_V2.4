using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpot2 : MonoBehaviour
{
    public static bool _Spot2Started;
    // Start is called before the first frame update
    void Start()
    {
        _Spot2Started = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _Spot2Started = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _Spot2Started = false;
    }
}
