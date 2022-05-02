using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : MonoBehaviour
{
    public Vector4 patron;
    public static Vector4 patron2;
    public float TimeCircleActivated;
    public static float TimeCircleActivatedSpot1;
    public static float TimeCircleActivatedSpot2;
    public static float TimeCircleActivatedSpot3;
    public static float TimeCircleActivatedSpot4;
    public float TimeCircleWaiting;
    public static float TimeCircleWaitingSpot1;
    public static float TimeCircleWaitingSpot2;
    public static float TimeCircleWaitingSpot3;
    public static float TimeCircleWaitingSpot4;
    public Color CirclesColor;
    public static Color colcir;
    public float _minIntensityCircle, _maxIntensityCircle;
    public static float _minIntensity, _maxIntensity;


    void Start()
    {
        patron2.Set(patron.x, patron.y, patron.z, patron.w);
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
    }
}
