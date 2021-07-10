using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCameraTrigger : MonoBehaviour
{
    public bool near;

    public GameObject cam;
    public bool cameraIsActive;
    public bool playerIsActive = true; 
    public Lock lockPuzzle;
    public GameObject prompt;
    public GameObject player;

    void Start()
    {
        prompt.SetActive(false);
        cam.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (lockPuzzle.wasSolved)
        {
            prompt.SetActive(false);
            cam.SetActive(false);
            player.SetActive(true);
        }
        else if (near && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Escape)))
        {
            cameraIsActive = !cameraIsActive;
            cam.SetActive(cameraIsActive);

            playerIsActive = !playerIsActive;
            player.SetActive(playerIsActive);
            
            prompt.SetActive(false);
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
