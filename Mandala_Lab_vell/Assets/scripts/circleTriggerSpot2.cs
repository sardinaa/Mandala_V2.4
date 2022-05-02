using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleTriggerSpot2 : MonoBehaviour
{
    private PatronControllerSpot2 patronController;
    private string circle;

    // Start is called before the first frame update
    void Start()
    {
        patronController = new PatronControllerSpot2();
    }

    private void OnTriggerStay(Collider other)
    {
        circle = gameObject.tag;
        patronController.CircleActivated(circle);

    }
}
