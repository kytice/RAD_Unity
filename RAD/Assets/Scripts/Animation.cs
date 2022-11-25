using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    Animator dogControl;

    // Start is called before the first frame update
    void Start()
    {
        dogControl = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            dogControl.SetBool("isWalking", true);
        }
        else
            dogControl.SetBool("isWalking", false);
    }
}
