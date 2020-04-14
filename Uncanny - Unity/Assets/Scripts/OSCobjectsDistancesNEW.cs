using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OSCobjectsDistancesNEW : MonoBehaviour
{
    public List<GameObject> Objekty;
    OscMessage message;
    public OSC osc;
    public string adress1 = "/distance/";
    public string adress2 = "/angle/";

    void Start()
    {
        
    }

    void Update()
    {

        for (int i = 0; i < Objekty.Count; i++)
        {
            float distance = Vector3.Distance(transform.position, Objekty[i].transform.position);
            message = new OscMessage();
            message.address = adress1 + i;
            Debug.Log(adress1 + i);
            message.values.Add(distance);
            osc.Send(message);

            Vector3 targetDir = Objekty[i].transform.position - transform.position;
            Debug.Log("targetDir" + i + ": " + targetDir);
            float angle = Vector3.Angle(targetDir, transform.forward);

            angle = Vector3.SignedAngle(targetDir, transform.forward, Vector3.up);



            message = new OscMessage();
            message.address = adress2 + i;
            Debug.Log(adress2 + i);
            message.values.Add(angle);
            osc.Send(message);

        }

    }
}
