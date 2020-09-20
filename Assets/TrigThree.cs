using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigThree : MonoBehaviour
{
    public Camera cam3;
    public Camera cam4;
        
    // Start is called before the first frame update
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("car in");
        cam3.enabled = false;
        cam4.enabled = true;
    }
}
