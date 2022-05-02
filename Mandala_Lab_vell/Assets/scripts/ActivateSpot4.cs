using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpot4 : MonoBehaviour
{
    public static bool _Spot4Activated;
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        _Spot4Activated = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _Spot4Activated = true;
        GetComponentInChildren<ParticleSystem>().Stop();
        GameObject.Find("Sphere41").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        GameObject.Find("Sphere42").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        GameObject.Find("Sphere43").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        source.PlayOneShot(clip);
    }

    private void OnTriggerExit(Collider other)
    {
        _Spot4Activated = false;
        GetComponentInChildren<ParticleSystem>().Play();
        GameObject.Find("Sphere41").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        GameObject.Find("Sphere42").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        GameObject.Find("Sphere43").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
    }
}
