using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoilerRoomTrigger : MonoBehaviour
{
    private AudioSource boilerSound;

    void Start()
    {
        boilerSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        boilerSound.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        boilerSound.Stop();
    }
}
