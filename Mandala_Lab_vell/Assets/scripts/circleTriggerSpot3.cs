using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleTriggerSpot3 : MonoBehaviour
{
    private PatronControllerSpot3 patronController;
    private string circle;

    // Start is called before the first frame update
    void Start()
    {
        patronController = new PatronControllerSpot3();
    }

    private void OnTriggerStay(Collider other)
    {
        circle = gameObject.tag;
        patronController.CircleActivated(circle);

    }
    
}
