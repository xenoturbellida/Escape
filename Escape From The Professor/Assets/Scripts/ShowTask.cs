using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTask : MonoBehaviour
{
    public GameObject task;
    public AudioSource cutsceneAudio;
    public int delayInSeconds = 5;
    public int frame;
    
    void Start()
    {
        task.SetActive(false);
        // StartCoroutine(ShowTaskFewSeconds());
    }

    private void Update()
    {
        if (!cutsceneAudio.isPlaying)
        {
            frame += 1;
            if (frame == 1)
            {
                StartCoroutine(ShowTaskFewSeconds());
            }
        }
    }

    IEnumerator ShowTaskFewSeconds()
    {
        task.SetActive(true);
        yield return new WaitForSeconds(delayInSeconds);
        task.SetActive(false);
    }
}
