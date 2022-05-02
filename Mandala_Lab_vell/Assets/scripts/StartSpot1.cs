using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartSpot1 : MonoBehaviour
{
    public static bool _Spot1Started;
    // Start is called before the first frame update
    void Start()
    {
        _Spot1Started = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _Spot1Started = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _Spot1Started = false;
    }
}
