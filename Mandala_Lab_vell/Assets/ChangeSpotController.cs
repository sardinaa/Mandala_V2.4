using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpotController : MonoBehaviour
{
    private Animator sinusoide;
    private bool animactiv;

    public GameObject ObjectSpot1;
    public GameObject ObjectSpot2;
    public GameObject ObjectSpot3;
    public GameObject ObjectSpot4;

    PatronControllerSpot1 scrriptSpot1;
    PatronControllerSpot2 scrriptSpot2;
    PatronControllerSpot3 scrriptSpot3;
    PatronControllerSpot4 scrriptSpot4;
    // Start is called before the first frame update
    void Start()
    {
        sinusoide = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PatronControllerSpot1.changeSpot1 == true && PatronControllerSpot2.changeSpot2 == true && PatronControllerSpot3.changeSpot3 == true && PatronControllerSpot4.changeSpot4 == true)
        {
            sinusoide.Play("sinus", -1, 0f);
            sinusoide.Update(0f);

            (ObjectSpot1.GetComponent("PatronControllerSpot1") as MonoBehaviour).enabled = false;
            (ObjectSpot2.GetComponent("PatronControllerSpot2") as MonoBehaviour).enabled = false;
            (ObjectSpot3.GetComponent("PatronControllerSpot3") as MonoBehaviour).enabled = false;
            (ObjectSpot4.GetComponent("PatronControllerSpot4") as MonoBehaviour).enabled = false;

            Debug.Log("Cagundeu");

            GameObject.Find("Sphere11").GetComponent<circleTriggerSpot1>().enabled = false;
            GameObject.Find("Sphere12").GetComponent<circleTriggerSpot1>().enabled = false;
            GameObject.Find("Sphere13").GetComponent<circleTriggerSpot1>().enabled = false;
            GameObject.Find("Sphere21").GetComponent<circleTriggerSpot2>().enabled = false;
            GameObject.Find("Sphere22").GetComponent<circleTriggerSpot2>().enabled = false;
            GameObject.Find("Sphere23").GetComponent<circleTriggerSpot2>().enabled = false;
            GameObject.Find("Sphere31").GetComponent<circleTriggerSpot3>().enabled = false;
            GameObject.Find("Sphere32").GetComponent<circleTriggerSpot3>().enabled = false;
            GameObject.Find("Sphere33").GetComponent<circleTriggerSpot3>().enabled = false;
            GameObject.Find("Sphere41").GetComponent<circleTriggerSpot4>().enabled = false;
            GameObject.Find("Sphere42").GetComponent<circleTriggerSpot4>().enabled = false;
            GameObject.Find("Sphere43").GetComponent<circleTriggerSpot4>().enabled = false;

            PatronControllerSpot1.changeSpot1 = false;
            PatronControllerSpot2.changeSpot2 = false;
            PatronControllerSpot3.changeSpot3 = false;
            PatronControllerSpot4.changeSpot4 = false;

            animactiv = true;
            Debug.Log(sinusoide.GetCurrentAnimatorStateInfo(0).normalizedTime);
        }


        if (sinusoide.GetCurrentAnimatorStateInfo(0).IsName("sinus") &&
        sinusoide.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f && animactiv == true)
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

            (ObjectSpot1.GetComponent("PatronControllerSpot1") as MonoBehaviour).enabled = true;
            (ObjectSpot2.GetComponent("PatronControllerSpot2") as MonoBehaviour).enabled = true;
            (ObjectSpot3.GetComponent("PatronControllerSpot3") as MonoBehaviour).enabled = true;
            (ObjectSpot4.GetComponent("PatronControllerSpot4") as MonoBehaviour).enabled = true;

            GameObject.Find("Sphere11").GetComponent<circleTriggerSpot1>().enabled = true;
            GameObject.Find("Sphere12").GetComponent<circleTriggerSpot1>().enabled = true;
            GameObject.Find("Sphere13").GetComponent<circleTriggerSpot1>().enabled = true;
            GameObject.Find("Sphere21").GetComponent<circleTriggerSpot2>().enabled = true;
            GameObject.Find("Sphere22").GetComponent<circleTriggerSpot2>().enabled = true;
            GameObject.Find("Sphere23").GetComponent<circleTriggerSpot2>().enabled = true;
            GameObject.Find("Sphere31").GetComponent<circleTriggerSpot3>().enabled = true;
            GameObject.Find("Sphere32").GetComponent<circleTriggerSpot3>().enabled = true;
            GameObject.Find("Sphere33").GetComponent<circleTriggerSpot3>().enabled = true;
            GameObject.Find("Sphere41").GetComponent<circleTriggerSpot4>().enabled = true;
            GameObject.Find("Sphere42").GetComponent<circleTriggerSpot4>().enabled = true;
            GameObject.Find("Sphere43").GetComponent<circleTriggerSpot4>().enabled = true;

            GameObject.Find("Thunder11").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder12").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder13").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder21").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder22").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder23").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder31").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder32").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder33").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder41").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder42").GetComponent<ParticleSystem>().Stop();
            GameObject.Find("Thunder43").GetComponent<ParticleSystem>().Stop();

            
            PatronControllerSpot1.countTurnOnSpot1 = 0;
            PatronControllerSpot2.countTurnOnSpot2 = 0;
            PatronControllerSpot3.countTurnOnSpot3 = 0;
            PatronControllerSpot4.countTurnOnSpot4 = 0;

            animactiv = false;
        }

    }
}
