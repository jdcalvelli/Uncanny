using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendRotation : MonoBehaviour
{
    [SerializeField]
    public float eulerAngX { get; protected set; }
    [SerializeField]
    public float eulerAngY { get; protected set; } //rotating around up down axis
    [SerializeField]
    public float eulerAngZ { get; protected set; }
    public float SwitchRotation = 1f;
    public float SwitchRotationOld = -1f;


    void Update()
    {
        /*
        if (SwitchRotation == 1f && SwitchRotationOld != SwitchRotation)
        {
            eulerAngX = transform.localEulerAngles.x;
            eulerAngY = transform.localEulerAngles.y;
            eulerAngZ = transform.localEulerAngles.z;
            Debug.Log("Switch Rotation Enabled!");
            SwitchRotationOld = SwitchRotation;
        }  if (SwitchRotation == 0f && SwitchRotationOld != SwitchRotation)
        {
            Debug.Log("Switch Rotation Disabled!");
           //SwitchRotationOld = SwitchRotation;
        }
        */
        if (SwitchRotation == 1f)
        {
            eulerAngX = transform.localEulerAngles.x;
            eulerAngY = transform.localEulerAngles.y;
            eulerAngZ = transform.localEulerAngles.z;
            //   Debug.Log("Switch Rotation Enabled!");
            //  SwitchRotationOld = SwitchRotation;
        }



        /*
        Debug.Log("X rotation: " + eulerAngX);
        Debug.Log("Y rotation: " + eulerAngY);
        Debug.Log("Z rotation: " + eulerAngZ);
        */
    }
    public void ToggleRotation(float toggled)
    {
        SwitchRotation = toggled;

    }
}
