using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateSpot2 : MonoBehaviour
{
    public static bool _Spot2Activated;
    public AudioSource source;
    public AudioClip clip;
    // Start is called before the first frame update
    void Start()
    {
        _Spot2Activated = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        _Spot2Activated = true;
        GetComponentInChildren<ParticleSystem>().Stop();
        GameObject.Find("Sphere21").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        GameObject.Find("Sphere22").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        GameObject.Find("Sphere23").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        source.PlayOneShot(clip);
    }

    private void OnTriggerExit(Collider other)
    {
        _Spot2Activated = false;
        GetComponentInChildren<ParticleSystem>().Play();
        GameObject.Find("Sphere21").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        GameObject.Find("Sphere22").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        GameObject.Find("Sphere23").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
    }
}
