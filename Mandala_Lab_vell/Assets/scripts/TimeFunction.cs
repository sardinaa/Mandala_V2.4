using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeFunction
{

    private Action action;
    private float timer;
    public float countdown;

    public TimeFunction(Action action, float timer)
    {
        this.timer = timer;
        this.action = action;
        countdown = timer;
    }

    // Update is called once per frame
    public void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown < 0)
        {
            action();
            countdown = timer;
        }

        if(action.Method.Name == "TurnOnCircle")
        {

        }
    }

}
