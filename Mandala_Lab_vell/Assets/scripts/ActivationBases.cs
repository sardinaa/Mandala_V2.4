using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationBases : MonoBehaviour
{
    public GameObject Bases;
    private static AudioSource AudioBase;
    private int count = 0;
    public Material _trailColor;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Spots 1").GetComponent<PatronControllerSpot1>().enabled = false;
        GameObject.Find("Spots 2").GetComponent<PatronControllerSpot2>().enabled = false;
        GameObject.Find("Spots 3").GetComponent<PatronControllerSpot3>().enabled = false;
        GameObject.Find("Spots 4").GetComponent<PatronControllerSpot4>().enabled = false;
        GameObject.Find("Bases").GetComponent<StartBases>().enabled = false;
        GameObject.Find("Thunder11").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder12").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder13").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder21").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder22").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder23").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder31").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder32").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder33").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder41").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder42").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Thunder43").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Ripple_Bases_Spot1").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Ripple_Bases_Spot2").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Ripple_Bases_Spot3").GetComponent<ParticleSystem>().Pause();
        GameObject.Find("Ripple_Bases_Spot4").GetComponent<ParticleSystem>().Pause();

        //GameObject.Find("Ripple_Bases_Spot1").GetComponent<ParticleSystem>().colorOverLifetime.color.gradient.SetKeys(GlobalVariables.gradient_G);

        AudioBase = GameObject.Find("Bases").GetComponent<AudioSource>();
        AudioBase.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (ActivateSpot1._Spot1Activated == true && ActivateSpot2._Spot2Activated == true && ActivateSpot3._Spot3Activated == true && ActivateSpot4._Spot4Activated == true)
        {
            GameObject.Find("Ripple_Spot1").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Ripple_Spot2").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Ripple_Spot3").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Ripple_Spot4").GetComponent<ParticleSystem>().Stop();
            Bases.GetComponent<Animator>().Play("initialitzation");
            GameObject.Find("Ripple_Bases_Spot1").GetComponent<ParticleSystem>().Play();
            GameObject.Find("Ripple_Bases_Spot2").GetComponent<ParticleSystem>().Play();
            GameObject.Find("Ripple_Bases_Spot3").GetComponent<ParticleSystem>().Play();
            GameObject.Find("Ripple_Bases_Spot4").GetComponent<ParticleSystem>().Play();
            GameObject.Find("Bases").GetComponent<StartBases>().enabled = true;
            GetComponent<ActivationBases>().enabled = false;

            Destroy(GetComponentInChildren<ActivateSpot1>());
            Destroy(GetComponentInChildren<ActivateSpot2>());
            Destroy(GetComponentInChildren<ActivateSpot3>());
            Destroy(GetComponentInChildren<ActivateSpot4>());

        }

        if (count == 0)
        {
            GameObject.Find("Sphere11").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere12").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere13").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere21").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere22").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere23").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere31").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere32").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere33").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere41").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere42").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
            GameObject.Find("Sphere43").GetComponent<Renderer>().material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);

            _trailColor.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
            count++;
        }
        


        /***
        if (Bases.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("bash"))
        {
            Debug.Log("not playing");
        }
            
        else
        {
            Debug.Log("playing");
        }***/

    }
}
