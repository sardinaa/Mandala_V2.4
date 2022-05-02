using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Blue Player")
        {
            Debug.Log("Jugador Blau");
            //Logger.CircleActivated(gameObject.transform.parent.parent.name, gameObject.transform.parent.name, collision.gameObject.name);
        }
        else if (collision.gameObject.name == "Red Player")
        {
            Debug.Log("Jugador Vermell");
           // Logger.CircleActivated(gameObject.transform.parent.parent.name, gameObject.transform.parent.name, collision.gameObject.name);
        }
        else if (collision.gameObject.name == "Green Player")
        {
            Debug.Log("Jugador Verd");
            //Logger.CircleActivated(gameObject.transform.parent.parent.name, gameObject.transform.parent.name, collision.gameObject.name);
        }
        else if (collision.gameObject.name == "Purple Player")
        {
            Debug.Log("Jugador Rosa");
            //Logger.CircleActivated(gameObject.transform.parent.parent.name, gameObject.transform.parent.name, collision.gameObject.name);
        }
    }
}
