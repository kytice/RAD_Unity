using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag != "Hit" && other.gameObject.tag != "Plane" && other.gameObject.tag != "Finish")
        {
            hits++;
            Debug.Log("You've bumped into a thing this many times: " + hits);
        }

        if(other.gameObject.tag == "Finish")
        {
            Debug.Log("FINISH! You've bumped into a thing this many times: " + hits);
        }
    }
}
