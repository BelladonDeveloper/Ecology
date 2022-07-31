using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JodyTarget : MonoBehaviour
{
    public GameObject ZaxidOne;
    void Start()
    {
        
    }

    void Update()
    {
         Vector3 diff = ZaxidOne.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(diff);
        transform.rotation = rotation;
    }
}
