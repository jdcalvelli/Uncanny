using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscobjdistlist : MonoBehaviour
{
    public List<GameObject> Objekty;
    OscMessage message;
    public OSC osc;
    public string adress = "/distance/";

    void Start()
    {
        
    }

    void Update()
    {

        for (int i = 0; i <= Objekty.Count; i++)
        {
            float distance = Vector3.Distance(transform.position, Objekty[i].transform.position);
            message = new OscMessage();
            message.address = adress + i;
            Debug.Log(adress + i);
            message.values.Add(distance);
            osc.Send(message);
        }

    }
}
