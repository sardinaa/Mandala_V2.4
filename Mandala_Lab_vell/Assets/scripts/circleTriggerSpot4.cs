using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleTriggerSpot4 : MonoBehaviour
{
    private PatronControllerSpot4 patronController;
    private string circle;

    // Start is called before the first frame update
    void Start()
    {
        patronController = new PatronControllerSpot4();
    }

    private void OnTriggerStay(Collider other)
    {
        circle = gameObject.tag;
        patronController.CircleActivated(circle);

    }
}
