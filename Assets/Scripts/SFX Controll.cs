using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXControll : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource HitSFX;

    void Start()
    {
        HitSFX = GetComponent<AudioSource>();
        
    }

    void Update()
    {
        HitSFX.Play();
    }
}
