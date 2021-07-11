using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public GameObject prompt;
    public GameObject note;
    public GameObject player;
    public GameObject cameraToDisable;
    public bool needToShowNote;
    public bool near;
    public bool wasRead;

    void Start()
    {
        prompt.SetActive(false);
        player.SetActive(true);
        note.SetActive(false);
    }


    void Update()
    {
        if (near && Input.GetKeyDown(KeyCode.F))
        {
            wasRead = true;
            needToShowNote = !needToShowNote;
            player.SetActive(!needToShowNote);
            cameraToDisable.SetActive(!needToShowNote);
            note.SetActive(needToShowNote);
            prompt.SetActive(!needToShowNote);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        near = true;
        prompt.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        near = false;
        prompt.SetActive(false);
    }
}
