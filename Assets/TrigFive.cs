using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigFive : MonoBehaviour
{
    public Camera cam5;
    public Camera cam6;
    
    // Start is called before the first frame update
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TOAST!");
        cam5.enabled = false;
        cam6.enabled = true;
        
    }
}
