using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVariables : ICloneable
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

    public static T CloneObject<T>(this object source)
    {
        T result = Activator.CreateInstance<T>();
        //// **** made things  
        return result;
    }

    void Start()
    {
        patron2.Set(patron.x, patron.y, patron.z, patron.w);
        TimeCircleActivatedSpot1 = TimeCircleActivated.CloneObject();
        TimeCircleActivatedSpot2 = TimeCircleActivated.Clone();
        TimeCircleActivatedSpot3 = TimeCircleActivated.Clone();
        TimeCircleActivatedSpot4 = TimeCircleActivated.Clone();
        TimeCircleWaitingSpot1 = TimeCircleWaiting.Clone();
        TimeCircleWaitingSpot2 = TimeCircleWaiting.Clone();
        TimeCircleWaitingSpot3 = TimeCircleWaiting.Clone();
        TimeCircleWaitingSpot4 = TimeCircleWaiting.Clone();
        _minIntensity = _minIntensityCircle;
        _maxIntensity = _maxIntensityCircle;
        colcir = CirclesColor;
    }

    public object Clone()
    {
        throw new NotImplementedException();
    }
}
