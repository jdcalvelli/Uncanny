using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.VFX.Utility;

[ExecuteInEditMode]
public class VFXvalue : MonoBehaviour
{
    public VisualEffect _target = null;
    public string _parameterName = "";
    public float ChangeValue;

    void Start()
    {
        _target = GetComponent<VisualEffect>();
    }

    void Update()
    {
        _target.SetFloat(_parameterName, ChangeValue);
    }

    public void Toggle(int input)
    {
        if (input == 1.0)
          _target.enabled = true;
        if (input == 0.0)
          _target.enabled = false;
    }

}
