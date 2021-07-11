using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbienceSounds : MonoBehaviour
{
    private AudioSource audio;
    public AudioSource cutsceneAudio;
    public bool inHall;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (inHall && !cutsceneAudio.isPlaying && !audio.isPlaying)
        {
            audio.Play();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        inHall = true;
    }

    private void OnTriggerExit(Collider other)
    {
        inHall = false;
        audio.Stop();
    }
}
