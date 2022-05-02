using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public AudioClip yourMusic;
    public static AudioClip music;
    [Range(1, 3)]
    public int _X, _Y, _Z, _W;
    public static Vector4 patron2;
    [Range(0.1f, 20.0f)]
    public float TimeCircleActivated;
    public static float TimeCircleActivatedSpot1;
    public static float TimeCircleActivatedSpot2;
    public static float TimeCircleActivatedSpot3;
    public static float TimeCircleActivatedSpot4;
    [Range(0.1f, 20.0f)]
    public float TimeCircleWaiting;
    public static float TimeCircleWaitingSpot1;
    public static float TimeCircleWaitingSpot2;
    public static float TimeCircleWaitingSpot3;
    public static float TimeCircleWaitingSpot4;
    public Color CirclesColor;
    public static Color colcir;
    [Range(0.1f, 4.0f)]
    public float _minIntensityCircle, _maxIntensityCircle;
    public static float _minIntensity, _maxIntensity;
    [Range(3, 20)]
    public int pampallugues;
    public static int npampallugues;

    public Gradient gradient;
    public static Gradient gradient_G;


    void Start()
    {
        
        music = yourMusic;
        patron2.Set(_X, _Y, _Z, _W);
        TimeCircleActivatedSpot1 = TimeCircleActivated;
        TimeCircleActivatedSpot2 = TimeCircleActivated;
        TimeCircleActivatedSpot3 = TimeCircleActivated;
        TimeCircleActivatedSpot4 = TimeCircleActivated;
        TimeCircleWaitingSpot1 = TimeCircleWaiting;
        TimeCircleWaitingSpot2 = TimeCircleWaiting;
        TimeCircleWaitingSpot3 = TimeCircleWaiting;
        TimeCircleWaitingSpot4 = TimeCircleWaiting;
        _minIntensity = _minIntensityCircle;
        _maxIntensity = _maxIntensityCircle;
        colcir = CirclesColor;
        npampallugues = pampallugues;
        gradient_G = gradient;
    }
}
