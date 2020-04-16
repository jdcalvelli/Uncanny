using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myTriggerLocOSCsend : MonoBehaviour
{
    public int status = 0;
    private int statusOld = 0;
    public string adress;
    OscMessage message;
    public OSC osc;


    // Use this for initialization
    void Start()
    {
        statusOld = 0;
        status = 0;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            status = 1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            status = 0;
        }
    }
    // Update is called once per frame

    void Update()
    {
        if (status == 1 & statusOld == 0)
        {
            statusOld = 1;
            message = new OscMessage();
            message.address = adress;
            message.values.Add(status);
            osc.Send(message);
        }
        if (status == 0 & statusOld == 1)
        {
            statusOld = 0;
            message = new OscMessage();
            message.address = adress;
            message.values.Add(status);
            osc.Send(message);
        }
        /*
		if (status == 1 & statusOld == 0)
        {
            statusOld = 1;
            message = new OscMessage();
            message.address = adress;
            message.values.Add(status);
            osc.Send(message); 
        }
        if (status == 0 & statusOld == 1)
        {
            statusOld = 0;
            message = new OscMessage();
            message.address = adress;
            message.values.Add(status);
            osc.Send(message);
        }
        */


    }
}
