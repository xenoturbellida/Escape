using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatuesPrompt : MonoBehaviour
{
    public GameObject prompt;
    public StatuesPuzzle puzzleScript;
    
    // Start is called before the first frame update
    void Start()
    {
        prompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (puzzleScript.wasSolved)
        {
            prompt.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!puzzleScript.wasSolved)
        {
            prompt.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        prompt.SetActive(false);
    }
}
