using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource STS;

    void Start()
    {
        STS = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        STS.Play();
    }
}
