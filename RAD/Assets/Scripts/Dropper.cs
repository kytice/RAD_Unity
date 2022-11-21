using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    float timeToWait = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.time);
        if(Time.time > timeToWait)
        {
            Debug.Log("5 seconds has elapsed");
        }
    }
}
