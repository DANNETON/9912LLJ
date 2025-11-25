using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;
using System.Numerics;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class LoopRotation : MonoBehaviour
{
    public Vector3 minAngle = new Vector3();
    public Vector3 maxAngle = new Vector3();
    public bool mirror = false;

    public void OnEnable()
    {
        
    }

    private void Start()
    {
        //Reset();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void Reset()
    {
        
    }

    public void DealProgress(float progress)
    {
        if (mirror)
        {
            progress = Mathf.PingPong(progress, 1);
        }
        progress = Mathf.Clamp01(progress % 1);

        float x = Mathf.Lerp(minAngle.x, maxAngle.x, progress);
        float y = Mathf.Lerp(minAngle.y, maxAngle.y, progress);
        float z = Mathf.Lerp(minAngle.z, maxAngle.z, progress);

        transform.rotation = Quaternion.Euler(x, y, z);
    }
}
