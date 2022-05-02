using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpot4 : MonoBehaviour
{
    public static bool _Spot4Started;
    // Start is called before the first frame update
    void Start()
    {
        _Spot4Started = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _Spot4Started = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _Spot4Started = false;
    }
}
