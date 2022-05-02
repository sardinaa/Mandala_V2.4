using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpot3 : MonoBehaviour
{
    public static bool _Spot3Activated;
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        _Spot3Activated = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _Spot3Activated = true;
        GetComponentInChildren<ParticleSystem>().Stop();
        GameObject.Find("Sphere31").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        GameObject.Find("Sphere32").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        GameObject.Find("Sphere33").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        source.PlayOneShot(clip);
    }

    private void OnTriggerExit(Collider other)
    {
        _Spot3Activated = false;
        GetComponentInChildren<ParticleSystem>().Play();
        GameObject.Find("Sphere31").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        GameObject.Find("Sphere32").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        GameObject.Find("Sphere33").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
    }
}
