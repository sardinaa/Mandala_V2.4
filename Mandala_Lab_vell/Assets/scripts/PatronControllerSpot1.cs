using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PatronControllerSpot1 : MonoBehaviour
{
    static ParticleSystem _thunderRigth;
    static ParticleSystem _thunderCenter;
    static ParticleSystem _thunderLeft;
    private float timeact;
    private float waitact;
    //[SerializeField] private Renderer circleRight;
    [SerializeField] private Renderer circleCenter;
    [SerializeField] private Renderer circleLeft;
    [SerializeField] private Renderer circleRight;


    private TimeFunction timeActive;
    private TimeFunction timeDesActive;
    private static bool activated;
    private static bool desactivated;
    private static int countPatron = 0;
    public static int countTurnOnSpot1 = 0;

    public GameObject mandalaLine;
    public static Component[] llisteta;
    public static bool changeSpot1;
    

    // Start is called before the first frame update
    void Start()
    {
        llisteta = mandalaLine.GetComponentsInChildren(typeof(PhyllotaxisSimple));
        timeact = GlobalVariables.TimeCircleActivatedSpot1;
        waitact = GlobalVariables.TimeCircleWaitingSpot1;

        _thunderRigth = circleRight.GetComponentInChildren<ParticleSystem>();
        _thunderCenter = circleCenter.GetComponentInChildren<ParticleSystem>();
        _thunderLeft = circleLeft.GetComponentInChildren<ParticleSystem>();

        TurnOffCircle();
        
        timeActive = new TimeFunction(TurnOnCircle, timeact);
        timeDesActive = new TimeFunction(TurnOffCircle, waitact);

        desactivated = false;
        changeSpot1 = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (activated == false)
        {
            timeActive.Update();
        }
        else if (desactivated == false)
        {
            timeDesActive.Update();
        }
        
    }


    public void CircleActivated(string circle)
    {
        if (countPatron == 0)
        {
            if (circle == "CircleRight" && activated == true && GlobalVariables.patron2.x == 1)
            {
                _thunderRigth.Play();
                Draw();
            }
            else if (circle == "CircleCenter" && activated == true && GlobalVariables.patron2.x == 2)
            {
                _thunderCenter.Play();
                Draw();
            }

            else if (circle == "CircleLeft" && activated == true && GlobalVariables.patron2.x == 3)
            {
                _thunderLeft.Play();
                Draw();
            }
        }

        else if (countPatron == 1)
        {
            if (circle == "CircleRight" && activated == true && GlobalVariables.patron2.y == 1)
            {
                _thunderRigth.Play();
                Draw();
            }
            else if (circle == "CircleCenter" && activated == true && GlobalVariables.patron2.y == 2)
            {
                _thunderCenter.Play();
                Draw();
            }

            else if (circle == "CircleLeft" && activated == true && GlobalVariables.patron2.y == 3)
            {
                _thunderLeft.Play();
                Draw();
            }
        }

        else if (countPatron == 2)
        {
            if (circle == "CircleRight" && activated == true && GlobalVariables.patron2.z == 1)
            {
                _thunderRigth.Play();
                Draw();
            }
            else if (circle == "CircleCenter" && activated == true && GlobalVariables.patron2.z == 2)
            {
                _thunderCenter.Play();
                Draw();
            }

            else if (circle == "CircleLeft" && activated == true && GlobalVariables.patron2.z == 3)
            {
                _thunderLeft.Play();
                Draw();
            }
        }

        else if (countPatron == 3)
        {
            if (circle == "CircleRight" && activated == true && GlobalVariables.patron2.w == 1)
            {
                _thunderRigth.Play();
                Draw();
            }
            else if (circle == "CircleCenter" && activated == true && GlobalVariables.patron2.w == 2)
            {
                _thunderCenter.Play();
                Draw();
            }

            else if (circle == "CircleLeft" && activated == true && GlobalVariables.patron2.w == 3)
            {
                _thunderLeft.Play();
                Draw();
            }
        }

    }

    void Draw()
    {
        foreach (PhyllotaxisSimple phyllo_script in llisteta)
        {
            phyllo_script.activate = true;

        }
    }

    void TurnOnCircleRight()
    {
        circleRight.material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        activated = true;
        desactivated = false;
    }

    void TurnOnCircleCenter()
    {
        circleCenter.material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        activated = true;
        desactivated = false;
    }

    void TurnOnCircleLeft()
    {
        circleLeft.material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        activated = true;
        desactivated = false;
    }

    public void TurnOnCircle()
    {
        countTurnOnSpot1++;
        if (countPatron == 0)
        {
            if (GlobalVariables.patron2.x == 1)
            {
                TurnOnCircleRight();
            }
            else if (GlobalVariables.patron2.x == 2)
            {
                TurnOnCircleCenter();
            }
            else if (GlobalVariables.patron2.x == 3)
            {
                TurnOnCircleLeft();
            }
        }

        

        else if (countPatron == 1)
        {
            if (GlobalVariables.patron2.y == 1)
            {
                TurnOnCircleRight();
            }
            else if (GlobalVariables.patron2.y == 2)
            {
                TurnOnCircleCenter();
            }
            else if (GlobalVariables.patron2.y == 3)
            {
                TurnOnCircleLeft();
            }
        }

        else if (countPatron == 2)
        {
            if (GlobalVariables.patron2.z == 1)
            {
                TurnOnCircleRight();
            }
            else if (GlobalVariables.patron2.z == 2)
            {
                TurnOnCircleCenter();
            }
            else if (GlobalVariables.patron2.z == 3)
            {
                TurnOnCircleLeft();
            }
        }

        else if (countPatron == 3)
        {
            if (GlobalVariables.patron2.w == 1)
            {
                TurnOnCircleRight();
            }
            else if (GlobalVariables.patron2.w == 2)
            {
                TurnOnCircleCenter();
            }
            else if (GlobalVariables.patron2.w == 3)
            {
                TurnOnCircleLeft();
            }
        }   
    }

    void TurnOffCircle()
    {
        circleRight.material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        circleCenter.material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        circleLeft.material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._minIntensity);
        _thunderRigth.Stop();
        _thunderCenter.Stop();
        _thunderLeft.Stop();
        desactivated = true;
        activated = false;
        countPatron++;

        foreach (PhyllotaxisSimple phyllo_script in llisteta)
        {
            phyllo_script.activate = false;

        }

        Debug.Log(countPatron);
        if (countPatron == 3)
        {
            countPatron = 0;
        }

        if (countTurnOnSpot1 == GlobalVariables.npampallugues)
        {

            changeSpot1 = true;
            circleRight.material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
            circleCenter.material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
            circleLeft.material.SetColor("_EmissionColor", GlobalVariables.colcir * GlobalVariables._maxIntensity);
        }
    }
}
