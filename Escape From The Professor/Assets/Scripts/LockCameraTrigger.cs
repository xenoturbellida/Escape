using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCameraTrigger : MonoBehaviour
{
    public bool near;

    public GameObject cam;
    public bool cameraIsActive = false;
    public Lock lockPuzzle;

    // Update is called once per frame
    void Update()
    {
        if (lockPuzzle.wasSolved)
        {
            cam.SetActive(false);
        }
        else if (near && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.Escape)))
        {
            cameraIsActive = !cameraIsActive;
            cam.SetActive(cameraIsActive);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        near = true;
    }

    private void OnTriggerExit(Collider other)
    {
        near = false;
    }
    
}
