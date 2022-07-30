using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JodyTarget : MonoBehaviour
{
    public GameObject ZaxidOne;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Vector3 diff = ZaxidOne.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(diff);
        transform.rotation = rotation;
    }
}
