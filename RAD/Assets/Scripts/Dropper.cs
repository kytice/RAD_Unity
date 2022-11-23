using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    Rigidbody body;
    SkinnedMeshRenderer rendy; 
    float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rendy = GetComponent<SkinnedMeshRenderer>();
        body = GetComponent<Rigidbody>();

        rendy.enabled = false;
        body.useGravity = false;

    }

    // Update is called once per frame
    void Update() 
    {
        Debug.Log(Time.time);
        if(Time.time > timeToWait)
        {
            rendy.enabled = true;
            body.useGravity = true;
        }
    }
}
