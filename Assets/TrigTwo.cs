using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigTwo : MonoBehaviour
{
    public Camera cam2;
    public Camera cam3;
    // Start is called before the first frame update
    

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("hand coming");
        cam2.enabled = false;
        cam3.enabled = true;
    }
}
