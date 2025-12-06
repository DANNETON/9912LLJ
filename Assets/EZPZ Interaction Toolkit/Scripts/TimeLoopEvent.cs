using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using NUnit.Framework.Constraints;

public class TimeLoopEvent : MonoBehaviour
{
    [Header("Clock Parameters")]
    public float startingTime = 0;
    public float clock;
    public UnityEvent<float> onClockFrame;
    public UnityEvent<int> onClockZero;
    public UnityEvent onReset;
    public float countdown = 0;
    private int triggerCount = 0;
    private int triggerIndex = 0;
    public float loopInterval = 1.0f;
    public float duration = 1;
    public bool resetOnEnable = true;

    public void OnEnable()
    {
        if(resetOnEnable)
            Reset();
    }

    private void Start()
    {
        //Reset();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isActiveAndEnabled)
        {
            if (countdown > 0) 
            {
                countdown -= Time.fixedDeltaTime;
                if (countdown < 0) 
                {
                    enabled = false;
                    return;
                } 
            }
           
            clock += Time.fixedDeltaTime;
            int count = triggerCount;
            triggerCount = (int)(clock / loopInterval);
            onClockFrame.Invoke(clock / loopInterval);
            if (triggerCount > count)
            {
                onClockZero.Invoke(triggerCount);
            }
        }
        
    }
    

    public void Setbegin() 
    {
        enabled = true;
        countdown = duration;


    } 
    public void Reset()
    {
        //clock = startingTime;
        onReset.Invoke();
    }
    public void SetAuto() 
    {
        enabled = true;
        countdown = 0;
    }
    public void SetAutoOff()
    {
        enabled = false ;
    }
}
