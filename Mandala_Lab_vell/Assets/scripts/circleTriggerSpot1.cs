using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleTriggerSpot1 : MonoBehaviour
{
    private PatronControllerSpot1 patronController;
    private string circle;

    // Start is called before the first frame update
    void Start()
    {
        patronController = new PatronControllerSpot1();
    }

    private void OnTriggerStay(Collider other)
    {
        circle = gameObject.tag;
        patronController.CircleActivated(circle);
    }
}
