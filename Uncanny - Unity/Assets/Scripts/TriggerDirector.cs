using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;



public class TriggerDirector : MonoBehaviour
{
    private bool opened = false;
    public bool PlayOnce = false;

    public PlayableDirector timeline;
    // Start is called before the first frame update

    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
             timeline.Pause();
            Debug.Log("Go to the trench");
        }
        
    }

    void OnTriggerEnter(Collider other)
    {   
        if (PlayOnce == true)
        {
        if (opened == false)
                {
                    if (other.gameObject.tag == "Player")
                    {
                        timeline.Play();
                        Debug.Log("Trh isenc Opened");
                        opened = true;
                    }

                }
        }
        else if (PlayOnce == false)
        {
                if (other.gameObject.tag == "Player")
                {
                    timeline.Play();
                    Debug.Log("Trh isenc Opened");
                    opened = true;
                }

            }
        }



    }


