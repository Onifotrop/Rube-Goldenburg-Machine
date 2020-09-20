using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigFour : MonoBehaviour
{
    public Camera cam4;
    public Camera cam5;

    public GameObject Car2;
    // Start is called before the first frame update
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("domino");
        cam4.enabled = false;
        cam5.enabled = true;
    }
}
