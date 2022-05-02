using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpot1 : MonoBehaviour
{
    public static bool _Spot1Activated;
    public AudioSource source;
    public AudioClip clip;
    
    // Start is called before the first frame update
    void Start()
    {
        _Spot1Activated = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _Spot1Activated = true;
        GetComponentInChildren<ParticleSystem>().Stop();
        GameObject.Find("Sphere11").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        GameObject.Find("Sphere12").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        GameObject.Find("Sphere13").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        source.PlayOneShot(clip);
    }

    private void OnTriggerExit(Collider other)
    {
        _Spot1Activated = false;
        GetComponentInChildren<ParticleSystem>().Play();
        GameObject.Find("Sphere11").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        GameObject.Find("Sphere12").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        GameObject.Find("Sphere13").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
    }
}
