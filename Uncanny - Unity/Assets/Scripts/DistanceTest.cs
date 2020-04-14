using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class DistanceTest : MonoBehaviour
{
    public GameObject player_;
    public GameObject obj1;
    public GameObject obj2;

    [SerializeField]
    public float Distance_obj1 { get; protected set; } //necessary for oscjack?
    [SerializeField]
    public float Distance_obj2 { get; protected set; }

    void Update()
    {
        Distance_obj1 = Vector3.Distance(player_.transform.position, obj1.transform.position);
        Distance_obj2 = Vector3.Distance(player_.transform.position, obj2.transform.position);
    }
}
