using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainDoorSound : MonoBehaviour
{
    private AudioSource closeSound;

    public int frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        closeSound = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        frame += 1;
        if (frame == 1)
        {
            closeSound.Play();
        }
    }
}
